using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Inventory.Maps
{
    public class StockMap : ClassMap<Stock>
    {
        public StockMap()
        {
            CompositeId()
                .KeyReference(m => m.Warehouse)
                .KeyReference(m => m.Product);
            Map(m => m.InStock);
            Map(m => m.ProductCost);
            Map(m => m.LastIssueDate);
            Map(m => m.LastEntryDate);

            Component(m => m.RecordLog);
        }
    }
}
