using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Inventory.Maps
{
    public class StockTransferLineMap : ClassMap<StockTransferLine>
    {
        public StockTransferLineMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Identity().Column("TransactionLineId");
            References(m => m.Object);
            Map(m => m.LineNumber);
            References(m => m.Product);
            Map(m => m.Description).Length(100);
            Map(m => m.Quantity);
            Map(m => m.Price);
            Map(m => m.PriceWithVAT);
            Map(m => m.DiscountSum);
            Map(m => m.DiscountPercent);
            Map(m => m.LineAmount);
            Map(m => m.GrossTotal);
            Map(m => m.StockCost );
            Map(m => m.StockTotal);
            References(m => m.WarehouseFrom);
            References(m => m.WarehouseTo);
            Map(m => m.LineComments).Length(250);

            Component(m => m.RecordLog);
        }
    }
}
