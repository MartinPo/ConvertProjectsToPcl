/*
 * Copyright 2007-2012 JetBrains s.r.o.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.ComponentModel;

namespace MLabs.ConvertToPcl.Annotations
{
    /// <summary>
  /// Indicates that the function argument should be string literal and match one of the parameters
  /// of the caller function.
  /// For example, ReSharper annotates the parameter of <see cref="System.ArgumentNullException"/>.
  /// </summary>
  /// <example>
  /// <code>
  /// public void Foo(string param)
  /// {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code>
  /// </example>
  [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
  public sealed class InvokerParameterNameAttribute : Attribute { }

    /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes, 
  /// so the check for <c>null</c> is necessary before its usage.
  /// </summary>
  /// <example>
  /// <code>
  /// [CanBeNull]
  /// public object Test()
  /// {
  ///   return null;
  /// }
  /// 
  /// public void UseTest()
  /// {
  ///   var p = Test(); 
  ///   var s = p.ToString(); // Warning: Possible 'System.NullReferenceException' 
  /// }
  /// </code>
  /// </example>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Delegate | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public sealed class CanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the value of the marked element could never be <c>null</c>
  /// </summary>
  /// <example>
  /// <code>
  /// [NotNull]
  /// public object Foo()
  /// {
  ///   return null; // Warning: Possible 'null' assignment
  /// } 
  /// </code>
  /// </example>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Delegate | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public sealed class NotNullAttribute : Attribute { }

    /// <summary>
  /// Tells code analysis engine if the parameter is completely handled when the invoked method is on stack. 
  /// If the parameter is a delegate, indicates that delegate is executed while the method is executed.
  /// If the parameter is an enumerable, indicates that it is enumerated while the method is executed.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter, Inherited = true)]
  public sealed class InstantHandleAttribute : Attribute { }


    // ASP.NET MVC attributes

    /// <summary>
  /// ASP.NET MVC attribute. Indicates that a parameter is an MVC Master.
  /// Use this attribute for custom wrappers similar to 
  /// <see cref="System.Web.Mvc.Controller.View(String, String)"/>
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMvcMasterAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. Indicates that a parameter is an MVC model type.
  /// Use this attribute for custom wrappers similar to 
  /// <see cref="System.Web.Mvc.Controller.View(String, Object)"/>
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMvcModelTypeAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter is an MVC partial view.
  /// If applied to a method, the MVC partial view name is calculated implicitly from the context.
  /// Use this attribute for custom wrappers similar to 
  /// <see cref="System.Web.Mvc.Html.RenderPartialExtensions.RenderPartial(HtmlHelper, String)"/>
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class AspMvcPartialViewAttribute : PathReferenceAttribute { }

  /// <summary>
  /// ASP.NET MVC attribute. Allows disabling all inspections for MVC views within a class or a method.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
  public sealed class AspMvcSupressViewErrorAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. Indicates that a parameter is an MVC display template.
  /// Use this attribute for custom wrappers similar to 
  /// <see cref="System.Web.Mvc.Html.DisplayExtensions.DisplayForModel(HtmlHelper, String)"/>
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMvcDisplayTemplateAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. Indicates that a parameter is an MVC editor template.
  /// Use this attribute for custom wrappers similar to 
  /// <see cref="System.Web.Mvc.Html.EditorExtensions.EditorForModel(HtmlHelper, String)"/>
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMvcEditorTemplateAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter is an MVC view.
  /// If applied to a method, the MVC view name is calculated implicitly from the context.
  /// Use this attribute for custom wrappers similar to 
  /// <see cref="System.Web.Mvc.Controller.View(Object)"/>
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class AspMvcViewAttribute : PathReferenceAttribute { }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example>
  /// <code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl)
  /// {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code>
  /// </example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute { }

  // Razor attributes

  /// <summary>
  /// Razor attribute. Indicates that a parameter or a method is a Razor section.
  /// Use this attribute for custom wrappers similar to 
  /// <see cref="System.Web.WebPages.WebPageBase.RenderSection(String)"/>
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method, Inherited = true)]
  public sealed class RazorSectionAttribute : Attribute { }

}