using System;

namespace fluentApps.Data.Core.Common
{
    public class RecordLog
    {
        private Guid recordId;
        private DateTime createTime;
        private DateTime updateTime;
        private DateTime? syncTime;
       
        public virtual Guid RecordId 
        { 
            get { return recordId; }
            set { recordId = value; }
        }
        
        public virtual int CreateUser { get; set; }
        public virtual string CreateHost { get; set; }

        public virtual DateTime CreateTime 
        {
            get { return createTime; }
            set { createTime = value; } 
        }

        public virtual int UpdateUser { get; set; }
        public virtual string UpdateHost { get; set; }
        
        public virtual DateTime UpdateTime 
        {
            get { return updateTime; }
            set { updateTime = value; } 
        }

        public virtual DateTime? SyncTime
        {
            get { return syncTime; }
            set { syncTime = value; }
        }

        public virtual int RecSystem { get; set; }
        public virtual int RecDelete { get; set; }
        public virtual int RecSelect { get; set; }
        public virtual int RecActive { get; set; }
        public virtual int RecState { get; set; }
        public virtual int RecSync { get; set; }

        public RecordLog()
        {
            recordId = Guid.NewGuid();
            createTime = DateTime.Now;
            updateTime = DateTime.Now;

            RecSystem = 0;
            RecDelete = 0;
            RecSelect = 0;
            RecActive = 1;
            RecState = 1;
            RecSync = 0;
        }
        
        public override string ToString()
        {
            return this.UpdateTime.ToShortDateString();
        }
    }
}
