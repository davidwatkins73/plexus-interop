REM Generate code from CcyPairRateViewer interop definitions

set PLEXUS_GEN_PATH=..\..\..\bin\win-x86\sdk\plexusgen.jar
set INTEROP_METADATA_PATH=..\..\..\samples\quick-start\registry
if not defined NUGET_PACKAGES (
  set NUGET_PACKAGES=%USERPROFILE%\.nuget\packages
)
set PROTOC_PATH=%NUGET_PACKAGES%\google.protobuf.tools\3.4.0\tools\windows_x86\protoc.exe

set INTEROP_MANIFEST_PATH=vendorB\fx\CcyPairRateViewer.interop
set CSHARP_NAMESPACE=Plexus.Interop.Samples.CcyPairRateViewer.Generated
set CSHARP_OUT=Generated

java -jar %PLEXUS_GEN_PATH% --baseDir=%INTEROP_METADATA_PATH% --input=%INTEROP_METADATA_PATH%\%INTEROP_MANIFEST_PATH% --type=csharp --out=%CSHARP_OUT% --namespace=%CSHARP_NAMESPACE% --protoc=%PROTOC_PATH%