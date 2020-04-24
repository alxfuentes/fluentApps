using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Common.Maps
{
    public class ObjectValueMap : ClassMap<ObjectValue>
    {
        public ObjectValueMap()
        {
            //Id(x => x.Id).Column("ProductId")
            // .GeneratedBy
            // .HiLo("NH_HiLo", "NextHi", "1000", "TableKey = ''Product''");

            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("ValueId");
            Map(m => m.EntityId).Length(64);
            Map(m => m.PropertyId).Length(64);
            Map(m => m.Value).Length(64);
            Map(m => m.Description).Length(250);

            Component(m => m.RecordLog);
        }
    }
}
