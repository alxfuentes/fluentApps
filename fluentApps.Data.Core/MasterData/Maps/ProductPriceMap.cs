using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class ProductPriceMap : ClassMap<ProductPrice>
    {
        public ProductPriceMap()
        {
            CompositeId()
                .KeyReference(m => m.Product)
                .KeyReference(m => m.PriceList);
            Map(m => m.Price);

            Component(m => m.RecordLog);


        }
    }
}
