@REM set ORIGINAL_EXE_NAME=TowerFall.original.exe
@REM set PATCHED_EXE_NAME=TowerFall.exe.AI8P.exe
@REM set REPO_PATH=D:\__dev\code\towerfall\
@REM set BUILD_PATH=%REPO_PATH%TowerFallAi\bin\PatchWindows\
@REM set RELEASE_PATH=%REPO_PATH%release\
@REM set TOWERFALL_PATH="C:\Program Files (x86)\Steam\steamapps\common\TowerFall\"
< NUL call config.bat

xcopy /E /S /Y "%RELEASE_PATH%*" %TOWERFALL_PATH%

cd %TOWERFALL_PATH%
%GAME_DRIVE%

taskkill /IM %TOWERFALL_EXE_NAME%
@REM timeout 5
del %TOWERFALL_EXE_NAME%
copy %ORIGINAL_EXE_NAME% %TOWERFALL_EXE_NAME%
rmdir /S /Q "Patcher"

@REM 
%PATCHER_EXE%

del %TOWERFALL_EXE_NAME%
copy %PATCHED_EXE_NAME% %TOWERFALL_EXE_NAME%
del %PATCHED_EXE_NAME%

pause
