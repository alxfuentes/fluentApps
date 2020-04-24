using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Company.Maps
{
    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Assigned().Column("DepartmentId");
            Map(m => m.DepartmentName).Length(50);
            Map(m => m.Description).Length(250);
            Component(m => m.RecordLog);
        }
    }
}
