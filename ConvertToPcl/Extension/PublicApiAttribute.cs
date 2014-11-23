using System;

namespace MLabs.ConvertToPcl.Annotations
{
    /// <summary>
    /// This attribute is intended to mark publicly available API which should not be removed and so is treated as used.
    /// </summary>
    [MeansImplicitUse]
    public sealed class PublicApiAttribute : Attribute
    {
        public PublicApiAttribute() { }
        public PublicApiAttribute(string comment) { }
    }
}