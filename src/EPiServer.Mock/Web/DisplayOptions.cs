using EPiServer.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EPiServer.Web
{
    public class DisplayOptions : IEnumerable<DisplayOption>, IEnumerable, IInitializableModule
    {
        public IEnumerator<DisplayOption> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public virtual DisplayOptions Add(DisplayOption displayOption) => default;
        public virtual DisplayOptions Add(string id, string name, string tag) => default;
        public virtual DisplayOptions Add(string id, string name, string tag, string description) => default;
        public virtual DisplayOptions Add(string id, string name, string tag, string description, string iconClass) => default;
    }
}
