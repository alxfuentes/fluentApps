using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class Currency : DomainObject<string>
    {
        //public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public string CentsName { get; set; }

        public RecordLog RecordLog { get; set; }

        public Currency()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
