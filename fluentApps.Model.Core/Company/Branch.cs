using fluentApps.Model.Core.Common;
using fluentApps.Model.Core.HumanCapital;

namespace fluentApps.Model.Core.Company
{
    public class Branch : DomainObject<int>
    {
        // public int BranchId {get;set;}

        public string BranchName { get; set; }
        public string Description { get; set; }
  
        public Employee Manager { get; set; }

        public Address Address { get; set; }
        public RecordLog RecordLog { get; set; }

        public Branch()
        {
            this.Address = new Address();
            this.RecordLog = new RecordLog();
        }

        public override string ToString()
        {
            return BranchName;
        }
    }
}
