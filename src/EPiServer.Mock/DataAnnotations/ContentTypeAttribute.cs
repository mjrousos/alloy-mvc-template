﻿using System;

namespace EPiServer.DataAnnotations
{
    public class ContentTypeAttribute : Attribute
    {
        public string GroupName { get; set; }
    }
}
