using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class PartnerGroupMap : ClassMap<PartnerGroup>
    {
        public PartnerGroupMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("GroupId").Length(32);
            Map(m => m.GroupName).Length(50).Not.Nullable();
            Map(m => m.Description).Length(100);
            Map(m => m.GroupType);

            Component(m => m.RecordLog);
        }
    }
}
