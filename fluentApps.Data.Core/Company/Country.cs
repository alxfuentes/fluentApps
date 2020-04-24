using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class Country : DomainObject<string>
    {
        // public virtual string CountryId { get; set; }
        public virtual string CountryName { get; set; }
        public virtual string ISOCode2 { get; set; }
        public virtual string ISOCode3 { get; set; }
        public virtual int UNCode { get; set; }
        public virtual string DialingCode { get; set; }
        public virtual Currency Currency { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Country()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
