namespace fluentApps.Data.Core.Common
{
    public class ObjectValue : DomainObject<int>
    {
        // public virtual int ValueId { get; set; }
        public virtual string EntityId { get; set; }
        public virtual string PropertyId { get; set; } 
        public virtual string Value { get; set; }
        public virtual string Description { get; set; }

        public virtual RecordLog RecordLog { get; set; }

        public ObjectValue()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
