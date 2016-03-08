  # Create an array for results
  $results = @()
  $files = Get-ChildItem C:\Source\longbow-ui-developr -Filter "*.cs" -force -Recurse
  $ParamCount = 0
  $StringCount = 0
  $Pat = "^[a-zA-Z0-9\s\@\(\)]+$"
  # Loop through the project directory
  Foreach ($file In $files) 
  { 
    # load the content once
    $content = Get-Content $file.FullName 
    # find the lines containing the GetGlobalizedParam string
    $result = $content | Select-String "GetGlobalizedParam" -casesensitive -AllMatches 
    If ($result) 
    { 
        foreach( $r in $result)
        {
        
        # return only the value inside the parenthesis
        $split = $r.ToString().Trim().split("`"")
            foreach($s in $split)
            {
                if($s -match $Pat -and $s.Length -gt 2)
                {
                $ParamCount++
                 # tidy up the results and add to the array    
                 $results += New-Object PSObject -Property @{
                     FileName = $file.FullName 
                     ResourceId =  $s.ToString().Trim()
                     }
                }
            }
        }
    }
    # find the lines containing the GetGlobalizedString string
    $result = $content | Select-String "GetGlobalizedString" -casesensitive -AllMatches
    If ($result) 
    { 
        foreach( $r in $result)
        {
        
        # return only the ResourceId inside the parenthesis
        $split = $r.ToString().Trim().split("`"")
            foreach($s in $split)
            {
                if($s -match $Pat -and $s.Length -gt 2)
                {
                $StringCount++
                 # tidy up the results and add to the array    
                 $results += New-Object PSObject -Property @{
                     FileName = $file.FullName 
                     ResourceId =  $s.ToString().Trim()
                     }
                }
            }
        }
    }
      
  } 
  New-Item -ItemType Directory -Force -Path "C:\Source\dart.localizationLookup\dart.localizationLookup\bin\Debug"
  # return the results
  $results | Export-Csv -Path "C:\Source\dart.localizationLookup\dart.localizationLookup\bin\Debug\csvFile.csv" -NoTypeInformation

  ""
  "----------------------"
  "Number of instances of 'GetGlobalizedParam' located: " + $ParamCount.ToString()
  "Number of instances of 'GetGlobalizedString' located: " + $StringCount.ToString()
  "----------------------"