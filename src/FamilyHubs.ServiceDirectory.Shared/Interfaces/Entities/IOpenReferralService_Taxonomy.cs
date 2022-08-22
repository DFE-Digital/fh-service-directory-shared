using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralService_Taxonomy
    {
        string? LinkId { get; init; }
        OpenReferralTaxonomy? Taxonomy { get; set; }
    }
}