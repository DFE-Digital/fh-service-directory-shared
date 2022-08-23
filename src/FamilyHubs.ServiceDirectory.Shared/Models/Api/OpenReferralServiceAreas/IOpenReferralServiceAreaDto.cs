namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceArea;

public interface IOpenReferralServiceAreaDto
{
    string? Extent { get; init; }
    string Id { get; init; }
    string Service_area { get; init; }
    string? Uri { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralServiceAreaDto? other);
    int GetHashCode();
    string ToString();
}