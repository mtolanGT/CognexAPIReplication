using System;
using System.IO;
using System.Windows.Forms;

public class FileLoader
{
    /// <summary>
    /// The main entry point for the application. Loads a file and prints its content.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        string fileContent = LoadFile();
        if (!string.IsNullOrEmpty(fileContent))
        {
            Console.WriteLine("File content loaded successfully:");
            Console.WriteLine(fileContent);
        }
    }

    /// <summary>
    /// Opens a file dialog to allow the user to select a file, and then reads the content of the selected file.
    /// </summary>
    /// <returns>The content of the selected file as a string, or an empty string if no file is selected.</returns>
    public static string LoadFile()
    {
        string content = string.Empty;

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "VWSA files (*.vwsa)|*.vwsa|VRWS files (*.vrws)|*.vrws|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileDialog.FileName;

                // Read the contents of the file into a string
                content = File.ReadAllText(filePath);
            }
        }

        return content;
    }
}
