using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class ProductCategory : DomainObject<string>
    {
        // public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public ProductCategory()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
