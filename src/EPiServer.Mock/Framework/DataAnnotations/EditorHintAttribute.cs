using System;
using System.Runtime.InteropServices;

namespace EPiServer.Framework.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class EditorHintAttribute : Attribute, _Attribute
    {
        public EditorHintAttribute(string hint) { }

        public string Hint { get; }
    }
}
