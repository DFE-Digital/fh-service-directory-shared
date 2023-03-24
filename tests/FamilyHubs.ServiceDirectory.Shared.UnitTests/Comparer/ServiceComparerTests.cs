using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class ServiceComparerTests : DtoComparerTestBase<ServiceDto, string>
{
    public ServiceComparerTests() : base(new ServiceDto
    {
        Id = 0,
        ServiceOwnerReferenceId = "Test",
        Name = "Test",
        ServiceType = ServiceType.InformationSharing,
    }, new ServiceDto
    {
        Id = 0,
        ServiceOwnerReferenceId = "Test",
        Name = "Test",
        ServiceType = ServiceType.InformationSharing,
    }, dto => dto.Name)
    {

    }
}