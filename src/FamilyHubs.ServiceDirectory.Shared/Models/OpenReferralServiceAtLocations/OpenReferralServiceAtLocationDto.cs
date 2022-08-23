using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralLocation;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceAtLocation;

public record OpenReferralServiceAtLocationDto : IOpenReferralServiceAtLocationDto
{
    private OpenReferralServiceAtLocationDto() { }
    public OpenReferralServiceAtLocationDto(string id,
        OpenReferralLocationDto location
        //ICollection<OpenReferralHoliday_Schedule>? holidayScheduleCollection, ICollection<OpenReferralRegular_Schedule>? regular_schedule
        )
    {
        Id = id;
        Location = location;
        //HolidayScheduleCollection = holidayScheduleCollection;
        //Regular_schedule = regular_schedule;
    }

    public string Id { get; set; } = default!;
    public OpenReferralLocationDto Location { get; init; } = default!;
    //public ICollection<OpenReferralHoliday_Schedule>? HolidayScheduleCollection { get; init; }
    //public ICollection<OpenReferralRegular_Schedule>? Regular_schedule { get; init; }
}

