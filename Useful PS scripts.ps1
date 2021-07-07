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
