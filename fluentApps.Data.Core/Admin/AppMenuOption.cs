using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Admin
{
    public class AppMenuOption : DomainObject<int>
    {
        //public virtual int OptionId { get; set; }
        public virtual AppCatalog App { get; set; }
        public virtual int ParentId { get; set; }
        public virtual string OptionName { get; set; }
        public virtual string Description { get; set; }
        public virtual string Assembly { get; set; }
        public virtual string OptionPath { get; set; }
        public virtual string WebView { get; set; }
        public virtual string Param1 { get; set; }
        public virtual string Param2 { get; set; }
        public virtual string Param3 { get; set; }
        public virtual string OpenMode { get; set; }
        public virtual string IconName { get; set; }
        public virtual int DesktopIcon { get; set; }
        public virtual RecordLog RecordLog { get; set; }

        public AppMenuOption()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
