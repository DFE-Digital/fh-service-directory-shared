using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class AccessibilityForDisabilitiesComparerTests : DtoComparerTestBase<AccessibilityForDisabilitiesDto, string>
{
    public AccessibilityForDisabilitiesComparerTests() : base(new AccessibilityForDisabilitiesDto
    {
        Id = 0,
        LocationId = 0,
        Accessibility = "Test"
    }, new AccessibilityForDisabilitiesDto
    {
        Id = 0,
        LocationId = 0,
        Accessibility = "Test"
    }, dto => dto.Accessibility)
    {

    }
}