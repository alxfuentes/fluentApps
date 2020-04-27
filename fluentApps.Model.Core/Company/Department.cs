using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class Department : DomainObject<int>
    {
        // public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public RecordLog RecordLog { get; set; }

        public Department()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
