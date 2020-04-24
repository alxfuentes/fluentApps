using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class ProductArea : DomainObject<string>
    {
        // public virtual int AreaId { get; set; }
        public virtual string AreaName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public ProductArea()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
