using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class Channel : DomainObject<string>
    {
        // public virtual int DepartmentId { get; set; }
        public virtual string ChannelName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public Channel()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
