using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class ContactComparerTests : DtoComparerTestBase<ContactDto, string>
{
    public ContactComparerTests() : base(new ContactDto
    {
        Id = 0,
        LocationId = 0,
        Telephone = "Test"
    }, new ContactDto()
    {
        Id = 0,
        LocationId = 0,
        Telephone = "Test"
    }, dto => dto.Telephone)
    {

    }
}