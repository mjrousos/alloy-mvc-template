using System;
using System.Collections.Generic;

namespace EPiServer.Shell
{
    public class UIDescriptor
    {
        public UIDescriptor() { }
        public UIDescriptor(Type forType) { }
        protected UIDescriptor(Type forType, string iconClass) { }
        protected UIDescriptor(Type forType, string iconClass, IEnumerable<string> dndTypes) { }
        public string DefaultView { get; set; }
    }

    public class UIDescriptor<T> : UIDescriptor
    {
        protected UIDescriptor() { }
        protected UIDescriptor(string iconClass) { }

    }
}
