using Xunit;
using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
using FamilyHubs.ServiceDirectory.Shared.Display;

//todo: more and better needed
public class ServiceDisplayExtensionsTests
{
    public ServiceDto ServiceDto { get; set; }

    public ServiceDisplayExtensionsTests()
    {
        ServiceDto = new ServiceDto
        {
            Id = Random.Shared.Next(),
            ServiceType = ServiceType.NotSet,
            OrganisationId = Random.Shared.Next(),
            Name = "TestService",
            ServiceOwnerReferenceId = "serviceId1"
        };
    }

    [Fact]
    public void GetServiceAvailability_ReturnsExpectedResult()
    {
        // Arrange
        ServiceDto.Schedules = new List<ScheduleDto>
        {
            new()
            {
                Freq = FrequencyType.WEEKLY, ByDay = "MO,TU,WE,TH,FR"
            },
        };

        // Act
        var result = ServiceDto.GetServiceAvailability();

        // Assert
        Assert.NotNull(result);
        Assert.Single(result);
    }

    [Fact]
    public void GetServiceAvailabilityScheduleAndDescription_ReturnsExpectedResult()
    {
        // Arrange
        ServiceDto.Schedules = new List<ScheduleDto>
        {
            new()
            {
                Freq = FrequencyType.WEEKLY, ByDay = "MO,SU"
            },
            new()
            {
                Description = "Abc"
            }
        };

        // Act
        var result = ServiceDto.GetServiceAvailability();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(3, result.Count());
    }

    [Fact]
    public void GetTimeDescription_ReturnsExpectedResult()
    {
        // Arrange
        var schedules = new List<ScheduleDto>
        {
            new() { Description = "9:00AM to 5:00PM\r\n10:00AM to 4:00PM" }
        };

        // Act
        var result = schedules.GetTimeDescription();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
    }

    [Fact]
    public void GetTimeDescription_SpreadsheetData_ReturnsExpectedResult()
    {
        // Arrange
        var schedules = new List<ScheduleDto>
        {
            new() { Description = "9:00AM to 5:00PM\n10:00AM to 4:00PM" }
        };

        // Act
        var result = schedules.GetTimeDescription();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
    }
}
