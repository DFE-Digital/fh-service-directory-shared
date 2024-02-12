using System.Collections.ObjectModel;

namespace FamilyHubs.ServiceDirectory.Shared.ReferenceData.ICalendar;

public static class Calendar
{
    public static readonly IReadOnlyDictionary<string, string> DayCodeToName
        = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
        {
            { DayCode.MO.ToString(), "Monday" },
            { DayCode.TU.ToString(), "Tuesday" },
            { DayCode.WE.ToString(), "Wednesday" },
            { DayCode.TH.ToString(), "Thursday" },
            { DayCode.FR.ToString(), "Friday" },
            { DayCode.SA.ToString(), "Saturday" },
            { DayCode.SU.ToString(), "Sunday" },
        });
}