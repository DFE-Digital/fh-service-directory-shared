using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Display;

public static class ServiceDisplayExtensions
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
        var timeDescription = GetTimeDescription(schedules).ToArray();

        bool hasWeekdaysAndWeekends = weekdaysAndWeekends.Length > 0;
        bool hasTimeDescription = timeDescription.Length > 0;

        if (!hasWeekdaysAndWeekends && !hasTimeDescription)
            return Enumerable.Empty<string>();

        if (hasWeekdaysAndWeekends && hasTimeDescription)
        {
            return weekdaysAndWeekends.Append("").Concat(timeDescription);
        }

        return hasWeekdaysAndWeekends ? weekdaysAndWeekends : timeDescription;
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

    public static IEnumerable<string> GetTimeDescription(this ServiceDto service)
    {
        return service.Schedules.GetTimeDescription();
    }

    public static IEnumerable<string> GetTimeDescription(this ICollection<ScheduleDto> schedules)
    {
        // data created/updated through the UI has \r\n for the line break
        // data imported through the spreadsheet has just \n for the line break

        string? description = schedules
            .FirstOrDefault(x => x.Description != null)?.Description?
            .Replace("\r", "");

        return description?.Split("\n")
               ?? Enumerable.Empty<string>();
    }
}