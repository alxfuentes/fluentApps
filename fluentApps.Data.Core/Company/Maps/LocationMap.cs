using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class LocationMap : ClassMap<Location>
    {
        public LocationMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("LocationId");
            Map(m => m.LocationName).Length(60);
            Map(m => m.Description).Length(250);

            Component(m => m.RecordLog);
        }
    }
}
