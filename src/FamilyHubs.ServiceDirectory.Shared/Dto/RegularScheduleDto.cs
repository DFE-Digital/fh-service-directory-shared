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

    public string Id { get; init; } = default!;
    public string Description { get; init; } = default!;
    public DateTime? OpensAt { get; init; }
    public DateTime? ClosesAt { get; init; }
    public string? ByDay { get; init; }
    public string? ByMonthDay { get; init; }
    public string? DtStart { get; init; }
    public string? Freq { get; init; }
    public string? Interval { get; init; }
    public DateTime? ValidFrom { get; init; }
    public DateTime? ValidTo { get; init; }
}
