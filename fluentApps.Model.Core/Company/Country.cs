using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class Country : DomainObject<string>
    {
        // public string CountryId { get; set; }
        public string CountryName { get; set; }
        public string ISOCode2 { get; set; }
        public string ISOCode3 { get; set; }
        public int UNCode { get; set; }
        public string DialingCode { get; set; }
        public Currency Currency { get; set; }

        public RecordLog RecordLog { get; set; }

        public Country()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
