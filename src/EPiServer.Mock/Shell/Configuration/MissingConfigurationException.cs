using System;

namespace EPiServer.Shell.Configuration
{
    public class MissingConfigurationException: Exception
    {
        public MissingConfigurationException(string message) : base(message) { }
    }
}
