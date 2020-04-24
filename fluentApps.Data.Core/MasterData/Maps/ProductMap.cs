using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("ProductId").Length(25);
            Map(m => m.ProductName).Length(100);
            Map(m => m.Description       ).Length(250);
            Map(m => m.BarCode           ).Length(32);
            Map(m => m.ManufacturerCode  ).Length(50);
            Map(m => m.ManufacturerDescription).Length(100);
            References(m => m.Category   );
            References(m => m.Family     );
            References(m => m.Area       );
            References(m => m.Brand      );
            Map(m => m.UnitOfMeasure     ).Length(20);
            Map(m => m.ProductCost       );
            Map(m => m.LastPurchasePrice );
            Map(m => m.LastPurchaseDate  );
            Map(m => m.LastSaleDate      );

            Map(m => m.Comments).Length(250);

            Component(m => m.RecordLog);
        }
    }
}
