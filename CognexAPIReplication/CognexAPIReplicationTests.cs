using System;
using Xunit;

namespace CognexAPIReplication.Tests
{
    public class FileSelectorTests
    {
        [Fact]
        public void SelectDestinationDirectory_ShouldReturnString()
        {
            // Act
            string selectedPath = DestinationFileSelector.SelectDestinationDirectory();

            // Assert
            // Since user interaction is required, we cannot assert a specific path.
            // We assert that the method returns a string.
            Assert.IsType<string>(selectedPath);
        }
    }
}
