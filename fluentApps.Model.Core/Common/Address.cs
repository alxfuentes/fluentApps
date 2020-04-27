using fluentApps.Model.Core.Company;

namespace fluentApps.Model.Core.Common
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public County County { get; set; }
        public string ZipCode { get; set; }
        public Country Country { get; set; }
        
        public GeoLocation GeoPos { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", AddressLine1, City, State);
        }
    }


}
