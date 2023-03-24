using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class LocationComparerTests : DtoComparerTestBase<LocationDto, string>
{
    public LocationComparerTests() : base(new LocationDto
    {
        Id = 0,
        Name = "Test",
        LocationType = LocationType.NotSet,
        Latitude = 0,
        Longitude = 0,
        Address1 = "Test",
        City = "Test",
        PostCode = "Test",
        StateProvince = "Test",
        Country = "Test",
    }, new LocationDto
    {
        Id = 0,
        Name = "Test",
        LocationType = LocationType.NotSet,
        Latitude = 0,
        Longitude = 0,
        Address1 = "Test",
        City = "Test",
        PostCode = "Test",
        StateProvince = "Test",
        Country = "Test",
    }, dto => dto.Name)
    {

    }
}