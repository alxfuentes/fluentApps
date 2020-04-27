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

        public virtual recYesNo RecSystem { get; set; }
        public virtual recYesNo RecSelect { get; set; }
        public virtual recYesNo RecActive { get; set; }
        public virtual recState RecState { get; set; }
        public virtual recYesNo RecSync { get; set; }

        public RecordLog()
        {
            recordId = Guid.NewGuid();
            createTime = DateTime.Now;
            updateTime = createTime;

            RecSystem = recYesNo.No;
            RecSelect = recYesNo.No;
            RecActive = recYesNo.Yes;
            RecState = recState.New;
            RecSync = recYesNo.Yes;
        }

        public override string ToString()
        {
            return this.UpdateTime.ToShortDateString();
        }

    }

    public enum recYesNo
    {
        No,
        Yes
    }

    public enum recState
    {
        New,
        Updated,
        Deleted
    }
}
