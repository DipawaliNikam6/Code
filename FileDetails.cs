using System;
using System.IO;
using System.Diagnostics;

Class FileDetails
{
 
public string? FileVersion { get; }

public int GetVersion(String fileName)  
{  
        FileVersionInfo.GetVersionInfo(Path.Combine(Environment.SystemDirectory, fileName));
        FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(Environment.SystemDirectory + fileName);
        FileVersion=myFileVersionInfo.FileVersion
        
        // Print the file name and version number.
        Console.WriteLine("File: " + myFileVersionInfo.FileDescription + '\n' +
           "Version number: " + myFileVersionInfo.FileVersion);
        return FileVersion;
}
public int GetSize(String fileName)  
{  

    FileInfo fileinfo = new FileInfo(fileName);
    var size=fileinfo.Length;
    Console.WriteLine(size);
    return size;
}


}
