﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MartialBase.FakeData.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Internet {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Internet() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MartialBase.FakeData.Resources.Internet", typeof(Internet).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to co.uk;com;us;uk;ca;biz;info;name.
        /// </summary>
        internal static string DomainSuffix {
            get {
                return ResourceManager.GetString("DomainSuffix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to gmail.com;yahoo.com;hotmail.com.
        /// </summary>
        internal static string FreeMail {
            get {
                return ResourceManager.GetString("FreeMail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to index;page;root;resource;form;applet;template.
        /// </summary>
        internal static string Page {
            get {
                return ResourceManager.GetString("Page", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to html;htm;asp;aspx;gem;lsp;jsp;res;rsx.
        /// </summary>
        internal static string PageSuffix {
            get {
                return ResourceManager.GetString("PageSuffix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to home;interviews;articles;facts;shop;catalog;reviews;shop/books;shop/food;shop/films;films;guide.
        /// </summary>
        internal static string SubDomain {
            get {
                return ResourceManager.GetString("SubDomain", resourceCulture);
            }
        }
    }
}
