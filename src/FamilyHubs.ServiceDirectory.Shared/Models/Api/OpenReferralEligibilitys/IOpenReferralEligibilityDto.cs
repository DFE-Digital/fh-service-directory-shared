namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralEligibilitys;

public interface IOpenReferralEligibilityDto
{
    string Eligibility { get; init; }
    string Id { get; init; }
    int Maximum_age { get; init; }
    int Minimum_age { get; init; }
}