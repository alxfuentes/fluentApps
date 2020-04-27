using System;
using fluentApps.Model.Core.Common;
using fluentApps.Model.Core.Company;
using fluentApps.Model.Core.MasterData;

namespace fluentApps.Model.Core.HumanCapital
{
    public class Employee : DomainObject<int>
    {
        // public int EmployeeId {get;set;}
        public string AlternateCode { get; set; }
        public Person PersonalData { get; set; }
        public Address Work { get; set; }
        public string WorkEMail { get; set; }
        public string WorkPhone { get; set; }
        public Department Department { get; set; }
        public Branch Branch { get; set; }
        public Location Location { get; set; }

        public string Position { get; set; } // Position
        public string Job { get; set; } // Job

        public Employee Manager { get; set; }

        public DateTime? HireDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int ContractNumber { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }

        public decimal Salary { get; set; }
        public decimal Bonifications { get; set; }
        public decimal Costs { get; set; }

        public BusinessPartner Bank { get; set; }
        public string BankAccount { get; set; }

        public string Notes { get; set; }

        public RecordLog RecordLog { get; set; }

        public Employee()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
