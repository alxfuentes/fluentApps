﻿using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace fluentApps.Data.Base.NH.Conventions
{
    public class StringColumnLengthConvention
    : IPropertyConvention, IPropertyConventionAcceptance
    {
        public void Accept(IAcceptanceCriteria<IPropertyInspector> criteria)
        {
            criteria.Expect(x => x.Type == typeof(string))
                .Expect(x => x.Length == 0);
        }

        public void Apply(IPropertyInstance instance)
        {
            instance.Length(100);
        }
    }
}
