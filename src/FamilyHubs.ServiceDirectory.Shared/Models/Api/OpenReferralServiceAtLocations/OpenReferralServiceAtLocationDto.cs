using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralHolidaySchedule;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLocations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralRegularSchedule;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;

public record OpenReferralServiceAtLocationDto : IOpenReferralServiceAtLocationDto
{
    public OpenReferralServiceAtLocationDto() { }
    public OpenReferralServiceAtLocationDto(
        string id,
        OpenReferralLocationDto location,
        ICollection<OpenReferralRegularScheduleDto>? regular_schedule,
        ICollection<OpenReferralHolidayScheduleDto>? holidayScheduleCollection 
        )
    {
        Id = id;
        Location = location;
        HolidayScheduleCollection = holidayScheduleCollection;
        Regular_schedule = regular_schedule;
    }

    public string Id { get; set; } = default!;
    public OpenReferralLocationDto Location { get; init; } = default!;
    public ICollection<OpenReferralRegularScheduleDto>? Regular_schedule { get; init; }
    public ICollection<OpenReferralHolidayScheduleDto>? HolidayScheduleCollection { get; init; }
    
}

