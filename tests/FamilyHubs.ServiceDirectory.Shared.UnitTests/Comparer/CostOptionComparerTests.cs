using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class CostOptionComparerTests : DtoComparerTestBase<CostOptionDto, string>
{
    public CostOptionComparerTests() : base(new CostOptionDto
    {
        Id = 0,
        ServiceId = 0,
        AmountDescription = "Test"
    }, new CostOptionDto()
    {
        Id = 0,
        ServiceId = 0,
        AmountDescription = "Test"
    }, dto => dto.AmountDescription)
    {

    }
}