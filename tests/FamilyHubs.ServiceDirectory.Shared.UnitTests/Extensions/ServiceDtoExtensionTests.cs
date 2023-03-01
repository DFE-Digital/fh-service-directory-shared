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

    [Theory]
    [InlineData(ServiceDeliveryType.Telephone)]
    [InlineData(ServiceDeliveryType.Online)]
    public void GetContactShouldReturnNullWhenServiceLinkContactsIsNull(ServiceDeliveryType serviceDeliveryType)
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", serviceDeliveryType)
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Theory]
    [InlineData(ServiceDeliveryType.Telephone)]
    [InlineData(ServiceDeliveryType.Online)]
    public void GetContactShouldReturnNullWhenServiceLinkContactsIsEmpty(ServiceDeliveryType serviceDeliveryType)
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", serviceDeliveryType)
        };
        ServiceDto.LinkContacts = new List<LinkContactDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsIsNull()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.InPerson)
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsIsEmpty()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.InPerson)
        };
        ServiceDto.ServiceAtLocations = new List<ServiceAtLocationDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsLinkContactsIsNull()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.InPerson)
        };
        ServiceDto.ServiceAtLocations = new List<ServiceAtLocationDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsLinkContactsIsEmpty()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.InPerson)
        };
        ServiceDto.ServiceAtLocations = new List<ServiceAtLocationDto>
        {
            new ServiceAtLocationDto("", new LocationDto(), null, null, new List<LinkContactDto>())
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceDeliveryTypeIsNotEntered()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.NotEntered)
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Theory]
    [InlineData(ServiceDeliveryType.Telephone)]
    [InlineData(ServiceDeliveryType.Online)]
    public void GetContactShouldReturnServiceLinkContactsContact(ServiceDeliveryType serviceDeliveryType)
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", serviceDeliveryType)
        };
        ServiceDto.LinkContacts = new List<LinkContactDto>
        {
            new LinkContactDto(null, "", "", new ContactDto("test", null, "", "", "", null, null))
        };

        var result = ServiceDto.GetContact();
        Assert.NotNull(result);
        Assert.Equal("test", result.Id);
    }

    [Fact]
    public void GetContactShouldReturnServiceServiceAtLocationsLinkContactsContact()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", ServiceDeliveryType.InPerson)
        };
        ServiceDto.ServiceAtLocations = new List<ServiceAtLocationDto>
        {
            new ServiceAtLocationDto("", new LocationDto(), null, null, new List<LinkContactDto>
            {
                new LinkContactDto(null, "", "", new ContactDto("test", null, "", "", "", null, null))
            })
        };

        var result = ServiceDto.GetContact();
        Assert.NotNull(result);
        Assert.Equal("test", result.Id);
    }

    [Fact]
    public void GetContactShouldThrowArgumentOutOfRangeExceptionWhenServiceDeliveriesNameIsOutOfRange()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto("", (ServiceDeliveryType)byte.MaxValue)
        };

        Assert.Throws<ArgumentOutOfRangeException>(() => ServiceDto.GetContact());
    }
}