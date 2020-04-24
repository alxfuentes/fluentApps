using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Common.Maps
{
    public class RecordLogMap: ComponentMap<RecordLog> 
    {
        public RecordLogMap()
        {
            Map(r => r.RecordId);
            Map(r => r.CreateUser);
            Map(r => r.CreateHost).Length(16);
            Map(r => r.CreateTime);
            Map(r => r.UpdateUser);
            Map(r => r.UpdateHost).Length(16);
            Map(r => r.UpdateTime);
            Map(r => r.SyncTime);
            Map(r => r.RecSystem);
            Map(r => r.RecDelete);
            Map(r => r.RecSelect);
            Map(r => r.RecActive);
            Map(r => r.RecState );
            Map(r => r.RecSync);
        }
    }
}
