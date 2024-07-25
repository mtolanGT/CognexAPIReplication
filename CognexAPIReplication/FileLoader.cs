using System;
using System.IO;

public class FileLoader
{
    /// <summary>
    /// Reads the content of the specified file.
    /// </summary>
    /// <param name="filePath">The path of the file to read.</param>
    /// <returns>The content of the selected file as a string, or an empty string if no file is selected.</returns>
    public static string LoadFile(string filePath)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
        {
            return string.Empty;
        }

        return File.ReadAllText(filePath);
    }
}