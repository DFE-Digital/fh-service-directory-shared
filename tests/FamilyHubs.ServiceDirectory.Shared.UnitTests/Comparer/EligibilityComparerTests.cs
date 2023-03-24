using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class EligibilityComparerTests : DtoComparerTestBase<EligibilityDto, int>
{
    public EligibilityComparerTests() : base(new EligibilityDto
    {
        Id = 0,
        ServiceId = 0,
        MaximumAge = 0,
        MinimumAge = 0
    }, new EligibilityDto
    {
        Id = 0,
        ServiceId = 0,
        MaximumAge = 0,
        MinimumAge = 0
    }, dto => dto.MaximumAge)
    {

    }
}