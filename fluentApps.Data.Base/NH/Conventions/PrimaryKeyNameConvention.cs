using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace fluentApps.Data.Base.NH.Conventions
{
    public class PrimaryKeyNameConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.Column(instance.EntityType.Name + "Id");
        }
    }
}
