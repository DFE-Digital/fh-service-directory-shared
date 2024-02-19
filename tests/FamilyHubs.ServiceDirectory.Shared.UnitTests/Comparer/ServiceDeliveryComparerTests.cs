using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class ServiceDeliveryComparerTests : DtoComparerTestBase<ServiceDeliveryDto, Enum>
{
    public ServiceDeliveryComparerTests() : base(new ServiceDeliveryDto
    {
        Id = 0,
        ServiceId = 0,
        Name = AttendingType.Online,
    }, new ServiceDeliveryDto
    {
        Id = 0,
        ServiceId = 0,
        Name = AttendingType.Online,
    }, dto => dto.Name)
    {
    }
}