using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Inventory
{
    public class Warehouse : DomainObject<string>
    {
        public virtual string WarehouseName { get; set; }
        public virtual Address Address { get; set; }
        public virtual invWarehouseType Type { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Warehouse()
        {
            this.RecordLog = new RecordLog();
        }
    }

    public enum invWarehouseType
    {
        Sales,
        Transit,
        Disrepair,
        Customs
    }
}
