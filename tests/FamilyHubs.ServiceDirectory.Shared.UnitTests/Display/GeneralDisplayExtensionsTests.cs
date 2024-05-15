using FamilyHubs.ServiceDirectory.Shared.Display;
using Xunit;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Display;

public class GeneralDisplayExtensionsTests
{
    [Theory]
    [InlineData(null, "None provided")]
    [InlineData("", "None provided")]
    [InlineData("Some description", "Some description")]
    public void GetDisplay(string? description, string expected)
    {
        // Act
        var result = description.GetDisplay();

        // Assert
        Assert.Equal(expected, result);
    }
}