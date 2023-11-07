using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record TaxonomyDto : DtoBase
{
    public required string Name { get; set; }
    public TaxonomyType TaxonomyType { get; set; }
    public long? ParentId { get; set; }
    public override int GetHashCode()
    {
        return
            EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 +
            EqualityComparer<Enum>.Default.GetHashCode(TaxonomyType) * -1521134295 +
            EqualityComparer<long?>.Default.GetHashCode(ParentId) * -1521134295
            ;
    }

    public virtual bool Equals(TaxonomyDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<Enum>.Default.Equals(TaxonomyType, other.TaxonomyType) &&
            EqualityComparer<long?>.Default.Equals(ParentId, other.ParentId)
            ;
    }
}
