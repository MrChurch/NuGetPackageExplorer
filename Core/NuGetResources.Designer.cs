﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Resources {
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
    internal class NuGetResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NuGetResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.NuGetResources", typeof(NuGetResources).Assembly);
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
        ///   Looks up a localized string similar to Cannot create a package that has no dependencies nor content..
        /// </summary>
        internal static string CannotCreateEmptyPackage {
            get {
                return ResourceManager.GetString("CannotCreateEmptyPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependency &apos;{0}&apos; has an invalid version..
        /// </summary>
        internal static string DependencyHasInvalidVersion {
            get {
                return ResourceManager.GetString("DependencyHasInvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; already has a dependency defined for &apos;{1}&apos;..
        /// </summary>
        internal static string DuplicateDependenciesDefined {
            get {
                return ResourceManager.GetString("DuplicateDependenciesDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading &apos;{0}&apos;..
        /// </summary>
        internal static string ErrorReadingFile {
            get {
                return ResourceManager.GetString("ErrorReadingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema version of &apos;{0}&apos; is incompatible with version {1} of NuGet Package Explorer. Please upgrade NuGet Package Explorer to the latest version..
        /// </summary>
        internal static string IncompatibleSchema {
            get {
                return ResourceManager.GetString("IncompatibleSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error while processing the request. Please verify that &apos;{0}&apos; is a valid feed..
        /// </summary>
        internal static string InvalidFeed {
            get {
                return ResourceManager.GetString("InvalidFeed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid framework name format. Expected {framework}{version}-{profile}..
        /// </summary>
        internal static string InvalidFrameworkNameFormat {
            get {
                return ResourceManager.GetString("InvalidFrameworkNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package ID &apos;{0}&apos; contains invalid characters. Examples of valid package IDs include &apos;MyPackage&apos; and &apos;MyPackage.Sample&apos;..
        /// </summary>
        internal static string InvalidPackageId {
            get {
                return ResourceManager.GetString("InvalidPackageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid version string..
        /// </summary>
        internal static string InvalidVersionString {
            get {
                return ResourceManager.GetString("InvalidVersionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependency Id is required..
        /// </summary>
        internal static string Manifest_DependencyIdRequired {
            get {
                return ResourceManager.GetString("Manifest_DependencyIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exclude path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_ExcludeContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_ExcludeContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package Id cannot exceed 100 characters..
        /// </summary>
        internal static string Manifest_IdMaxLengthExceeded {
            get {
                return ResourceManager.GetString("Manifest_IdMaxLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A stable release of a package should not have dependency on a prerelease package. Either modify the version spec of dependency &quot;{0}&quot; or update the version field..
        /// </summary>
        internal static string Manifest_InvalidPrereleaseDependency {
            get {
                return ResourceManager.GetString("Manifest_InvalidPrereleaseDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid assembly reference &apos;{0}&apos;. Ensure that a file named &apos;{0}&apos; exists in the lib directory..
        /// </summary>
        internal static string Manifest_InvalidReference {
            get {
                return ResourceManager.GetString("Manifest_InvalidReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid schema namespace &apos;{0}&apos;..
        /// </summary>
        internal static string Manifest_InvalidSchemaNamespace {
            get {
                return ResourceManager.GetString("Manifest_InvalidSchemaNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No namespace was found corresponding to the schema version &apos;{0}&apos;. Add an entry to the VersionToSchemaMappings dictionary in &apos;{1}&apos;..
        /// </summary>
        internal static string Manifest_InvalidVersion {
            get {
                return ResourceManager.GetString("Manifest_InvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is required..
        /// </summary>
        internal static string Manifest_RequiredMetadataMissing {
            get {
                return ResourceManager.GetString("Manifest_RequiredMetadataMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling license acceptance requires a license url..
        /// </summary>
        internal static string Manifest_RequireLicenseAcceptanceRequiresLicenseUrl {
            get {
                return ResourceManager.GetString("Manifest_RequireLicenseAcceptanceRequiresLicenseUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_SourceContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_SourceContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_TargetContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_TargetContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be empty..
        /// </summary>
        internal static string Manifest_UriCannotBeEmpty {
            get {
                return ResourceManager.GetString("Manifest_UriCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Framework name is missing..
        /// </summary>
        internal static string MissingFrameworkName {
            get {
                return ResourceManager.GetString("MissingFrameworkName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found: &apos;{0}&apos;..
        /// </summary>
        internal static string PackageAuthoring_FileNotFound {
            get {
                return ResourceManager.GetString("PackageAuthoring_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to download package correctly. The contents of the package could not be verified..
        /// </summary>
        internal static string PackageContentsVerifyError {
            get {
                return ResourceManager.GetString("PackageContentsVerifyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package does not contain a manifest..
        /// </summary>
        internal static string PackageDoesNotContainManifest {
            get {
                return ResourceManager.GetString("PackageDoesNotContainManifest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to process request. &apos;{0}&apos;. 
        ///{1}.
        /// </summary>
        internal static string PackageServerError {
            get {
                return ResourceManager.GetString("PackageServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection to feed &apos;{0}&apos; requires the Windows Identity Foundation runtime to be installed..
        /// </summary>
        internal static string UnableToLocateWIF {
            get {
                return ResourceManager.GetString("UnableToLocateWIF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToResolveUri {
            get {
                return ResourceManager.GetString("UnableToResolveUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string UserSettings_KeyDoesNotExist {
            get {
                return ResourceManager.GetString("UserSettings_KeyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Section&apos;{0}&apos; does not exist..
        /// </summary>
        internal static string UserSettings_SectionDoesNotExist {
            get {
                return ResourceManager.GetString("UserSettings_SectionDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse config file..
        /// </summary>
        internal static string UserSettings_UnableToParseConfigFile {
            get {
                return ResourceManager.GetString("UserSettings_UnableToParseConfigFile", resourceCulture);
            }
        }
    }
}
