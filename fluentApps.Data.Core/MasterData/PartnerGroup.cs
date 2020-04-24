using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class PartnerGroup : DomainObject<int>
    {
        // public virtual int PartnerGroupId {get;set;}
        public virtual string GroupName { get; set; }
        public virtual string Description { get; set; }
        public virtual bpPartnerType GroupType { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public PartnerGroup()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
