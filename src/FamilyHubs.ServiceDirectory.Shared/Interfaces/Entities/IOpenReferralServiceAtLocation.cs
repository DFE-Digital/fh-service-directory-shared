using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralServiceAtLocation
    {
        ICollection<OpenReferralHoliday_Schedule>? HolidayScheduleCollection { get; init; }
        OpenReferralLocation Location { get; init; }
        ICollection<OpenReferralRegular_Schedule>? Regular_schedule { get; init; }
    }
}