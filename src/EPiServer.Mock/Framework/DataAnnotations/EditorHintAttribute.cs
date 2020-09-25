using System;

namespace EPiServer.Framework.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class EditorHintAttribute : Attribute
    {
        public EditorHintAttribute(string hint) { }

        public string Hint { get; }
    }
}
