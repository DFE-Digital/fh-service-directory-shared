namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralHolidaySchedule;

interface IOpenReferralHolidayScheduleDto
{
    string Id { get; init; }
    bool Closed { get; set; }
    DateTime? Closes_at { get; set; }
    DateTime? Start_date { get; set; }
    DateTime? End_date { get; set; }
    DateTime? Opens_at { get; set; }
}
