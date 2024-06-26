﻿using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
using FamilyHubs.ServiceDirectory.Shared.Extensions;
using Xunit;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Extensions;

public class ServiceDtoExtensionTests
{
    private ServiceDto ServiceDto { get; }

    public ServiceDtoExtensionTests()
    {
        ServiceDto = new ServiceDto
        {
            Id = Random.Shared.Next(),
            ServiceType = ServiceType.NotSet,
            OrganisationId = Random.Shared.Next(),
            Name = "TestService"
        };
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
    [InlineData(AttendingType.Telephone)]
    [InlineData(AttendingType.Online)]
    public void GetContactShouldReturnNullWhenServiceLinkContactsIsNull(AttendingType serviceDeliveryType)
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = serviceDeliveryType
            }
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Theory]
    [InlineData(AttendingType.Telephone)]
    [InlineData(AttendingType.Online)]
    public void GetContactShouldReturnNullWhenServiceLinkContactsIsEmpty(AttendingType serviceDeliveryType)
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = serviceDeliveryType
            }
        };
        ServiceDto.Contacts = new List<ContactDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsIsNull()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = AttendingType.InPerson
            }
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsIsEmpty()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = AttendingType.InPerson
            }
        };

        ServiceDto.Locations = new List<LocationDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsLinkContactsIsNull()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = AttendingType.InPerson
            }
        };
        ServiceDto.Locations = new List<LocationDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceAtLocationsLinkContactsIsEmpty()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = AttendingType.InPerson
            }
        };

        ServiceDto.Locations = new List<LocationDto>
        {
            new LocationDto
            {
                Id = Random.Shared.Next(),
                OrganisationId = 123,
                LocationTypeCategory = LocationTypeCategory.NotSet,
                Name = "",
                Latitude = 0,
                Longitude = 0,
                Address1 = "",
                City = "",
                PostCode = "",
                StateProvince = "",
                Country = "",
                Contacts = new List<ContactDto>(),
                LocationType=LocationType.Physical
            }
        };

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Fact]
    public void GetContactShouldReturnNullWhenServiceDeliveryTypeIsNotEntered()
    {
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>();

        var result = ServiceDto.GetContact();
        Assert.Null(result);
    }

    [Theory]
    [InlineData(AttendingType.Telephone)]
    [InlineData(AttendingType.Online)]
    public void GetContactShouldReturnServiceLinkContactsContact(AttendingType serviceDeliveryType)
    {
        var contactId = Random.Shared.Next();
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = serviceDeliveryType
            }
        };
        ServiceDto.Contacts = new List<ContactDto>
        {
            new ContactDto
            {
                Id = contactId,
                Telephone = "1234"
            }
        };

        var result = ServiceDto.GetContact();
        Assert.NotNull(result);
        Assert.Equal(contactId, result.Id);
        Assert.Equal("1234", result.Telephone);
    }

    [Fact]
    public void GetContactShouldReturnServiceServiceAtLocationsLinkContactsContact()
    {
        var contactId = Random.Shared.Next();
        ServiceDto.ServiceDeliveries = new List<ServiceDeliveryDto>
        {
            new ServiceDeliveryDto
            {
                Id = Random.Shared.Next(),
                ServiceId = Random.Shared.Next(),
                Name = AttendingType.InPerson
            }
        };
        ServiceDto.Locations = new List<LocationDto>
        {
            new LocationDto
            {
                Id = Random.Shared.Next(),
                OrganisationId = 123,
                LocationTypeCategory = LocationTypeCategory.NotSet,
                Name = "",
                Latitude = 0,
                Longitude = 0,
                Address1 = "",
                City = "",
                PostCode = "",
                StateProvince = "",
                Country = "",
                Contacts = new List<ContactDto>
                {
                    new ContactDto
                    {
                        Id = contactId,
                        Telephone = "9876"
                    }
                },
                LocationType=LocationType.Physical
            }
        };

        var result = ServiceDto.GetContact();
        Assert.NotNull(result);
        Assert.Equal(contactId, result.Id);
        Assert.Equal("9876", result.Telephone);
    }
}