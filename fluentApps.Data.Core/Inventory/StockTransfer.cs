using System;
using System.Collections.Generic;
using fluentApps.Data.Core.Common;
using fluentApps.Data.Core.MasterData;
using fluentApps.Data.Core.Transactions;

namespace fluentApps.Data.Core.Inventory
{
    public class StockTransfer : DomainObject<int>
    {
        public virtual EntityType Entity { get; set; }
        public virtual DocumentSeries Series { get; set; }
        public virtual int DocumentNumber { get; set; }
        public virtual string Reference { get; set; }
    
        public virtual DateTime DocumentDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime PostingDate { get; set; }
        public virtual int PostId { get; set; }

        public virtual Warehouse WarehouseFrom { get; set; }
        public virtual Warehouse WarehouseTo { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }

        public virtual string Comments { get; set; } 

        public virtual EntityType BaseType { get; set; }
        public virtual int BaseId { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public virtual List<StockTransferLine> Lines { get; set; }

        public StockTransfer()
        {
            this.RecordLog = new RecordLog();
            this.Lines = new List<StockTransferLine>();
        }
    }
}
