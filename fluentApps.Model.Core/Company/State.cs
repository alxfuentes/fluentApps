using fluentApps.Model.Core.Common;

namespace fluentApps.Model.Core.Company
{
    public class State : DomainObject<int>
    {
        // public int StateId { get;set; }
        public string StateName { get; set; }
        public Country Country { get; set; }
        public GeoLocation GeoPos { get; set; }

        public RecordLog RecordLog { get; set; }

        public State()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
