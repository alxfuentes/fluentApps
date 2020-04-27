using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.MasterData
{
    public class PartnerGroup : DomainObject<int>
    {
        // public int PartnerGroupId {get;set;}
        public string GroupName { get; set; }
        public string Description { get; set; }
        public bpPartnerType GroupType { get; set; }

        public RecordLog RecordLog { get; set; }

        public PartnerGroup()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
