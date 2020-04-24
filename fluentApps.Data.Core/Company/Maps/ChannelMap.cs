using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class ChannelMap : ClassMap<Channel>
    {
        public ChannelMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("ChannelId").Length(20);
            Map(m => m.ChannelName).Length(50);
            Map(m => m.Description).Length(250);
            Component(m => m.RecordLog);
        }
    }
}
