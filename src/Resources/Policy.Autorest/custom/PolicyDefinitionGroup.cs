// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.PowerShell;
    using System;
    using System.Linq;

    /// <summary>The policy definition group.</summary>
    public partial class PolicyDefinitionGroup
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content)
        {
        }

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content)
        {
        }

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow)
        {
            // get properties from hashtable in case-insensitive way
            var keyValuePair = content.Cast<System.Collections.DictionaryEntry>().FirstOrDefault((kvp) => "Name".Equals(kvp.Key.ToString(), StringComparison.OrdinalIgnoreCase));
            if (keyValuePair.Key != null)
            {
                ((IPolicyDefinitionGroupInternal)this).Name = (string)content.GetValueForProperty("Name", ((IPolicyDefinitionGroupInternal)this).Name, global::System.Convert.ToString);
            }
            keyValuePair = content.Cast<System.Collections.DictionaryEntry>().FirstOrDefault((kvp) => "DisplayName".Equals(kvp.Key.ToString(), StringComparison.OrdinalIgnoreCase));
            if (keyValuePair.Key != null)
            {
                ((IPolicyDefinitionGroupInternal)this).DisplayName = (string)content.GetValueForProperty("DisplayName", ((IPolicyDefinitionGroupInternal)this).DisplayName, global::System.Convert.ToString);
            }
            keyValuePair = content.Cast<System.Collections.DictionaryEntry>().FirstOrDefault((kvp) => "Category".Equals(kvp.Key.ToString(), StringComparison.OrdinalIgnoreCase));
            if (keyValuePair.Key != null)
            {
                ((IPolicyDefinitionGroupInternal)this).Category = (string)content.GetValueForProperty("Category", ((IPolicyDefinitionGroupInternal)this).Category, global::System.Convert.ToString);
            }
            keyValuePair = content.Cast<System.Collections.DictionaryEntry>().FirstOrDefault((kvp) => "Description".Equals(kvp.Key.ToString(), StringComparison.OrdinalIgnoreCase));
            if (keyValuePair.Key != null)
            {
                ((IPolicyDefinitionGroupInternal)this).Description = (string)content.GetValueForProperty("Description", ((IPolicyDefinitionGroupInternal)this).Description, global::System.Convert.ToString);
            }
            keyValuePair = content.Cast<System.Collections.DictionaryEntry>().FirstOrDefault((kvp) => "AdditionalMetadataId".Equals(kvp.Key.ToString(), StringComparison.OrdinalIgnoreCase));
            if (keyValuePair.Key != null)
            {
                ((IPolicyDefinitionGroupInternal)this).AdditionalMetadataId = (string)content.GetValueForProperty("AdditionalMetadataId", ((IPolicyDefinitionGroupInternal)this).AdditionalMetadataId, global::System.Convert.ToString);
            }
        }

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow)
        {
        }
    }
}