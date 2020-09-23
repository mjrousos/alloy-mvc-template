using System;

namespace EPiServer.DataAnnotations
{
    public class ImageUrlAttribute : Attribute
    {
        public string Path { get; set; }

        public ImageUrlAttribute(string path)
        {
            Path = path;
        }
    }
}
