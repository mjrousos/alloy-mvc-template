using System;
using System.Collections.Generic;

namespace EPiServer.Framework
{
    public class ModuleDependencyAttribute: Attribute
    {
        public ICollection<Type> Dependencies { get; }

        public ModuleDependencyAttribute(Type dependency)
        {
            Dependencies = new Type[] { dependency };
        }
    }
}
