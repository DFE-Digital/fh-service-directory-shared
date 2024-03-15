using Xunit;
using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Display;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Display;

public class LocationDisplayExtensionsTests
{
    public LocationDto LocationDto { get; set; }

    public LocationDisplayExtensionsTests()
    {
        LocationDto = new LocationDto
        {
            Id = 123,
            Address1 = "",
            City = "TestCity",
            StateProvince = "TestState",
            PostCode = "TestPostCode",
            LocationTypeCategory = LocationTypeCategory.NotSet,
            Latitude = 0,
            Longitude = 0,
            Country = "",
            LocationType = LocationType.Physical
        };
    }

    [Theory]
    [InlineData("Name", "Name", "X", "Y" )]
    [InlineData("X, Y", null, "X", "Y")]
    [InlineData("X, Y", "", "X", "Y")]
    [InlineData("X", null, "X", null)]
    [InlineData("X", null, "X", "")]
    [InlineData("X", "", "X", null)]
    [InlineData("X", "", "X", "")]
    [InlineData("Name,With,Comma", "Name,With,Comma", "X", "Y")]
    [InlineData("X,A, Y", null, "X,A", "Y")]
    public void GetDisplayName_ReturnsCorrectName(string expectedDisplayName, string? name, string address1, string? address2)
    {
        LocationDto.Name = name;

        LocationDto.Address1 = address1;
        LocationDto.Address2 = address2;
        var result = LocationDto.GetDisplayName();

        Assert.Equal(expectedDisplayName, result);
    }
}