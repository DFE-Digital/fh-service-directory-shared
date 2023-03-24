using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NonReadonlyMemberInGetHashCode

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record EligibilityDto : ServiceDtoBase<long>
{
    public EligibilityType EligibilityType { get; set; }
    public required int MaximumAge { get; set; }
    public required int MinimumAge { get; set; }

    public override int GetHashCode()
    {
        return
            EqualityComparer<Enum>.Default.GetHashCode(EligibilityType) * -1521134295 +
            EqualityComparer<int>.Default.GetHashCode(MaximumAge) * -1521134295 +
            EqualityComparer<int>.Default.GetHashCode(MinimumAge) * -1521134295
            ;
    }


    public virtual bool Equals(EligibilityDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<Enum>.Default.Equals(EligibilityType, other.EligibilityType) &&
            EqualityComparer<int>.Default.Equals(MaximumAge, other.MaximumAge) &&
            EqualityComparer<int>.Default.Equals(MinimumAge, other.MinimumAge)
            ;
    }
}