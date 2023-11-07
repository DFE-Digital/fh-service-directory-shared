using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record HolidayScheduleDto : DtoBase
{
    public bool Closed { get; set; }
    public DateTime? OpensAt { get; set; }
    public DateTime? ClosesAt { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public long? ServiceId { get; set; }
    public long? LocationId { get; set; }
}
