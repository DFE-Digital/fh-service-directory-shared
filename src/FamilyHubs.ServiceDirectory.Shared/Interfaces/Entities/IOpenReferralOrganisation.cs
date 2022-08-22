using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralOrganisation
    {
        string? Description { get; }
        string? Logo { get; }
        string Name { get; }
        ICollection<OpenReferralReview>? Reviews { get; set; }
        ICollection<OpenReferralService>? Services { get; set; }
        string? Uri { get; }
        string? Url { get; }

        void Update(IOpenReferralOrganisation openReferralOpenReferralOrganisation);
    }
}