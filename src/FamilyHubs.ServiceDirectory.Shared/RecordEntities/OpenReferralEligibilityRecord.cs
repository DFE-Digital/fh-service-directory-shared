using FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.RecordEntities;

public record OpenReferralEligibilityRecord : IOpenReferralEligibilityRecord
{
    private OpenReferralEligibilityRecord() { }
    public OpenReferralEligibilityRecord(string id, string eligibility, int maximum_age, int minimum_age)
    {
        Id = id;
        Eligibility = eligibility;
        Maximum_age = maximum_age;
        Minimum_age = minimum_age;
    }
    public string Id { get; init; } = default!;
    public string Eligibility { get; init; } = default!;
    public int Maximum_age { get; init; }
    public int Minimum_age { get; init; }
}
