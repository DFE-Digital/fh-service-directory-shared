using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
using FamilyHubs.ServiceDirectory.Shared.ReferenceData.ICalendar;

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

        var dayNames = schedules
            !.FirstOrDefault(s => s.Freq == FrequencyType.WEEKLY)
            ?.ByDay?.Split(",")
            .Select(c => Calendar.DayCodeToName[c])
            .ToList();

        var timeDescription = GetTimeDescription(schedules);

        bool hasDayNames = dayNames?.Any() == true;
        bool hasTimeDescription = timeDescription.Any();

        if (!hasDayNames && !hasTimeDescription)
            return Enumerable.Empty<string>();

        if (hasDayNames && hasTimeDescription)
        {
            return dayNames!.Append("").Concat(timeDescription);
        }

        return hasDayNames ? dayNames! : timeDescription;
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