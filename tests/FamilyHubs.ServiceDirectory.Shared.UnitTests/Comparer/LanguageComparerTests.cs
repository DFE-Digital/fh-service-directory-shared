using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class LanguageComparerTests : DtoComparerTestBase<LanguageDto, string>
{
    public LanguageComparerTests() : base(new LanguageDto
    {
        Id = 0,
        ServiceId = 0,
        Name = "Test",
    }, new LanguageDto
    {
        Id = 0,
        ServiceId = 0,
        Name = "Test",
    }, dto => dto.Name)
    {

    }
}