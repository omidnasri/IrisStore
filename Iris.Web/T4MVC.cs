﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly AdminPanelClass s_AdminPanel = new AdminPanelClass();
    public static AdminPanelClass AdminPanel { get { return s_AdminPanel; } }
    static readonly PageClass s_Page = new PageClass();
    public static PageClass Page { get { return s_Page; } }
    static readonly PostClass s_Post = new PostClass();
    public static PostClass Post { get { return s_Post; } }
    static readonly PostCategoryClass s_PostCategory = new PostCategoryClass();
    public static PostCategoryClass PostCategory { get { return s_PostCategory; } }
    static readonly ProductClass s_Product = new ProductClass();
    public static ProductClass Product { get { return s_Product; } }
    static readonly ProductCategoryClass s_ProductCategory = new ProductCategoryClass();
    public static ProductCategoryClass ProductCategory { get { return s_ProductCategory; } }
    static readonly SiteSettingClass s_SiteSetting = new SiteSettingClass();
    public static SiteSettingClass SiteSetting { get { return s_SiteSetting; } }
    static readonly SlideShowClass s_SlideShow = new SlideShowClass();
    public static SlideShowClass SlideShow { get { return s_SlideShow; } }
    static readonly UserClass s_User = new UserClass();
    public static UserClass User { get { return s_User; } }
    public static Iris.Web.Controllers.AccountController Account = new Iris.Web.Controllers.T4MVC_AccountController();
    public static Iris.Web.Controllers.HomeController Home = new Iris.Web.Controllers.T4MVC_HomeController();
    public static Iris.Web.Controllers.SearchController Search = new Iris.Web.Controllers.T4MVC_SearchController();
    public static Iris.Web.Controllers.SiteMapController SiteMap = new Iris.Web.Controllers.T4MVC_SiteMapController();
    public static Iris.Web.Controllers.TestController Test = new Iris.Web.Controllers.T4MVC_TestController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
    public static T4MVC.WidgetsController Widgets = new T4MVC.WidgetsController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class AdminPanelClass
    {
        public readonly string Name = "AdminPanel";
        public Iris.Web.Areas.AdminPanel.Controllers.DashboardController Dashboard = new Iris.Web.Areas.AdminPanel.Controllers.T4MVC_DashboardController();
        public T4MVC.AdminPanel.SharedController Shared = new T4MVC.AdminPanel.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class PageClass
    {
        public readonly string Name = "Page";
        public Iris.Web.Areas.Page.Controllers.AdminController Admin = new Iris.Web.Areas.Page.Controllers.T4MVC_AdminController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class PostClass
    {
        public readonly string Name = "Post";
        public Iris.Web.Areas.Post.Controllers.AdminController Admin = new Iris.Web.Areas.Post.Controllers.T4MVC_AdminController();
        public Iris.Web.Areas.Post.Controllers.HomeController Home = new Iris.Web.Areas.Post.Controllers.T4MVC_HomeController();
        public T4MVC.Post.SharedController Shared = new T4MVC.Post.SharedController();
        public T4MVC.Post.WidgetsController Widgets = new T4MVC.Post.WidgetsController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class PostCategoryClass
    {
        public readonly string Name = "PostCategory";
        public Iris.Web.Areas.PostCategory.Controllers.AdminController Admin = new Iris.Web.Areas.PostCategory.Controllers.T4MVC_AdminController();
        public T4MVC.PostCategory.SharedController Shared = new T4MVC.PostCategory.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class ProductClass
    {
        public readonly string Name = "Product";
        public Iris.Web.Areas.Product.Controllers.AdminController Admin = new Iris.Web.Areas.Product.Controllers.T4MVC_AdminController();
        public Iris.Web.Areas.Product.Controllers.HomeController Home = new Iris.Web.Areas.Product.Controllers.T4MVC_HomeController();
        public Iris.Web.Areas.Product.Controllers.SearchProductController SearchProduct = new Iris.Web.Areas.Product.Controllers.T4MVC_SearchProductController();
        public Iris.Web.Areas.Product.Controllers.UploadController Upload = new Iris.Web.Areas.Product.Controllers.T4MVC_UploadController();
        public T4MVC.Product.SharedController Shared = new T4MVC.Product.SharedController();
        public T4MVC.Product.WidgetController Widget = new T4MVC.Product.WidgetController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class ProductCategoryClass
    {
        public readonly string Name = "ProductCategory";
        public Iris.Web.Areas.ProductCategory.Controllers.AdminController Admin = new Iris.Web.Areas.ProductCategory.Controllers.T4MVC_AdminController();
        public T4MVC.ProductCategory.SharedController Shared = new T4MVC.ProductCategory.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class SiteSettingClass
    {
        public readonly string Name = "SiteSetting";
        public Iris.Web.Areas.SiteSetting.Controllers.AdminController Admin = new Iris.Web.Areas.SiteSetting.Controllers.T4MVC_AdminController();
        public T4MVC.SiteSetting.SharedController Shared = new T4MVC.SiteSetting.SharedController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class SlideShowClass
    {
        public readonly string Name = "SlideShow";
        public Iris.Web.Areas.SlideShow.Controllers.AdminController Admin = new Iris.Web.Areas.SlideShow.Controllers.T4MVC_AdminController();
        public T4MVC.SlideShow.SharedController Shared = new T4MVC.SlideShow.SharedController();
        public T4MVC.SlideShow.WidgetController Widget = new T4MVC.SlideShow.WidgetController();
    }
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class UserClass
    {
        public readonly string Name = "User";
        public Iris.Web.Areas.User.Controllers.AdminController Admin = new Iris.Web.Areas.User.Controllers.T4MVC_AdminController();
        public T4MVC.User.SharedController Shared = new T4MVC.User.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


