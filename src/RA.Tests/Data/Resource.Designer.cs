﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestAssured.Tests.Data {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RestAssured.Tests.Data.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///  &quot;id&quot;: &quot;http://jsonschema.net&quot;,
        ///  &quot;type&quot;: &quot;array&quot;,
        ///  &quot;items&quot;: [
        ///    {
        ///      &quot;id&quot;: &quot;http://jsonschema.net/0&quot;,
        ///      &quot;type&quot;: &quot;object&quot;,
        ///      &quot;properties&quot;: {
        ///        &quot;profileId&quot;: {
        ///          &quot;id&quot;: &quot;http://jsonschema.net/0/profileId&quot;,
        ///          &quot;type&quot;: &quot;string&quot;
        ///        },
        ///        &quot;profileCategoryCodes&quot;: {
        ///          &quot;id&quot;: &quot;http://jsonschema.net/0/profileCategoryCodes&quot;,
        ///          &quot;type&quot;: &quot;array&quot;,
        ///          &quot;items&quot;: {
        ///            &quot;id&quot;: &quot;ht [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConversationSchema {
            get {
                return ResourceManager.GetString("ConversationSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;$schema&quot;: &quot;http://json-schema.org/draft-03/schema#&quot;,
        ///	&quot;type&quot;: &quot;object&quot;,
        ///	&quot;properties&quot;: {
        ///		&quot;id&quot; : {
        ///			//typo here on purpose to create bad schema
        ///			&quot;type&quot;: &quot;bleh&quot;,
        ///			&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$&quot;,
        ///			&quot;required&quot;: true,
        ///			&quot;minLength&quot;: 1
        ///		},
        ///		&quot;products&quot;: {
        ///			&quot;type&quot;: &quot;array&quot;,
        ///			&quot;items&quot;:{
        ///				&quot;type&quot;: &quot;object&quot;,
        ///				&quot;properties&quot;: {
        ///					&quot;id&quot;:{
        ///						&quot;type&quot;: &quot;string&quot;,
        ///						&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string V3InvalidSchema {
            get {
                return ResourceManager.GetString("V3InvalidSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;$schema&quot;: &quot;http://json-schema.org/draft-03/schema#&quot;,
        ///	&quot;type&quot;: &quot;object&quot;,
        ///	&quot;properties&quot;: {
        ///		&quot;id&quot; : {
        ///			&quot;type&quot;: &quot;string&quot;,
        ///			&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$&quot;,
        ///			&quot;required&quot;: true,
        ///			&quot;minLength&quot;: 1
        ///		},
        ///		&quot;products&quot;: {
        ///			&quot;type&quot;: &quot;array&quot;,
        ///			&quot;items&quot;:{
        ///				&quot;type&quot;: &quot;object&quot;,
        ///				&quot;properties&quot;: {
        ///					&quot;id&quot;:{
        ///						&quot;type&quot;: &quot;string&quot;,
        ///						&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$&quot;,
        ///					 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string V3RestrictiveSchema {
            get {
                return ResourceManager.GetString("V3RestrictiveSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;$schema&quot;: &quot;http://json-schema.org/draft-03/schema#&quot;,
        ///	&quot;type&quot;: &quot;object&quot;,
        ///	&quot;properties&quot;: {
        ///		&quot;id&quot; : {
        ///			&quot;type&quot;: &quot;string&quot;,
        ///			&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$&quot;,
        ///			&quot;required&quot;: true,
        ///			&quot;minLength&quot;: 1
        ///		},
        ///		&quot;products&quot;: {
        ///			&quot;type&quot;: &quot;array&quot;,
        ///			&quot;items&quot;:{
        ///				&quot;type&quot;: &quot;object&quot;,
        ///				&quot;properties&quot;: {
        ///					&quot;id&quot;:{
        ///						&quot;type&quot;: &quot;string&quot;,
        ///						&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$&quot;,
        ///					 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string V3ValidSchema {
            get {
                return ResourceManager.GetString("V3ValidSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;$schema&quot;: &quot;http://json-schema.org/draft-04/schema#&quot;,
        ///	&quot;type&quot;: &quot;object&quot;,
        ///	&quot;properties&quot;: {
        ///		&quot;id&quot; : {
        ///			&quot;type&quot;: &quot;string&quot;,
        ///			&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$&quot;,
        ///			&quot;minLength&quot;: 1
        ///		},
        ///		&quot;products&quot;: {
        ///			&quot;type&quot;: &quot;array&quot;,
        ///			&quot;items&quot;:{
        ///				&quot;type&quot;: &quot;object&quot;,
        ///				&quot;properties&quot;: {
        ///					&quot;id&quot;:{
        ///						&quot;type&quot;: &quot;string&quot;,
        ///						&quot;pattern&quot;: &quot;^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$&quot;,
        ///						&quot;minLength&quot;: 1
        ///					 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string V4ValidSchema {
            get {
                return ResourceManager.GetString("V4ValidSchema", resourceCulture);
            }
        }
    }
}
