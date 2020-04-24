using System;
using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class Company : DomainObject<string>
    {
        // public virtual string CompanyCode { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string LegalName { get; set; }
        public virtual string PrintHeader { get; set; }

        public virtual string FiscalId { get; set; }

        public virtual Address Address { get; set; }
        public virtual string Phone1 { get; set; }
        public virtual string Phone2 { get; set; }
        public virtual string Fax { get; set; }
        public virtual string WebSite { get; set; }
        public virtual string EMail { get; set; }

        public virtual string LegalRep { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Company()
        {
            this.Address = new Address();
            this.RecordLog = new RecordLog();
        }
    }
}
