namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAreas;

public interface IOpenReferralServiceAreaDto
{
    string Id { get; init; }
    string Service_area { get; init; }
    string? Uri { get; init; }
}