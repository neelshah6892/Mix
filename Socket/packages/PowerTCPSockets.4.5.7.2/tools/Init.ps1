param($installPath, $toolsPath, $package)

Write-Host "Displaying Readme"
$path = [System.IO.Path]
$readmehtml = $path::Combine($toolsPath, "readme.html") 
$DTE.ItemOperations.Navigate($readmehtml) 