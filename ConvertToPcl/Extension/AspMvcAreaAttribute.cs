using System;

namespace MLabs.ConvertToPcl.Annotations
{
    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC araa.
    /// Use this attribute for custom wrappers similar to 
    /// <see cref="System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String)"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AspMvcAreaAttribute : PathReferenceAttribute
    {
        [UsedImplicitly] public string AnonymousProperty { get; private set; }

        [UsedImplicitly] public AspMvcAreaAttribute() { }

        public AspMvcAreaAttribute(string anonymousProperty)
        {
            AnonymousProperty = anonymousProperty;
        }
    }
}