namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralHoliday_Schedule
    {
        bool Closed { get; init; }
        DateTime? Closes_at { get; init; }
        DateTime? End_date { get; init; }
        DateTime? Opens_at { get; init; }
        DateTime? Start_date { get; init; }
    }
}