using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralTaxonomy
    {
        ICollection<OpenReferralLinktaxonomycollection>? LinkTaxonomyCollection { get; init; }
        string Name { get; init; }
        string? Parent { get; init; }
        string? Vocabulary { get; init; }
    }
}