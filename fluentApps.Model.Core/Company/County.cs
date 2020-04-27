using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class County : DomainObject<int>
    {
        
        // public int CountyId { get; set; }
        public string CountyName { get; set; }
        public State State { get; set; }

        public GeoLocation GeoPos { get; set; }

        public RecordLog RecordLog { get; set; }

        public County()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
