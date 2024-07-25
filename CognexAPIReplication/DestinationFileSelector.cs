using System;
using System.Windows.Forms;

public class DestinationFileSelector
{
    /// <summary>
    /// Opens a folder browser dialog to allow the user to select a destination directory.
    /// </summary>
    /// <returns>The path of the selected directory, or an empty string if no directory is selected.</returns>
    public static string SelectDestinationDirectory()
    {
        using (var folderBrowserDialog = new FolderBrowserDialog())
        {
            folderBrowserDialog.Description = "Select a destination folder";
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
        }

        return string.Empty;
    }
}
