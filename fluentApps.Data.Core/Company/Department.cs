using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class Department : DomainObject<int>
    {
        // public virtual int DepartmentId { get; set; }
        public virtual string DepartmentName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Department()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
