using System;
using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.MasterData;
using fluentApps.Data.Core.Transactions;

namespace fluentApps.Data.Core.Inventory
{
    public class StockTransferLine : DomainObject<int>
    {
        public virtual StockTransfer Object { get; set; }
        public virtual int LineNumber { get; set; }
        public virtual Product Product { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Quantity { get; set; }
        public virtual decimal Price { get; set;  }
        public virtual decimal PriceWithVAT { get; set; }
        public virtual decimal DiscountSum { get; set; }
        public virtual decimal DiscountPercent { get; set; }
        public virtual decimal LineAmount { get; set; }
        public virtual decimal GrossTotal { get; set; }
        public virtual decimal StockCost { get; set; }
        public virtual decimal StockTotal { get; set; }
        public virtual Warehouse WarehouseFrom { get; set; }
        public virtual Warehouse WarehouseTo { get; set; }
        public virtual string LineComments { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public StockTransferLine()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
