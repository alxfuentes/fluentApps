using System;

namespace fluentApps.Model.Core.Common
{
    public class RecordLog
    {
        private Guid recordId;
        private DateTime createTime;
        private DateTime updateTime;
        private DateTime? syncTime;
       
        public Guid RecordId 
        { 
            get { return recordId; }
            set { recordId = value; }
        }
        
        public int CreateUser { get; set; }
        public string CreateHost { get; set; }

        public DateTime CreateTime 
        {
            get { return createTime; }
            set { createTime = value; } 
        }

        public int UpdateUser { get; set; }
        public string UpdateHost { get; set; }
        
        public DateTime UpdateTime 
        {
            get { return updateTime; }
            set { updateTime = value; } 
        }

        public DateTime? SyncTime
        {
            get { return syncTime; }
            set { syncTime = value; }
        }

        public int RecSystem { get; set; }
        public int RecDelete { get; set; }
        public int RecSelect { get; set; }
        public int RecActive { get; set; }
        public int RecState { get; set; }
        public int RecSync { get; set; }

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
