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
    public LocationDto Location { get; set; } = default!;
    public ICollection<RegularScheduleDto>? RegularSchedules { get; set; }
    public ICollection<HolidayScheduleDto>? HolidaySchedules { get; set; }
    public ICollection<LinkContactDto>? LinkContacts { get; set; }
}

