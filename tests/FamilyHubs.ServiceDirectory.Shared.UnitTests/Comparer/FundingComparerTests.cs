using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class FundingComparerTests : DtoComparerTestBase<FundingDto, string>
{
    public FundingComparerTests() : base(new FundingDto
    {
        Id = 0,
        ServiceId = 0,
        Source = "Test",
    }, new FundingDto
    {
        Id = 0,
        ServiceId = 0,
        Source = "Test",
    }, dto => dto.Source)
    {

    }
}