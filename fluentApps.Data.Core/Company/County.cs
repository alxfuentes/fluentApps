using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class County : DomainObject<int>
    {
        
        // public virtual int CountyId { get; set; }
        public virtual string CountyName { get; set; }
        public virtual State State { get; set; }

        public virtual GeoLocation GeoPos { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public County()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
