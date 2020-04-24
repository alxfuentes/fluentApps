using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace fluentApps.Data.Base.NH.Conventions
{
    public class ReferenceConvention : IReferenceConvention
    {
        public void Apply(IManyToOneInstance instance)
        {
            instance.Column(instance.Property.PropertyType.Name + "Id");
        }
    }
}
