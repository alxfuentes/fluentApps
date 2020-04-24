using System;
using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.MasterData;

namespace fluentApps.Data.Core.Inventory
{
    public class Stock
    {
        public virtual Warehouse Warehouse { get; set; }
        public virtual Product Product { get; set; }

        public virtual decimal InStock { get; set; }
        public virtual decimal ProductCost { get; set; }
        public virtual DateTime? LastIssueDate { get; set; }
        public virtual DateTime? LastEntryDate { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Stock()
        {
            this.RecordLog = new RecordLog();
        }

        // Equals operator for Composite Key Entities
        public override bool Equals(object obj)
        {
            var other = obj as Stock;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Product == Product && other.Warehouse == Warehouse;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Product.GetHashCode() * 397) ^ 4; // Warehouse.RecordLog.RecordId;
            }
        }
    }
}
