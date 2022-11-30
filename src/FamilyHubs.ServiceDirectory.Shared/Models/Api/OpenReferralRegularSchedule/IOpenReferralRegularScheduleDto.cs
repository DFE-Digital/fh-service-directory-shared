namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralRegularSchedule;

internal interface IOpenReferralRegularScheduleDto
{
    string Id { get; init; }
    string Description { get; init; }
    TimeSpan? Opens_at { get; init; }
    TimeSpan? Closes_at { get; init; }
    string? Byday { get; init; }
    string? Bymonthday { get; init; }
    string? Dtstart { get; init; }
    string? Freq { get; init; }
    string? Interval { get; init; }
    DateTime? Valid_from { get; init; }
    DateTime? Valid_to { get; init; }
}
