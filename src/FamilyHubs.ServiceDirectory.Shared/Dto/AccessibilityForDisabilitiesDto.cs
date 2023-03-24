using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record AccessibilityForDisabilitiesDto : LocationDtoBase<long>
{
    public string? Accessibility { get; set; }

    public override int GetHashCode()
    {
        return EqualityComparer<string>.Default.GetHashCode(Accessibility ?? string.Empty) * -1521134295
            ;
    }

    public virtual bool Equals(AccessibilityForDisabilitiesDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return EqualityComparer<string>.Default.Equals(Accessibility, other.Accessibility)
            ;
    }
}