using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class PartnerSegment : DomainObject<int>
    {
        // public virtual int SegmentId {get;set;}
        public virtual string SegmentName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public PartnerSegment()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
