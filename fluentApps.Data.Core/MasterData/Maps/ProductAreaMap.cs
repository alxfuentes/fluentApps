using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class ProductAreaMap : ClassMap<ProductArea>
    {
        public ProductAreaMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Length(32);
            Map(m => m.AreaName).Length(50).Not.Nullable();
            Map(m => m.Description).Length(100);

            Component(m => m.RecordLog);
        }
    }
}
