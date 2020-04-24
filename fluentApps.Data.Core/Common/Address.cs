using fluentApps.Data.Core.Company;

namespace fluentApps.Data.Core.Common
{
    public class Address
    {
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual State State { get; set; }
        public virtual County County { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual Country Country { get; set; }
        
        public virtual GeoLocation GeoPos { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", AddressLine1, City, State);
        }
    }


}
