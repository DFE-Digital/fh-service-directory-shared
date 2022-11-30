namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralHolidaySchedule;

public record OpenReferralHolidayScheduleDto : IOpenReferralHolidayScheduleDto
{
    private OpenReferralHolidayScheduleDto() { }
    public OpenReferralHolidayScheduleDto(string id, bool closed, TimeSpan? closes_at, DateTime? start_date, DateTime? end_date, TimeSpan? opens_at)
    {
        Id = id;
        Closed = closed;
        Closes_at = closes_at;
        Start_date = start_date;
        End_date = end_date;
        Opens_at = opens_at;
    }
    public string Id { get; init; } = default!;
    public bool Closed { get; set; }
    public TimeSpan? Closes_at { get; set; }
    public DateTime? Start_date { get; set; }
    public DateTime? End_date { get; set; }
    public TimeSpan? Opens_at { get; set; }
}
