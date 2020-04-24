using System;
using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.Company;
using fluentApps.Data.Core.HumanCapital;

namespace fluentApps.Data.Core.MasterData
{
    public class SalesPerson : DomainObject<int>
    {
        public virtual string SalesPersonName { get; set; }
        public virtual Department Department { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual Channel Channel { get; set; }
        
        public virtual spPersonRole Role { get; set; } 

        public virtual RecordLog RecordLog { get; set; }

        public SalesPerson()
        {
            this.RecordLog = new RecordLog();
        }
    }

    public enum spPersonRole
    {
        Sales,
        Purchasing,
        Inventory
    }
}
