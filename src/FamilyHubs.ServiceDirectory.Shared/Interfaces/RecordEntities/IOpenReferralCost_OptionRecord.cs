namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralCost_OptionRecord
    {
        decimal Amount { get; init; }
        string Amount_description { get; init; }
        string Id { get; set; }
        string? LinkId { get; init; }
        string? Option { get; init; }
        DateTime? Valid_from { get; init; }
        DateTime? Valid_to { get; init; }
    }
}