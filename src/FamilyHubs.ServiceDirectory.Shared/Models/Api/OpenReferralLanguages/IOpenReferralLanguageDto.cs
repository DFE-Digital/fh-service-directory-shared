namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralLanguage;

public interface IOpenReferralLanguageDto
{
    string Id { get; set; }
    string Language { get; init; }
    bool Equals(object? obj);
    bool Equals(OpenReferralLanguageDto? other);
    int GetHashCode();
    string ToString();
}