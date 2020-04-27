using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class Channel : DomainObject<string>
    {
        // public int DepartmentId { get; set; }
        public string ChannelName { get; set; }
        public string Description { get; set; }

        public RecordLog RecordLog { get; set; }

        public Channel()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
