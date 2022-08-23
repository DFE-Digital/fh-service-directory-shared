namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralEligibility;

public interface IOpenReferralEligibilityDto
{
    string Eligibility { get; init; }
    string Id { get; init; }
    int Maximum_age { get; init; }
    int Minimum_age { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralEligibilityDto? other);
    int GetHashCode();
    string ToString();
}