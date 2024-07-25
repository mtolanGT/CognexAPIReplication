using System;
using System.IO;
using Xunit;

namespace CognexAPIReplication.Tests
{
    public class FileLoaderTests : IDisposable
    {
        private string testFilePath;

        public FileLoaderTests()
        {
            // Create a temporary file with the content "hello world"
            testFilePath = Path.GetTempFileName();
            File.WriteAllText(testFilePath, "hello world");
        }

        public void Dispose()
        {
            // Delete the temporary file after the test
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [Fact]
        public void LoadFile_ShouldReturnHelloWorld()
        {
            // Arrange
            string expectedContent = "hello world";

            // Act
            string actualContent = FileLoader.LoadFile(testFilePath);

            // Assert
            Assert.Equal(expectedContent, actualContent);
        }
    }
}
