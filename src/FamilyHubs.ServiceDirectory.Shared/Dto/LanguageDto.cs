using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LanguageDto : ServiceDtoBase<long>
{
    public required string Name { get; set; }
    public override int GetHashCode()
    {
        return EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295
            ;
    }

    public virtual bool Equals(LanguageDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return EqualityComparer<string>.Default.Equals(Name, other.Name)
            ;
    }
}
