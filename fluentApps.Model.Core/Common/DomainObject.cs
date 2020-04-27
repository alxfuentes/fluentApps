using fluentApps.Utils;

namespace fluentApps.Model.Core.Common
{
    /// <summary>
    /// For a discussion of this object, see 
    /// http://devlicio.us/blogs/billy_mccafferty/archive/2007/04/25/using-equals-gethashcode-effectively.aspx
    /// </summary>
    public abstract class DomainObject<IdT>
    {
        /// <summary>
        /// ID may be of type string, int, custom type, etc.
        /// Setter is protected to allow unit tests to set this property via reflection and to allow 
        /// domain objects more flexibility in setting this for those objects with assigned IDs.
        /// </summary>
        public IdT ObjectId
        {
            get { return id; }
            set { id = value; }
            //protected set { id = value; }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as DomainObject<IdT>);
        }

        public bool Equals(DomainObject<IdT> compareTo)
        {
            return (compareTo != null) &&
                   (HasSameNonDefaultIdAs(compareTo) ||
                // Since the IDs aren't the same, either of them must be transient to 
                // compare business value signatures
                    (((IsTransient()) || compareTo.IsTransient()) &&
                     HasSameBusinessSignatureAs(compareTo)));
        }

        //public bool Equals(Entity<TId> other)
        //{
        //    if (other == null)
        //        return false;
        //    if (ReferenceEquals(this, other))
        //        return true;
        //    if (!IsTransient(this) &&
        //    !IsTransient(other) &&
        //    Equals(Id, other.Id))
        //    {
        //        var otherType = other.GetUnproxiedType();
        //        var thisType = GetUnproxiedType();
        //        return thisType.IsAssignableFrom(otherType) ||
        //        otherType.IsAssignableFrom(thisType);
        //    }
        //    return false;
        //}

        /// <summary>
        /// Transient objects are not associated with an item already in storage.  For instance,
        /// a <see cref="Customer" /> is transient if its ID is 0.
        /// </summary>
        public bool IsTransient()
        {
            return ObjectId == null || ObjectId.Equals(default(IdT));
        }

        /// <summary>
        /// Must be provided to properly compare two objects
        /// </summary>
        //public abstract override int GetHashCode();
        public override int GetHashCode()
        {
            if (Equals(ObjectId, default(IdT)))
                return base.GetHashCode();
            return ObjectId.GetHashCode();
        }

        private bool HasSameBusinessSignatureAs(DomainObject<IdT> compareTo)
        {
            Check.Require(compareTo != null, "compareTo may not be null");

            return GetHashCode().Equals(compareTo.GetHashCode());
        }

        /// <summary>
        /// Returns true if self and the provided persistent object have the same ID values 
        /// and the IDs are not of the default ID value
        /// </summary>
        private bool HasSameNonDefaultIdAs(DomainObject<IdT> compareTo)
        {
            Check.Require(compareTo != null, "compareTo may not be null");

            return (ObjectId != null && !ObjectId.Equals(default(IdT))) &&
                   (compareTo.ObjectId != null && !compareTo.ObjectId.Equals(default(IdT))) &&
                   ObjectId.Equals(compareTo.ObjectId);
        }

        private IdT id = default(IdT);
    }
}
