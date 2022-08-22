using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralEligibility
    {
        string Eligibility { get; init; }
        string? LinkId { get; init; }
        int Maximum_age { get; init; }
        int Minimum_age { get; init; }
        ICollection<OpenReferralTaxonomy>? Taxonomys { get; init; }
    }
}