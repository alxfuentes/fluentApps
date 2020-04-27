namespace fluentApps.Model.Core.Common
{
    public class ObjectValue : DomainObject<int>
    {
        // public int ValueId { get; set; }
        public string EntityId { get; set; }
        public string PropertyId { get; set; } 
        public string Value { get; set; }
        public string Description { get; set; }

        public RecordLog RecordLog { get; set; }

        public ObjectValue()
        {
            this.RecordLog = new RecordLog();
        }
    }
}
