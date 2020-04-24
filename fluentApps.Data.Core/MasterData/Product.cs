using System;
using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class Product : DomainObject<string>
    {
        // public string ItemCode { get; set; }
        public virtual string ProductName       { get; set; }
        public virtual string Description       { get; set; }
        public virtual string BarCode           { get; set; }
        public virtual string ManufacturerCode  { get; set; }
        public virtual string ManufacturerDescription { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual ProductFamily Family     { get; set; }
        public virtual ProductArea Area         { get; set; }
        public virtual ProductBrand Brand       { get; set; }
        public virtual string UnitOfMeasure     { get; set; }
        public virtual decimal ProductCost      { get; set; }
        public virtual decimal LastPurchasePrice { get; set; }
        public virtual DateTime? LastPurchaseDate { get; set; }
        public virtual DateTime? LastSaleDate   { get; set; }

        public virtual string Comments { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Product()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
