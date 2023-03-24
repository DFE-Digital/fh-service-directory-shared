using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class OrganisationComparerTests : DtoComparerTestBase<OrganisationDto, string>
{
    public OrganisationComparerTests() : base(new OrganisationDto
    {
        Id = 0,
        Name = "Test",
        OrganisationType = OrganisationType.NotSet,
        Description = "Test",
        AdminAreaCode = "Test",
    }, new OrganisationDto
    {
        Id = 0,
        Name = "Test",
        OrganisationType = OrganisationType.NotSet,
        Description = "Test",
        AdminAreaCode = "Test",
    }, dto => dto.Name)
    {

    }
}