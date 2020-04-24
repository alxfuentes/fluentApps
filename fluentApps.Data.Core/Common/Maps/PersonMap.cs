using FluentNHibernate.Mapping;

namespace fluentApps.Data.Core.Common.Maps
{
    public class PersonMap : ComponentMap<Person>
    {
        public PersonMap()
        {
            Map(p => p.FullName      ).Length(200);
            Map(p => p.FirstName     ).Length(50);
            Map(p => p.MiddleName    ).Length(50);
            Map(p => p.LastName      ).Length(50);
            Map(p => p.MaidenName    ).Length(50);
            Component(p => p.PersonAddress ).ColumnPrefix("Home");
            Map(p => p.WorkPhone     ).Length(30);
            Map(p => p.ExtPhone      ).Length(20);
            Map(p => p.HomePhone     ).Length(30);
            Map(p => p.MobilePhone   ).Length(30);
            Map(p => p.FaxPhone      ).Length(30);
            Map(p => p.WorkEMail     ).Length(60);
            Map(p => p.PersonalEMail ).Length(60);
            Map(p => p.Gender        ).Length(1);
            Map(p => p.BirthDate     );
            Map(p => p.BirthPlace    ).Length(60);
            Map(p => p.Nationality   ).Length(60);
            Map(p => p.IdNumber      ).Length(40);
            Map(p => p.Passport      ).Length(40);
        }
    }
}
