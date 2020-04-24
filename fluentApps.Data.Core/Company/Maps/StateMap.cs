using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class StateMap : ClassMap< State >
    {
        public StateMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("StateId");
            Map(m => m.StateName).Length(100);
            References(m => m.Country);

            Component(m => m.GeoPos);

            Component(m => m.RecordLog);
        }
    }
}
