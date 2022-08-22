using FamilyHubs.ServiceDirectory.Shared.Entities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralReview
    {
        DateTime Date { get; }
        string? Description { get; }
        string? Score { get; }
        string Title { get; }
        string? Url { get; }
        string? Widget { get; }

        void Update(OpenReferralReview openReferralReview);
    }
}