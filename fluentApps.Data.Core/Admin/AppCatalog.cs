using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Admin
{
    public class AppCatalog : DomainObject<string>
    {
        //public virtual string AppId { get; set; }

        public virtual string AppName { get; set; }
        public virtual string Description { get; set; }
        public virtual string IconName { get; set; }
        public virtual int MenuOrder { get; set; }
        public virtual RecordLog RecordLog { get; set; }

        public AppCatalog()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
