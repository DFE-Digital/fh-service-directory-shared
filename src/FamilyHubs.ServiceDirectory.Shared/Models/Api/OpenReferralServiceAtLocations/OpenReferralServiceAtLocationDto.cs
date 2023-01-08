using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkContacts;
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
        ICollection<OpenReferralLinkContactDto>? linkContacts
        )
    {
        Id = id;
        Location = location;
        HolidayScheduleCollection = holidayScheduleCollection;
        Regular_schedule = regular_schedule;
        LinkContacts = linkContacts;
    }

    public string Id { get; set; } = default!;
    public OpenReferralLocationDto Location { get; init; } = default!;
    public ICollection<OpenReferralRegularScheduleDto>? Regular_schedule { get; init; }
    public ICollection<OpenReferralHolidayScheduleDto>? HolidayScheduleCollection { get; init; }
    public ICollection<OpenReferralLinkContactDto>? LinkContacts { get; set; }
}

