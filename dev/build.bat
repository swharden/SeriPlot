@echo off

echo.
echo ### Deleting previous builds...
rmdir /s /q -r SeriPlot
del *.zip

echo.
echo ### Building Release...
dotnet build ..\src\ --configuration Release --output SeriPlot

echo.
echo ### Zipping...
tar.exe -a -cf SeriPlot.zip SeriPlot

echo.
echo ### DONE
pause