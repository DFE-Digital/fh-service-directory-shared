namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceAtLocationDto
{
    public ServiceAtLocationDto() { }
    public ServiceAtLocationDto(
        string id,
        LocationDto location,
        ICollection<RegularScheduleDto>? regularSchedules,
        ICollection<HolidayScheduleDto>? holidaySchedules, 
        ICollection<LinkContactDto>? linkContacts)
    {
        Id = id;
        Location = location;
        HolidaySchedules = holidaySchedules;
        RegularSchedules = regularSchedules;
        LinkContacts = linkContacts;
    }

    public string Id { get; set; } = default!;
    public LocationDto Location { get; init; } = default!;
    public ICollection<RegularScheduleDto>? RegularSchedules { get; init; }
    public ICollection<HolidayScheduleDto>? HolidaySchedules { get; init; }
    public ICollection<LinkContactDto>? LinkContacts { get; set; }
}

