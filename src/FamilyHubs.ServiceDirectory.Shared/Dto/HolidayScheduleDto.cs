namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record HolidayScheduleDto
{
    private HolidayScheduleDto() { }
    public HolidayScheduleDto(string id, bool closed, DateTime? closesAt, DateTime? startDate, DateTime? endDate, DateTime? opensAt)
    {
        Id = id;
        Closed = closed;
        ClosesAt = closesAt;
        StartDate = startDate;
        EndDate = endDate;
        OpensAt = opensAt;
    }
    public string Id { get; set; } = default!;
    public bool Closed { get; set; }
    public DateTime? ClosesAt { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? OpensAt { get; set; }
}
