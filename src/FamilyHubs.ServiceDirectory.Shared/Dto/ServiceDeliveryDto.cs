using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable PropertyCanBeMadeInitOnly.Global

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDeliveryDto : ServiceDtoBase<long>
{
    //todo: why is the delivery type property called Name?
    public ServiceDeliveryType Name { get; set; }
    public override int GetHashCode()
    {
        return
            EqualityComparer<Enum>.Default.GetHashCode(Name) * -1521134295
            ;
    }

    public virtual bool Equals(ServiceDeliveryDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<Enum>.Default.Equals(Name, other.Name)
            ;
    }
}
