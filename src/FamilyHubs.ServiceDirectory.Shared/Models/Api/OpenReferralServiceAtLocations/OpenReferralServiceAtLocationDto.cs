using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContactLinks;
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
        ICollection<OpenReferralHolidayScheduleDto>? holidayScheduleCollection,
        ICollection<OpenReferralContactLinkDto>? contactLinks
        )
    {
        Id = id;
        Location = location;
        HolidayScheduleCollection = holidayScheduleCollection;
        Regular_schedule = regular_schedule;
        ContactLinks = contactLinks;
    }

    public string Id { get; set; } = default!;
    public OpenReferralLocationDto Location { get; init; } = default!;
    public ICollection<OpenReferralRegularScheduleDto>? Regular_schedule { get; init; }
    public ICollection<OpenReferralHolidayScheduleDto>? HolidayScheduleCollection { get; init; }
    public ICollection<OpenReferralContactLinkDto>? ContactLinks { get; set; }
}

