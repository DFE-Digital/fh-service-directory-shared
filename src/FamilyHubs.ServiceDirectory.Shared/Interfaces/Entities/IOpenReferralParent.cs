using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralParent
    {
        ICollection<OpenReferralLinktaxonomycollection>? LinkTaxonomyCollection { get; init; }
        string Name { get; init; }
        ICollection<OpenReferralService_Taxonomy>? ServiceTaxonomyCollection { get; init; }
        string? Vocabulary { get; init; }
    }
}