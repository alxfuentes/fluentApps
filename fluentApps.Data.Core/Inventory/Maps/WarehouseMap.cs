using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Inventory.Maps
{
    public class WarehouseMap : ClassMap<Warehouse>
    {
        public WarehouseMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("WarehouseId").Length(20);
            Map(m => m.WarehouseName).Length(50).Not.Nullable();
            Map(m => m.Type);

            Component(m => m.RecordLog);
        }
    }
}
