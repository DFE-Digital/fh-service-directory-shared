using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
using FamilyHubs.ServiceDirectory.Shared.Extensions;
using Xunit;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Extensions;

public class ServiceDtoExtensionTests
{
    public ServiceDto ServiceDto { get; set; }

    public ServiceDtoExtensionTests()
    {
        ServiceDto = new ServiceDto();
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceDeliveriesIsNull()
    {
        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceDeliveriesIsEmpty()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>();
        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenLinkContactsIsNull()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.Online)
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenLinkContactsIsEmpty()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.Online)
        };
        ServiceDto.LinkContacts = new List<LinkContactDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }
}