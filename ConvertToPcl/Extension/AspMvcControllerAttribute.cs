using System;

namespace MLabs.ConvertToPcl.Annotations
{
    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter is an MVC controller.
    /// If applied to a method, the MVC controller name is calculated implicitly from the context.
    /// Use this attribute for custom wrappers similar to 
    /// <see cref="System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String, String)"/> 
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
    public sealed class AspMvcControllerAttribute : Attribute
    {
        [UsedImplicitly] public string AnonymousProperty { get; private set; }

        public AspMvcControllerAttribute() { }

        public AspMvcControllerAttribute(string anonymousProperty)
        {
            AnonymousProperty = anonymousProperty;
        }
    }
}