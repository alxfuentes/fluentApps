using fluentApps.Data.Core.Common;

namespace fluentApps.Data.Core.MasterData
{
    public class ProductBrand : DomainObject<string>
    {
        // public virtual int BrandId { get; set; }
        public virtual string BrandName { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public ProductBrand()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
