using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EPiServer.DataAbstraction
{
    public sealed class AllowedTypesAttribute : ValidationAttribute, IMetadataAware
    {
        public AllowedTypesAttribute() { }

        public AllowedTypesAttribute(params Type[] allowedTypes) { }

        public AllowedTypesAttribute(Type[] allowedTypes, Type[] restrictedTypes) { }

        public AllowedTypesAttribute(Type[] allowedTypes, Type[] restrictedTypes, string typesFormatSuffix) { }

        public void OnMetadataCreated(ModelMetadata metadata) { }
    }
}
