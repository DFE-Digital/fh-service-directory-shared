// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record HolidayScheduleDto
{
    public required long Id { get; set; }
    public long? ServiceId { get; set; }
    public long? LocationId { get; set; }
    public bool Closed { get; set; }
    public DateTime? OpensAt { get; set; }
    public DateTime? ClosesAt { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
}
