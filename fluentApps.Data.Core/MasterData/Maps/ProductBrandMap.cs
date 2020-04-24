using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class ProductBrandMap : ClassMap<ProductBrand>
    {
        public ProductBrandMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Length(32);
            Map(m => m.BrandName).Length(50).Not.Nullable();
            Map(m => m.Description).Length(100);

            Component(m => m.RecordLog);
        }
    }
}
