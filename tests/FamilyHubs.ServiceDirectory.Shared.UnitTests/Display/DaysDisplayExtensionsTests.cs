using FamilyHubs.ServiceDirectory.Shared.Display;
using FamilyHubs.ServiceDirectory.Shared.ReferenceData.ICalendar;
using Xunit;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Display;

public class DaysDisplayExtensionsTests
{
    [Fact]
    public void GetDayNames_WhenDaysIsNull_ReturnsNoneProvided()
    {
        // Arrange
        IEnumerable<string>? days = null;

        // Act
        var result = days.GetDayNames();

        // Assert
        Assert.Equal("None provided", result);
    }

    [Fact]
    public void GetDayNames_WhenDaysIsEmpty_ReturnsNoneProvided()
    {
        // Arrange
        IEnumerable<string> days = Enumerable.Empty<string>();

        // Act
        var result = days.GetDayNames();

        // Assert
        Assert.Equal("None provided", result);
    }

    [Fact]
    public void GetDayNames_WhenDaysHasOneDay_ReturnsDay()
    {
        // Arrange
        IEnumerable<string> days = new[] { DayCode.MO.ToString() };

        // Act
        var result = days.GetDayNames();

        // Assert
        Assert.Equal("Monday", result);
    }

    [Fact]
    public void GetDayNames_WhenDaysHasMultipleDays_ReturnsDays()
    {
        // Arrange
        IEnumerable<string> days = new[] { DayCode.MO.ToString(), DayCode.TU.ToString(), DayCode.WE.ToString() };

        // Act
        var result = days.GetDayNames();

        // Assert
        Assert.Equal("Monday, Tuesday, Wednesday", result);
    }
}