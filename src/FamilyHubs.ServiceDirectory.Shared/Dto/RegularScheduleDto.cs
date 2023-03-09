// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global

using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record RegularScheduleDto
{
    public long Id { get; set; }
    public long? ServiceId { get; set; }
    public long? LocationId { get; set; }
    public DayOfWeek Weekday { get; set; }
    public DateTime? OpensAt { get; set; }
    public DateTime? ClosesAt { get; set; }
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
    public string? DtStart { get; set; }
    public FrequencyType Freq { get; set; }
    public string? Interval { get; set; }
    public string? ByDay { get; set; }
    public string? ByMonthDay { get; set; }
    public string? Description { get; set; }
}