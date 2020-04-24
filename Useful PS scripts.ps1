# check .Net version
reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\full" /v version

# check PS version
$PSVersionTable

# check laptop battery status
(Get-WmiObject -Class Win32_Battery).estimatedchargeremaining
# or
powercfg /batteryreport /output "C:\battery-report.html"

#build sln
msbuild SolutionName.sln /flp:verbosity="diagnostic" /p:TrackFileAccess=false /p:DebugSymbols=false /p:DebugType=None /p:DeployOnBuild=true /p:PublishProfile=Setup /p:RunCodeAnalysis=false /p:AllowedReferenceRelatedFileExtensions=none

msbuild /flp:verbosity="diagnostic" /p:TrackFileAccess=false /p:DebugSymbols=false /p:DebugType=None /p:DeployOnBuild=true /p:PublishProfile=Deploy /p:RunCodeAnalysis=false /p:AllowedReferenceRelatedFileExtensions=none