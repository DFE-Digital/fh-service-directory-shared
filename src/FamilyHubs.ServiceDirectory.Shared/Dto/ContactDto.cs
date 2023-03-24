using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ContactDto : DtoBase<long>
{
    public string? Title { get; set; }
    public string? Name { get; set; }
    public required string Telephone { get; set; }
    public string? TextPhone { get; set; }
    public string? Url { get; set; }
    public string? Email { get; set; }
    public long? ServiceId { get; set; }
    public long? LocationId { get; set; }

    public override int GetHashCode()
    {
        return
            EqualityComparer<string>.Default.GetHashCode(Title) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Telephone) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(TextPhone) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Url) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Email) * -1521134295
            ;
    }


    public virtual bool Equals(ContactDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(Title, other.Title) &&
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<string>.Default.Equals(Telephone, other.Telephone) &&
            EqualityComparer<string>.Default.Equals(TextPhone, other.TextPhone) &&
            EqualityComparer<string>.Default.Equals(Url, other.Url) &&
            EqualityComparer<string>.Default.Equals(Email, other.Email)
            ;
    }
}