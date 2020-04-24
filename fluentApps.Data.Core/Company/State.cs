using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.Company
{
    public class State : DomainObject<int>
    {
        // public virtual int StateId { get;set; }
        public virtual string StateName { get; set; }
        public virtual Country Country { get; set; }
        public virtual GeoLocation GeoPos { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public State()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
