echo "Latest Nuget commandline can be downloaded from: https://www.nuget.org/downloads"
echo "Starting packing of Nuget package.." 
echo "Assuming that nuget.exe is in bundled Nuget folder in this VS solution"
echo Nuget\nuget.exe pack
echo "Remember to update the version attribute of the .nuspec file in this folder before packing and publishing. Edit the OpPlan4VSWebTestExport.nuspec file."
echo "Packing done. Push to nuget.org using: nuget\nuget.exe push WSTrustFiddlerWebTestExport.2.6.*.nupkg SECRETPUSHTOKEN -Source https://api.nuget.org/v3/index.json"
echo "When ready, run nuget push command to push package to Nuget. Nuget push command below"
echo "Sample push example to Nuget.org:" 
echo "c:\dev\OpPlan4VSWebTestExport\nuget\nuget.exe push c:\dev\OpPlan4VSWebTestExport\OpPlan4VSWebTestExport.2.6.2.nupkg SECRETPUSHTOKEN -Source https://api.nuget.org/v3/index.json"
echo "PUT https://www.nuget.org/api/v2/package/"
echo "WARNING: All published packages should have license information specified. Learn more: https://aka.ms/deprecateLicenseUrl."
echo "Created https://www.nuget.org/api/v2/package/ 2155ms"
echo "Your package was pushed.

