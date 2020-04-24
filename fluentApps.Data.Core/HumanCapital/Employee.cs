using System;
using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.Company;
using fluentApps.Data.Core.MasterData;

namespace fluentApps.Data.Core.HumanCapital
{
    public class Employee : DomainObject<int>
    {
        // public virtual int EmployeeId {get;set;}
        public virtual string AlternateCode { get; set; }
        public virtual Person PersonalData { get; set; }
        public virtual Address Work { get; set; }
        public virtual string WorkEMail { get; set; }
        public virtual string WorkPhone { get; set; }
        public virtual Department Department { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Location Location { get; set; }

        public virtual string Position { get; set; } // Position
        public virtual string Job { get; set; } // Job

        public virtual Employee Manager { get; set; }

        public virtual DateTime? HireDate { get; set; }
        public virtual DateTime? EndDate { get; set; }

        public virtual int ContractNumber { get; set; }
        public virtual DateTime? ContractStartDate { get; set; }
        public virtual DateTime? ContractEndDate { get; set; }

        public virtual decimal Salary { get; set; }
        public virtual decimal Bonifications { get; set; }
        public virtual decimal Costs { get; set; }

        public virtual BusinessPartner Bank { get; set; }
        public virtual string BankAccount { get; set; }

        public virtual string Notes { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Employee()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
