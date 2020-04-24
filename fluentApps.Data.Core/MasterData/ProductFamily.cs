using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class ProductFamily : DomainObject<string>
    {
        // public virtual int FamilyId { get; set; }
        public virtual string FamilyName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public ProductFamily()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
