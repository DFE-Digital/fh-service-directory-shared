using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralTaxonomy;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceTaxonomy;

public interface IOpenReferralServiceTaxonomyDto
{
    string Id { get; set; }
    OpenReferralTaxonomyDto? Taxonomy { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralServiceTaxonomyDto? other);
    int GetHashCode();
    string ToString();
}