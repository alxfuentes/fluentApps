using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class BranchMap : ClassMap<Branch>
    {
        public BranchMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("BranchId");
            Map(m => m.BranchName).Length(50);
            Map(m => m.Description).Length(250);
            References(m => m.Manager, "ManagerId" );

            Component(m => m.Address);

            Component(m => m.RecordLog);
        }
    }
}
