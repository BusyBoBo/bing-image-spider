InstallUtil.exe CloudMES.File.exe
Net Start CloudMESFileService
sc config CloudMESFileService start= auto
pause