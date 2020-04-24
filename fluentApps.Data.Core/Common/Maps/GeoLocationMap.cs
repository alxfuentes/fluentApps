using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Common.Maps
{
    public class GeoLocationMap : ComponentMap<GeoLocation>
    {
        public GeoLocationMap()
        {
            Map(m => m.Latitude).Precision(19).Scale(6);
            Map(m => m.Longitude).Precision(19).Scale(6);
            Map(m => m.Elevation).Precision(19).Scale(6);
        }
    }
}
