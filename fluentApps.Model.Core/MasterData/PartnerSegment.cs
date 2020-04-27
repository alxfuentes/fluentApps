using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.MasterData
{
    public class PartnerSegment : DomainObject<int>
    {
        // public int SegmentId {get;set;}
        public string SegmentName { get; set; }
        public string Description { get; set; }

        public RecordLog RecordLog { get; set; }

        public PartnerSegment()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
