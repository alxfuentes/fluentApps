using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Transactions.Maps
{
    public class EntityTypeMap : ClassMap<EntityType>
    {
        public EntityTypeMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Identity().Column("EntityTypeId");
            Map(m => m.EntityName);
            Map(m => m.Description);
            References(m => m.AppCatalog);

            Component(m => m.RecordLog);
        }
    }
}
