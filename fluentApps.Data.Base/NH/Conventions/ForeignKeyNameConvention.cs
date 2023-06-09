﻿using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace fluentApps.Data.Base.NH.Conventions
{
    public class ForeignKeyNameConvention : IHasManyConvention
    {
        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Key.Column(instance.EntityType.Name + "Id");
        }
    }
}
