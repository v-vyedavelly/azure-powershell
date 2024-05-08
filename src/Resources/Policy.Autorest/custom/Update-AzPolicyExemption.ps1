
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
This operation updates a policy exemption with the given scope and name.
.Description
This operation updates a policy exemption with the given scope and name.
.Notes
## RELATED LINKS

[Get-AzPolicyExemption](./Get-AzPolicyExemption.md)

[New-AzPolicyExemption](./New-AzPolicyExemption.md)

[Remove-AzPolicyExemption](./Remove-AzPolicyExemption.md)
.Link
https://learn.microsoft.com/powershell/module/az.resources/update-azpolicyexemption
#>
function Update-AzPolicyExemption {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyExemption])]
[Alias('Set-AzPolicyExemption')]
[CmdletBinding(DefaultParameterSetName='Name', SupportsShouldProcess=$true, ConfirmImpact='Low')]
param(
    [Parameter(ParameterSetName='Name', Mandatory, ValueFromPipelineByPropertyName)]
    [ValidateNotNullOrEmpty()]
    [Alias('PolicyExemptionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The name of the policy exemption.
    ${Name},

    [Parameter(ParameterSetName='Name', ValueFromPipelineByPropertyName)]
    [ValidateNotNullOrEmpty()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The scope of the policy exemption.
    # Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
    ${Scope},

    [Parameter(ParameterSetName='Id', Mandatory, ValueFromPipelineByPropertyName)]
    [ValidateNotNullOrEmpty()]
    [Alias('ResourceId')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The ID of the policy assignment to delete.
    # Use the format '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
    ${Id},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The display name of the policy assignment.
    ${DisplayName},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # This message will be part of response in case of policy violation.
    ${Description},

    [Parameter(ValueFromPipelineByPropertyName)]
    [ValidateSet('Waiver', 'Mitigated')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String]
    # The policy exemption category
    ${ExemptionCategory},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Path')]
    [System.String[]]
    # The policy definition reference ID list when the associated policy assignment is for a policy set (initiative).
    ${PolicyDefinitionReferenceId},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Nullable[System.DateTime]]
    # The expiration date and time (in UTC ISO 8601 format yyyy-MM-ddTHH:mm:ssZ) of the policy exemption.
    ${ExpiresOn},

    [Parameter(ValueFromPipelineByPropertyName)]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether to clear the expiration date and time of the policy exemption.
    ${ClearExpiration},

    [Parameter(ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyExemptionPropertiesMetadata]))]
    [System.String]
    # The policy assignment metadata.
    # Metadata is an open ended object and is typically a collection of key value pairs.
    ${Metadata},

    [Parameter(ParameterSetName = 'InputObject', Mandatory, ValueFromPipeline, ValueFromPipelineByPropertyName)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyExemption]
    ${InputObject},

    [Parameter()]
    [Obsolete('This parameter is a temporary bridge to new types and formats and will be removed in a future release.')]
    [System.Management.Automation.SwitchParameter]
    # Causes cmdlet to return artifacts using legacy format placing policy-specific properties in a property bag object.
    ${BackwardCompatible} = $false,

    [Parameter()]
    [ValidateSet('Default', 'DoNotValidate')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Body')]
    [System.String]
    # The option whether validate the exemption is at or under the assignment scope.
    ${AssignmentScopeValidation},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Policy.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    # turn on console debug messages
    $writeln = ($PSCmdlet.MyInvocation.BoundParameters.Debug -as [bool]) -or ($PSCmdlet.MyInvocation.BoundParameters.Verbose -as [bool])

    if ($writeln) {
        Write-Host -ForegroundColor Cyan "begin:Update-AzPolicyExemption(" $PSBoundParameters ") - (ParameterSet: $($PSCmdlet.ParameterSetName))"
    }
}

process {
    if ($writeln) {
        Write-Host -ForegroundColor Cyan "process:Update-AzPolicyExemption(" $PSBoundParameters ") - (ParameterSet: $($PSCmdlet.ParameterSetName))"
    }

    # Id can be a parameter or from the input object
    if ($Id) {
        $thisId = $Id
    } else {
        $thisId = $InputObject.Id
    }

    # construct id for exemption to update
    $resolved = ResolvePolicyExemption $Name $Scope $thisId

    $getParameters = Get-ExtraParameters @PSBoundParameters
    $getParameters['Id'] = $resolved.ResourceId

    if ($writeln) {
        Write-Host -ForegroundColor Blue -> Get-AzPolicyExemption'(' $getParameters ')'
    }

    try {
        $existing = Get-AzPolicyExemption @getParameters
    }
    catch {
        # treat any error on get as nonexistent
        if ($writeLn) {
            Write-Host -ForegroundColor DarkGray 'Swallowed exception: ' $_
        }
    }

    if (!$existing) {
        throw "[PolicyExemptionNotFound] : The policy exemption '$($resolved.ResourceId)' is not found."
    }

    $calledParameters = @{}
    # populate called parameters from input object if present (these will be overridden by command-line values below)
    if ($InputObject) {
        foreach ($parameterName in $InputObject.Keys) {
            $value = $InputObject.($parameterName)
            if ($value -or ($value -is [array])) {
                $calledParameters.($parameterName) = $value
            }
        }
    }

    # skip $null and empty values to avoid validation failures on pipeline input
    foreach ($parameterName in $PSBoundParameters.Keys) {
        $value = $PSBoundParameters.($parameterName)
        if ($value -or ($value -is [array])) {
            $calledParameters.($parameterName) = $value
        }
    }

    # supply required parameters and remove custom parameters
    $calledParameters.Name = $resolved.Name
    $calledParameters.Scope = $resolved.FullScope
    $null = $calledParameters.Remove('Id')
    $null = $calledParameters.Remove('InputObject')

    $calledParameters.PolicyAssignment = [PSCustomObject]@{ Id = $existing.PolicyAssignmentId }

    if (!$ExemptionCategory) {
        $calledParameters.ExemptionCategory = $existing.ExemptionCategory
    }

    if (!$ExpiresOn) {
        $calledParameters.ExpiresOn = $existing.ExpiresOn
    }

    if ($ClearExpiration) {
        $calledParameters.ExpiresOn = $null
        $null = $calledParameters.Remove('ClearExpiration')
    }

    if ($BackwardCompatible) {
        $calledParameters.BackwardCompatible = $true
    }

    if ($writeln) {
        Write-Host -ForegroundColor Blue -> New-AzPolicyExemption'(' $calledParameters ')'
    }

    New-AzPolicyExemption @calledParameters
}

end {
} 
}
