using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class ProductCategoryMap : ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Length(32);
            Map(m => m.CategoryName).Length(50).Not.Nullable();
            Map(m => m.Description).Length(100);

            Component(m => m.RecordLog);
        }
    }
}
