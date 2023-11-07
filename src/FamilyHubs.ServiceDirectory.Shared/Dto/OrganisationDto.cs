using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8604
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationDto : DtoBase
{
    public required OrganisationType OrganisationType { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string AdminAreaCode { get; set; }
    public long? AssociatedOrganisationId { get; set; }
    public string? Logo { get; set; }
    public string? Uri { get; set; }
    public string? Url { get; set; }

    
    public override int GetHashCode()
    {
        return
            EqualityComparer<Enum>.Default.GetHashCode(OrganisationType) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Description) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(AdminAreaCode) * -1521134295 +
            EqualityComparer<long?>.Default.GetHashCode(AssociatedOrganisationId) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Logo) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Uri) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Url) * -1521134295 
            ;
    }

    public virtual bool Equals(OrganisationDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<Enum>.Default.Equals(OrganisationType, other.OrganisationType) &&
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(Description, other.Description) &&
            EqualityComparer<string>.Default.Equals(AdminAreaCode, other.AdminAreaCode) &&
            EqualityComparer<long?>.Default.Equals(AssociatedOrganisationId, other.AssociatedOrganisationId) &&
            EqualityComparer<string>.Default.Equals(Logo, other.Logo) &&
            EqualityComparer<string>.Default.Equals(Uri, other.Uri) &&
            EqualityComparer<string>.Default.Equals(Url, other.Url)
            ;
    }
}