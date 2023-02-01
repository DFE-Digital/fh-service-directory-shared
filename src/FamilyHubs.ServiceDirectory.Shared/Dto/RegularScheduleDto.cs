namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record RegularScheduleDto
{
    private RegularScheduleDto() { }
    public RegularScheduleDto(string id, string description, DateTime? opensAt, DateTime? closesAt, string? byDay, string? byMonthDay, string? dtStart, string? freq, string? interval, DateTime? validFrom, DateTime? validTo)
    {
        Id = id;
        Description = description;
        OpensAt = opensAt;
        ClosesAt = closesAt;
        ByDay = byDay;
        ByMonthDay = byMonthDay;
        DtStart = dtStart;
        Freq = freq;
        Interval = interval;
        ValidFrom = validFrom;
        ValidTo = validTo;
    }

    public string Id { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTime? OpensAt { get; set; }
    public DateTime? ClosesAt { get; set; }
    public string? ByDay { get; set; }
    public string? ByMonthDay { get; set; }
    public string? DtStart { get; set; }
    public string? Freq { get; set; }
    public string? Interval { get; set; }
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
}
