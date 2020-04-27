using System;
using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class Company : DomainObject<string>
    {
        // public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string LegalName { get; set; }
        public string PrintHeader { get; set; }

        public string FiscalId { get; set; }

        public Address Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string EMail { get; set; }

        public string LegalRep { get; set; }

        public RecordLog RecordLog { get; set; }

        public Company()
        {
            this.Address = new Address();
            this.RecordLog = new RecordLog();
        }
    }
}
