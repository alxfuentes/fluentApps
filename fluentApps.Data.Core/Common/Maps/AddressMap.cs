using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Common.Maps
{
    public class AddressMap : ComponentMap<Address> 
    {
        public AddressMap()
        {
            Map(a => a.AddressLine1).Length(100);
            Map(a => a.AddressLine2).Length(100);
            Map(a => a.City).Length(60);
            References(a => a.State);
            References(a => a.County);
            Map(a => a.ZipCode).Length(10);
            References(a => a.Country);

            Component(m => m.GeoPos);
        }
    }
}
