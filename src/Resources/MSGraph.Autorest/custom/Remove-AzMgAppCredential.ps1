
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------


function Remove-AzMgAppCredential {
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='ApplicationObjectIdWithKeyIdParameterSet', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='ApplicationObjectIdWithKeyIdParameterSet', Mandatory)]
        [Alias('Id')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${ObjectId},

        [Parameter(ParameterSetName='ApplicationIdWithKeyIdParameterSet', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${ApplicationId},

        [Parameter(ParameterSetName='ApplicationDisplayNameParameterSet', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${DisplayName},

        [Parameter(ParameterSetName='ApplicationObjectWithKeyIdParameterSet', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphApplication]
        ${ApplicationObject},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
        [System.String]
        ${KeyId},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
      )
    
    process {
        switch ($PSCmdlet.ParameterSetName) {
            'ApplicationObjectIdWithKeyIdParameterSet' {
                $app = Get-AzMgApplication -ObjectId $PSBoundParameters['ObjectId']
                $null = $PSBoundParameters.Remove('ObjectId')
                if (!$app) {
                    Write-Error "application with id '$($PSBoundParameters['ObjectId'])' does not exist."
                    return
                }
                break
            }
            'ApplicationIdWithKeyIdParameterSet' {
                $app = Get-AzMgApplication -ApplicationId $PSBoundParameters['ApplicationId']
                $null = $PSBoundParameters.Remove('ApplicationId')
                if (!$app) {
                    Write-Error "application with app id '$($PSBoundParameters['ApplicationId'])' does not exist."
                    return
                }
                break
            }
            'ApplicationDisplayNameParameterSet' {
                $app = Get-AzMgApplication -DisplayName $PSBoundParameters['DisplayName']
                $null = $PSBoundParameters.Remove('DisplayName')
                if (0 -eq $app.Count) {
                    Write-Error "application with display name '$($PSBoundParameters['DisPlayName'])' does not exist."
                    return
                } elseif (1 -eq $app.Count) {
                    $app = $app[0]
                } else {
                    Write-Error "More than one application found with display name '$($PSBoundParameters['DisplayName'])'. Please use the Get-AzMgApplication cmdlet to get the object id of the desired application."
                    return
                }
                break
            }
            'ApplicationObjectWithKeyIdParameterSet' {
                $app = Get-AzMgApplication -ObjectId $PSBoundParameters['ApplicationObject'].Id
                $null = $PSBoundParameters.Remove('ApplicationObject')
                if (!$app) {
                    Write-Error "application with id '$($PSBoundParameters['ApplicationObject'].Id)' does not exist."
                    return
                }
                break
            }
            default {
                break
            }
        }
        $PSBoundParameters['ApplicationId'] = $app.Id
        if (!$PSBoundParameters['KeyId']) {
            foreach ($key in $app.KeyCredentials) {
                $PSBoundParameters['KeyId'] = $key.KeyId
                MSGraph.internal\Remove-AzMgApplicationKey @PSBoundParameters
            }
            foreach ($password in $app.PasswordCredentials) {
                $PSBoundParameters['KeyId'] = $password.KeyId
                MSGraph.internal\Remove-AzMgApplicationPassword @PSBoundParameters
            }
        } else {
            foreach ($key in $app.KeyCredentials) {
                if ($key.KeyId -eq $PSBoundParameters['KeyId']) {
                    MSGraph.internal\Remove-AzMgApplicationKey @PSBoundParameters
                    return
                }
            }
            foreach ($password in $app.PasswordCredentials) {
                if ($password.KeyId -eq $PSBoundParameters['KeyId']) {
                    MSGraph.internal\Remove-AzMgApplicationPassword @PSBoundParameters
                    return
                }
            }
            Write-Error "application '$($app.Id)' does not contains credential with key id: '$($PSBoundParameters['KeyId'])'."
        }
    }
}