using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class ServiceAreaComparerTests : DtoComparerTestBase<ServiceAreaDto, string?>
{
    public ServiceAreaComparerTests() : base(new ServiceAreaDto
    {
        Id = 0,
        ServiceId = 0,
        ServiceAreaName = "Test",
    }, new ServiceAreaDto
    {
        Id = 0,
        ServiceId = 0,
        ServiceAreaName = "Test",
    }, dto => dto.ServiceAreaName)
    {

    }
}