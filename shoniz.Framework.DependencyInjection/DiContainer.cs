using Castle.Windsor;
using shoniz.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;

namespace shoniz.Framework.DependencyInjection
{
    class DiContainer : IDiContainer
    {
        private readonly WindsorContainer container;

        public DiContainer(WindsorContainer container)
        {
            this.container = container;
        }

        public T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return container.ResolveAll<T>();
        }
    }
}
