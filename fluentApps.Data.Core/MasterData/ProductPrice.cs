using System;
using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class ProductPrice
    {
        public virtual Product Product { get; set; }
        public virtual PriceList PriceList { get; set; }
        public virtual decimal Price { get; set; }
    
        public virtual RecordLog RecordLog { get; set; }

        public ProductPrice()
        {
            this.RecordLog = new RecordLog();
        }

        // Equals operator for Composite Key Entities
        public override bool Equals(object obj)
        {
            var other = obj as ProductPrice;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Product == Product && other.PriceList == PriceList;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Product.GetHashCode() * 397) ^ PriceList.ObjectId;
            }
        }


    }
}
