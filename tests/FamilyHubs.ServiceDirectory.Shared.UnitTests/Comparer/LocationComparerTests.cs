using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

//todo: do we need unit tests to effectively test generated record's equality handling?
//todo: using "Test" for all string fields is prone to missing errors, as it will miss transposed properties
public class LocationComparerTests : DtoComparerTestBase<LocationDto, string>
{
    public LocationComparerTests() : base(new LocationDto
    {
        Id = 0,
        OrganisationId = 123,
        Name = "Test",
        LocationTypeCategory = LocationTypeCategory.NotSet,
        Latitude = 0,
        Longitude = 0,
        Address1 = "Test",
        City = "Test",
        PostCode = "Test",
        StateProvince = "Test",
        Country = "Test",
        LocationType= LocationType.Physical
    }, new LocationDto
    {
        Id = 0,
        OrganisationId = 123,
        Name = "Test",
        LocationTypeCategory = LocationTypeCategory.NotSet,
        Latitude = 0,
        Longitude = 0,
        Address1 = "Test",
        City = "Test",
        PostCode = "Test",
        StateProvince = "Test",
        Country = "Test",
        LocationType= LocationType.Physical
    }, dto => dto.Name)
    {

    }
}