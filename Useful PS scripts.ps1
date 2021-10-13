# get disks volumes
#Set-ExecutionPolicy RemoteSigned;
Get-Volume | 
  where { -not ([string]::IsNullOrWhiteSpace($_.DriveLetter)) } | 
  foreach { Write-Host "Drive: $($_.DriveLetter). Used size: $(($_.Size/1gb) - ($_.SizeRemaining/1gb)) GB" -BackgroundColor Black -ForegroundColor DarkGreen }

# check .Net version
reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\full" /v version

# check PS version
$PSVersionTable

# check laptop battery status
(Get-WmiObject -Class Win32_Battery).estimatedchargeremaining
# or
powercfg /batteryreport /output "C:\battery-report.html"


# run via CMD
# build sln
msbuild C:\Projects\ProjectName\SolutionName.sln /p:DebugSymbols=false /p:DebugType=None /p:RunCodeAnalysis=false /p:AllowedReferenceRelatedFileExtensions=none /p:DeployOnBuild=true /p:PublishProfile=Setup /flp:verbosity="diagnostic" /p:PublishBasePath="D\Test"

msbuild SolutionName.sln /flp:verbosity="diagnostic" /p:TrackFileAccess=false /p:DebugSymbols=false /p:DebugType=None /p:DeployOnBuild=true /p:PublishProfile=Setup /p:RunCodeAnalysis=false /p:AllowedReferenceRelatedFileExtensions=none

msbuild /flp:verbosity="diagnostic" /p:TrackFileAccess=false /p:DebugSymbols=false /p:DebugType=None /p:DeployOnBuild=true /p:PublishProfile=Deploy /p:RunCodeAnalysis=false /p:AllowedReferenceRelatedFileExtensions=none


# Example of using the Robocopy
$source = 'D:\MyStorage';
$destination = '\\UNC path\My remote storage';

# these flags can also be added: /NJH (no job header), /NJS (no job summary)
robocopy $source $destination /E /XC /XN /XO /NFL /NDL /NS /NC /LOG+:Log.log /TEE /R:3 /W:5
# another example
#robocopy $source $destination /E /XO /NDL /NS /NJH /UNILOG+:Log.log /TEE /R:3 /W:5 

# Any value greater than 7 indicates that there was at least one failure during the copy operation.
if ($lastexitcode -gt 7) {
	write-host "Robocopy failed with exit code:" $lastexitcode
} else {
	write-host "Robocopy succeeded! Exit code:" $lastexitcode
}
