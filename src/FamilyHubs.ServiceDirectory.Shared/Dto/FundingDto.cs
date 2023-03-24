using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record FundingDto : ServiceDtoBase<long>
{
    public string? Source { get; set; }

    public override int GetHashCode()
    {
        return
            EqualityComparer<string>.Default.GetHashCode(Source) * -1521134295 
            ;
    }


    public virtual bool Equals(FundingDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(Source, other.Source)
            ;
    }
}
