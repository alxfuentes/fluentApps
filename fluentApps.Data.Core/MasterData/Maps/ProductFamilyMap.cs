using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class ProductFamilyMap : ClassMap<ProductFamily>
    {
        public ProductFamilyMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Length(32);
            Map(m => m.FamilyName).Length(50).Not.Nullable();
            Map(m => m.Description).Length(100);

            Component(m => m.RecordLog);
        }
    }
}
