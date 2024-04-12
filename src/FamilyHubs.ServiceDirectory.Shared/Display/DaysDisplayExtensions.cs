
using FamilyHubs.ServiceDirectory.Shared.ReferenceData.ICalendar;

namespace FamilyHubs.ServiceDirectory.Shared.Display;

public static class DaysDisplayExtensions
{
    public static string GetDayNames(this IEnumerable<string>? days)
    {
        if (days == null || !days.Any())
        {
            return "None provided";
        }

        return string.Join(", ", days.Select(c => Calendar.DayCodeToName[c]));
    }
}