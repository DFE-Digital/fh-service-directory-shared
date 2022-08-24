using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLocations;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;

public record OpenReferralServiceAtLocationDto : IOpenReferralServiceAtLocationDto
{
    public OpenReferralServiceAtLocationDto() { }
    public OpenReferralServiceAtLocationDto(
        string id,
        IOpenReferralLocationDto location
        //ICollection<OpenReferralHoliday_Schedule>? holidayScheduleCollection, ICollection<OpenReferralRegular_Schedule>? regular_schedule
        )
    {
        Id = id;
        Location = location;
        //HolidayScheduleCollection = holidayScheduleCollection;
        //Regular_schedule = regular_schedule;
    }

    public string Id { get; set; } = default!;
    public IOpenReferralLocationDto Location { get; init; } = default!;
    //public ICollection<OpenReferralHoliday_Schedule>? HolidayScheduleCollection { get; init; }
    //public ICollection<OpenReferralRegular_Schedule>? Regular_schedule { get; init; }
}

