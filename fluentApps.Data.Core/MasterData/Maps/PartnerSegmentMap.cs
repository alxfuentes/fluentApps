using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.MasterData.Maps
{
    public class PartnerSegmentMap : ClassMap<PartnerSegment>
    {
        public PartnerSegmentMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("SegmentId").Length(32);
            Map(m => m.SegmentName).Length(50).Not.Nullable();
            Map(m => m.Description).Length(100);

            Component(m => m.RecordLog);
        }
    }
}
