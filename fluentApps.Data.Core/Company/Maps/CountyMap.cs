using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class CountyMap : ClassMap< County >
    {
        public CountyMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("CountyId");
            Map(m => m.CountyName).Length(100);
            References(m => m.State);

            Component(m => m.GeoPos);

            Component(m => m.RecordLog);
        }
    }
}
