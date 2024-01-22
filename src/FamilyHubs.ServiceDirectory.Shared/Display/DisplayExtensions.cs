using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Display;

//todo: unit tests
public static class DisplayExtensions
{
    public static IEnumerable<string> GetServiceAvailability(this ServiceDto service)
    {
        return service.Schedules.GetServiceAvailability();
    }

    public static IEnumerable<string> GetServiceAvailability(this ICollection<ScheduleDto>? schedules)
    {
        if (schedules == null || schedules.Count == 0)
            return Enumerable.Empty<string>();

        var weekdaysAndWeekends = GetWeekdaysAndWeekends(schedules).ToArray();
        var timeDescription = GetTimeDescription(schedules);

        bool hasWeekdaysAndWeekends = weekdaysAndWeekends.Length > 0;

        if (!hasWeekdaysAndWeekends && timeDescription == null)
            return Enumerable.Empty<string>();

        if (hasWeekdaysAndWeekends && timeDescription != null)
        {
            return weekdaysAndWeekends.Append("").Append(timeDescription);
        }

        return hasWeekdaysAndWeekends ? weekdaysAndWeekends : new[] { timeDescription! };
    }

    public static IEnumerable<string> GetWeekdaysAndWeekends(this ServiceDto service)
    {
        return service.Schedules.GetWeekdaysAndWeekends();
    }

    public static IEnumerable<string> GetWeekdaysAndWeekends(this ICollection<ScheduleDto> schedules)
    {
        return schedules
            .Select(ScheduleDescription)
            .Where(d => !string.IsNullOrEmpty(d))!;
    }

    private static string? ScheduleDescription(ScheduleDto schedule)
    {
        if (schedule.Freq != FrequencyType.Weekly)
        {
            return null;
        }

        string dayType;
        switch (schedule.ByDay)
        {
            case "MO,TU,WE,TH,FR":
                dayType = "Weekdays";
                break;
            case "SA,SU":
                dayType = "Weekends";
                break;
            default:
                return null;
        }

        return $"{dayType}: {schedule.OpensAt:h:mmtt} to {schedule.ClosesAt:h:mmtt}";
    }

    public static string? GetTimeDescription(this ServiceDto service)
    {
        return service.Schedules.GetTimeDescription();
    }

    public static string? GetTimeDescription(this ICollection<ScheduleDto> schedules)
    {
        return schedules.FirstOrDefault(x => x.Description != null)?.Description;
    }
}