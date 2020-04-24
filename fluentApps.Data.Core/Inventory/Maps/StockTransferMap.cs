using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Inventory.Maps
{
    public class StockTransferMap : ClassMap<StockTransfer>
    {
        public StockTransferMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Identity();
            References(m => m.Entity);
            References(m => m.Series);
            Map(m => m.DocumentNumber);
            Map(m => m.Reference);

            Map(m => m.DocumentDate);
            Map(m => m.DueDate);
            Map(m => m.PostingDate);

            Map(m => m.PostId);

            References(m => m.WarehouseFrom);
            References(m => m.WarehouseTo);

            References(m => m.SalesPerson);

            Map(m => m.Comments).Length(250);

            References(m => m.BaseType);
            Map(m => m.BaseId);

            HasMany(m => m.Lines);
        }
    }
}
