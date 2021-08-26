using System;
using System.IO;
using System.Diagnostics;

Class FileDetails
{
 
public string? FileVersion { get; }

public int GetVersion(String FileName)  
{  
        FileVersionInfo.GetVersionInfo(Path.Combine(Environment.SystemDirectory, FileName));
        FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.SystemDirectory + FileName);
        FileVersion=myFileVersionInfo.FileVersion
        return FileVersion
        // Print the file name and version number.
        Console.WriteLine("File: " + myFileVersionInfo.FileDescription + '\n' +
           "Version number: " + myFileVersionInfo.FileVersion);
    
}
public int GetSize(String file)  
{  

// Get the information about a file
FileInfo fi = new FileInfo(file);
// Print the file size to console
Console.WriteLine($"File size: {fi.Length} bytes");
}

}
