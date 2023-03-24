using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ReviewDto : DtoBase<long>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public string? Score { get; set; }
    public string? Url { get; set; }
    public string? Widget { get; set; }
    public long? ServiceId { get; set; }
    public long? OrganisationId { get; set; }
    public override int GetHashCode()
    {
        return
            EqualityComparer<string?>.Default.GetHashCode(Title) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Description) * -1521134295 +
            EqualityComparer<DateTime>.Default.GetHashCode(Date) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Score) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Url) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Widget) * -1521134295 
            ;
    }

    public virtual bool Equals(ReviewDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string?>.Default.Equals(Title, other.Title) &&
            EqualityComparer<string?>.Default.Equals(Description, other.Description) &&
            EqualityComparer<DateTime>.Default.Equals(Date, other.Date) &&
            EqualityComparer<string?>.Default.Equals(Score, other.Score) &&
            EqualityComparer<string?>.Default.Equals(Url, other.Url) &&
            EqualityComparer<string?>.Default.Equals(Widget, other.Widget)
            ;
    }
}