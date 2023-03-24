using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

//We should be using this class
//Instead of using Admin Area Code
//ServiceAreaName = AdminAreaCode
public record ServiceAreaDto : ServiceDtoBase<long>
{
    public string? ServiceAreaName { get; set; }
    public string? Extent { get; set; }
    public string? Uri { get; set; }
    public override int GetHashCode()
    {
        return
            EqualityComparer<string?>.Default.GetHashCode(ServiceAreaName) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Extent) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Uri) * -1521134295 
            ;
    }

    public virtual bool Equals(ServiceAreaDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string?>.Default.Equals(ServiceAreaName, other.ServiceAreaName) &&
            EqualityComparer<string?>.Default.Equals(Extent, other.Extent) &&
            EqualityComparer<string?>.Default.Equals(Uri, other.Uri)
            ;
    }
}
