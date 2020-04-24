using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.HumanCapital.Maps
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(m => m.ObjectId).GeneratedBy.Identity().Column("EmployeeId");
            Map(m => m.AlternateCode).Length(20);
            Component(m => m.PersonalData);
            Component(m => m.Work).ColumnPrefix("Work");
            Map(m => m.WorkEMail).Length(100);
            Map(m => m.WorkPhone).Length(32);
            References(m => m.Department);
            References(m => m.Branch);
            References(m => m.Location);

            Map(m => m.Position).Length(20);
            Map(m => m.Job).Length(20);

            References(m => m.Manager, "ManagerId");

            Map(m => m.HireDate);
            Map(m => m.EndDate);

            Map(m => m.ContractNumber);
            Map(m => m.ContractStartDate);
            Map(m => m.ContractEndDate);

            Map(m => m.Salary);
            Map(m => m.Bonifications);
            Map(m => m.Costs);

            References(m => m.Bank).Column("BankId");
            Map(m => m.BankAccount).Length(20);

            Map(m => m.Notes).CustomType("StringClob").CustomSqlType("nvarchar(max)");

            Component(m => m.RecordLog);
        }
    }
}
