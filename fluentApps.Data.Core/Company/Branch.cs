using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.HumanCapital;

namespace fluentApps.Data.Core.Company
{
    public class Branch : DomainObject<int>
    {
        // public virtual int BranchId {get;set;}

        public virtual string BranchName { get; set; }
        public virtual string Description { get; set; }
  
        public virtual Employee Manager { get; set; }

        public virtual Address Address { get; set; }
        public virtual RecordLog RecordLog { get; set; }

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
