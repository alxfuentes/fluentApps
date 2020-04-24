using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class Currency : DomainObject<string>
    {
        //public virtual string CurrencyId { get; set; }
        public virtual string CurrencyName { get; set; }
        public virtual string Description { get; set; }
        public virtual string ShortName { get; set; }
        public virtual string CentsName { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Currency()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
