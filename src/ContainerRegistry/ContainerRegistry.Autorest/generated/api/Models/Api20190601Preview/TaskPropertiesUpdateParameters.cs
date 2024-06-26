// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties for updating a task.</summary>
    public partial class TaskPropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="AgentConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties _agentConfiguration;

        /// <summary>The machine configuration of the run agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties AgentConfiguration { get => (this._agentConfiguration = this._agentConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentProperties()); set => this._agentConfiguration = value; }

        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public int? AgentConfigurationCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPropertiesInternal)AgentConfiguration).Cpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentPropertiesInternal)AgentConfiguration).Cpu = value ?? default(int); }

        /// <summary>Backing field for <see cref="AgentPoolName" /> property.</summary>
        private string _agentPoolName;

        /// <summary>The dedicated agent pool for the task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string AgentPoolName { get => this._agentPoolName; set => this._agentPoolName = value; }

        /// <summary>The type of the auto trigger for base image dependency updates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType? BaseImageTriggerBaseImageTriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerBaseImageTriggerType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerBaseImageTriggerType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType)""); }

        /// <summary>The name of the trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string BaseImageTriggerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerName = value ?? null; }

        /// <summary>The current status of trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus? BaseImageTriggerStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus)""); }

        /// <summary>The endpoint URL for receiving update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string BaseImageTriggerUpdateTriggerEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerUpdateTriggerEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerUpdateTriggerEndpoint = value ?? null; }

        /// <summary>Type of Payload body for Base image update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType? BaseImageTriggerUpdateTriggerPayloadType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerUpdateTriggerPayloadType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTriggerUpdateTriggerPayloadType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType)""); }

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials _credentials;

        /// <summary>
        /// The parameters that describes a set of credentials that will be used when this run is invoked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.Credentials()); set => this._credentials = value; }

        /// <summary>
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries CredentialsCustomRegistry { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).CustomRegistry; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).CustomRegistry = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="LogTemplate" /> property.</summary>
        private string _logTemplate;

        /// <summary>
        /// The template that describes the repository and tag information for run log artifact.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string LogTemplate { get => this._logTemplate; set => this._logTemplate = value; }

        /// <summary>Internal Acessors for AgentConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal.AgentConfiguration { get => (this._agentConfiguration = this._agentConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AgentProperties()); set { {_agentConfiguration = value;} } }

        /// <summary>Internal Acessors for Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal.Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.Credentials()); set { {_credentials = value;} } }

        /// <summary>Internal Acessors for CredentialsSourceRegistry</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceRegistryCredentials Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal.CredentialsSourceRegistry { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistry; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistry = value; }

        /// <summary>Internal Acessors for Platform</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal.Platform { get => (this._platform = this._platform ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.PlatformUpdateParameters()); set { {_platform = value;} } }

        /// <summary>Internal Acessors for Step</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal.Step { get => (this._step = this._step ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.TaskStepUpdateParameters()); set { {_step = value;} } }

        /// <summary>Internal Acessors for Trigger</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal.Trigger { get => (this._trigger = this._trigger ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.TriggerUpdateParameters()); set { {_trigger = value;} } }

        /// <summary>Internal Acessors for TriggerBaseImageTrigger</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskPropertiesUpdateParametersInternal.TriggerBaseImageTrigger { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTrigger; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).BaseImageTrigger = value; }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParameters _platform;

        /// <summary>The platform properties against which the run has to happen.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParameters Platform { get => (this._platform = this._platform ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.PlatformUpdateParameters()); set => this._platform = value; }

        /// <summary>The OS architecture.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture? PlatformArchitecture { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParametersInternal)Platform).Architecture; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParametersInternal)Platform).Architecture = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture)""); }

        /// <summary>The operating system type required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS? PlatformOS { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParametersInternal)Platform).OS; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParametersInternal)Platform).OS = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS)""); }

        /// <summary>Variant of the CPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant? PlatformVariant { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParametersInternal)Platform).Variant; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParametersInternal)Platform).Variant = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant)""); }

        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode? SourceRegistryLoginMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistryLoginMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsInternal)Credentials).SourceRegistryLoginMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode)""); }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TaskStatus? _status;

        /// <summary>The current status of task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TaskStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="Step" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParameters _step;

        /// <summary>The properties for updating a task step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParameters Step { get => (this._step = this._step ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.TaskStepUpdateParameters()); set => this._step = value; }

        /// <summary>
        /// The token (git PAT or SAS token of storage account blob) associated with the context for a step.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string StepContextAccessToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParametersInternal)Step).ContextAccessToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParametersInternal)Step).ContextAccessToken = value ?? null; }

        /// <summary>The URL(absolute or relative) of the source context for the task step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string StepContextPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParametersInternal)Step).ContextPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParametersInternal)Step).ContextPath = value ?? null; }

        /// <summary>The type of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType? StepType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParametersInternal)Step).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParametersInternal)Step).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType)""); }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private int? _timeout;

        /// <summary>Run timeout in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public int? Timeout { get => this._timeout; set => this._timeout = value; }

        /// <summary>Backing field for <see cref="Trigger" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParameters _trigger;

        /// <summary>The properties for updating trigger properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParameters Trigger { get => (this._trigger = this._trigger ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.TriggerUpdateParameters()); set => this._trigger = value; }

        /// <summary>The collection of triggers based on source code repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters[] TriggerSourceTrigger { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).SourceTrigger; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).SourceTrigger = value ?? null /* arrayOf */; }

        /// <summary>The collection of timer triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters[] TriggerTimerTrigger { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).TimerTrigger; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParametersInternal)Trigger).TimerTrigger = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="TaskPropertiesUpdateParameters" /> instance.</summary>
        public TaskPropertiesUpdateParameters()
        {

        }
    }
    /// The properties for updating a task.
    public partial interface ITaskPropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CPU configuration in terms of number of cores required for the run.",
        SerializedName = @"cpu",
        PossibleTypes = new [] { typeof(int) })]
        int? AgentConfigurationCpu { get; set; }
        /// <summary>The dedicated agent pool for the task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dedicated agent pool for the task.",
        SerializedName = @"agentPoolName",
        PossibleTypes = new [] { typeof(string) })]
        string AgentPoolName { get; set; }
        /// <summary>The type of the auto trigger for base image dependency updates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the auto trigger for base image dependency updates.",
        SerializedName = @"baseImageTriggerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType? BaseImageTriggerBaseImageTriggerType { get; set; }
        /// <summary>The name of the trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the trigger.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string BaseImageTriggerName { get; set; }
        /// <summary>The current status of trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current status of trigger.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus? BaseImageTriggerStatus { get; set; }
        /// <summary>The endpoint URL for receiving update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint URL for receiving update triggers.",
        SerializedName = @"updateTriggerEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string BaseImageTriggerUpdateTriggerEndpoint { get; set; }
        /// <summary>Type of Payload body for Base image update triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Payload body for Base image update triggers.",
        SerializedName = @"updateTriggerPayloadType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType? BaseImageTriggerUpdateTriggerPayloadType { get; set; }
        /// <summary>
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes the credential parameters for accessing other custom registries. The key
        for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        the value of the item will be the registry credentials for accessing the registry.",
        SerializedName = @"customRegistries",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries CredentialsCustomRegistry { get; set; }
        /// <summary>
        /// The template that describes the repository and tag information for run log artifact.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The template that describes the repository and tag information for run log artifact.",
        SerializedName = @"logTemplate",
        PossibleTypes = new [] { typeof(string) })]
        string LogTemplate { get; set; }
        /// <summary>The OS architecture.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The OS architecture.",
        SerializedName = @"architecture",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture? PlatformArchitecture { get; set; }
        /// <summary>The operating system type required for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operating system type required for the run.",
        SerializedName = @"os",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS? PlatformOS { get; set; }
        /// <summary>Variant of the CPU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Variant of the CPU.",
        SerializedName = @"variant",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant? PlatformVariant { get; set; }
        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The authentication mode which determines the source registry login scope. The credentials for the source registry
        will be generated using the given scope. These credentials will be used to login to
        the source registry during the run.",
        SerializedName = @"loginMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode? SourceRegistryLoginMode { get; set; }
        /// <summary>The current status of task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current status of task.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TaskStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TaskStatus? Status { get; set; }
        /// <summary>
        /// The token (git PAT or SAS token of storage account blob) associated with the context for a step.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The token (git PAT or SAS token of storage account blob) associated with the context for a step.",
        SerializedName = @"contextAccessToken",
        PossibleTypes = new [] { typeof(string) })]
        string StepContextAccessToken { get; set; }
        /// <summary>The URL(absolute or relative) of the source context for the task step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL(absolute or relative) of the source context for the task step.",
        SerializedName = @"contextPath",
        PossibleTypes = new [] { typeof(string) })]
        string StepContextPath { get; set; }
        /// <summary>The type of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the step.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType? StepType { get; set; }
        /// <summary>Run timeout in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Run timeout in seconds.",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(int) })]
        int? Timeout { get; set; }
        /// <summary>The collection of triggers based on source code repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of triggers based on source code repository.",
        SerializedName = @"sourceTriggers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters[] TriggerSourceTrigger { get; set; }
        /// <summary>The collection of timer triggers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of timer triggers.",
        SerializedName = @"timerTriggers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters[] TriggerTimerTrigger { get; set; }

    }
    /// The properties for updating a task.
    internal partial interface ITaskPropertiesUpdateParametersInternal

    {
        /// <summary>The machine configuration of the run agent.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAgentProperties AgentConfiguration { get; set; }
        /// <summary>The CPU configuration in terms of number of cores required for the run.</summary>
        int? AgentConfigurationCpu { get; set; }
        /// <summary>The dedicated agent pool for the task.</summary>
        string AgentPoolName { get; set; }
        /// <summary>The type of the auto trigger for base image dependency updates.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.BaseImageTriggerType? BaseImageTriggerBaseImageTriggerType { get; set; }
        /// <summary>The name of the trigger.</summary>
        string BaseImageTriggerName { get; set; }
        /// <summary>The current status of trigger.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus? BaseImageTriggerStatus { get; set; }
        /// <summary>The endpoint URL for receiving update triggers.</summary>
        string BaseImageTriggerUpdateTriggerEndpoint { get; set; }
        /// <summary>Type of Payload body for Base image update triggers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.UpdateTriggerPayloadType? BaseImageTriggerUpdateTriggerPayloadType { get; set; }
        /// <summary>
        /// The parameters that describes a set of credentials that will be used when this run is invoked.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentials Credentials { get; set; }
        /// <summary>
        /// Describes the credential parameters for accessing other custom registries. The key
        /// for the dictionary item will be the registry login server (myregistry.azurecr.io) and
        /// the value of the item will be the registry credentials for accessing the registry.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ICredentialsCustomRegistries CredentialsCustomRegistry { get; set; }
        /// <summary>Describes the credential parameters for accessing the source registry.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceRegistryCredentials CredentialsSourceRegistry { get; set; }
        /// <summary>
        /// The template that describes the repository and tag information for run log artifact.
        /// </summary>
        string LogTemplate { get; set; }
        /// <summary>The platform properties against which the run has to happen.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IPlatformUpdateParameters Platform { get; set; }
        /// <summary>The OS architecture.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Architecture? PlatformArchitecture { get; set; }
        /// <summary>The operating system type required for the run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.OS? PlatformOS { get; set; }
        /// <summary>Variant of the CPU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.Variant? PlatformVariant { get; set; }
        /// <summary>
        /// The authentication mode which determines the source registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be used to login to
        /// the source registry during the run.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceRegistryLoginMode? SourceRegistryLoginMode { get; set; }
        /// <summary>The current status of task.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TaskStatus? Status { get; set; }
        /// <summary>The properties for updating a task step.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParameters Step { get; set; }
        /// <summary>
        /// The token (git PAT or SAS token of storage account blob) associated with the context for a step.
        /// </summary>
        string StepContextAccessToken { get; set; }
        /// <summary>The URL(absolute or relative) of the source context for the task step.</summary>
        string StepContextPath { get; set; }
        /// <summary>The type of the step.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType? StepType { get; set; }
        /// <summary>Run timeout in seconds.</summary>
        int? Timeout { get; set; }
        /// <summary>The properties for updating trigger properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITriggerUpdateParameters Trigger { get; set; }
        /// <summary>The trigger based on base image dependencies.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageTriggerUpdateParameters TriggerBaseImageTrigger { get; set; }
        /// <summary>The collection of triggers based on source code repository.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters[] TriggerSourceTrigger { get; set; }
        /// <summary>The collection of timer triggers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITimerTriggerUpdateParameters[] TriggerTimerTrigger { get; set; }

    }
}