// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Used for getting ResourceHealthCheck settings.</summary>
    public partial class ResourceHealthMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResource __proxyOnlyResource = new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ProxyOnlyResource();

        /// <summary>The category that the resource matches in the RHC Policy File</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string Category { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataPropertiesInternal)Property).Category; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataPropertiesInternal)Property).Category = value ?? null; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataProperties Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ResourceHealthMetadataProperties()); set { {_property = value;} } }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataProperties _property;

        /// <summary>ResourceHealthMetadata resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ResourceHealthMetadataProperties()); set => this._property = value; }

        /// <summary>Is there a health signal for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? SignalAvailability { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataPropertiesInternal)Property).SignalAvailability; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataPropertiesInternal)Property).SignalAvailability = value ?? default(bool); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; }

        /// <summary>Creates an new <see cref="ResourceHealthMetadata" /> instance.</summary>
        public ResourceHealthMetadata()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyOnlyResource), __proxyOnlyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyOnlyResource), __proxyOnlyResource);
        }
    }
    /// Used for getting ResourceHealthCheck settings.
    public partial interface IResourceHealthMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResource
    {
        /// <summary>The category that the resource matches in the RHC Policy File</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The category that the resource matches in the RHC Policy File",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>Is there a health signal for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is there a health signal for the resource",
        SerializedName = @"signalAvailability",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SignalAvailability { get; set; }

    }
    /// Used for getting ResourceHealthCheck settings.
    internal partial interface IResourceHealthMetadataInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IProxyOnlyResourceInternal
    {
        /// <summary>The category that the resource matches in the RHC Policy File</summary>
        string Category { get; set; }
        /// <summary>ResourceHealthMetadata resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceHealthMetadataProperties Property { get; set; }
        /// <summary>Is there a health signal for the resource</summary>
        bool? SignalAvailability { get; set; }

    }
}