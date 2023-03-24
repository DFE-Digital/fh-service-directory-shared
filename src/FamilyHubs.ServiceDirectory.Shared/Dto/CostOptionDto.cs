using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8604
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record CostOptionDto : ServiceDtoBase<long>
{
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
    public string? Option { get; set; }
    public decimal? Amount { get; set; }
    public string? AmountDescription { get; set; }

    public override int GetHashCode()
    {
        return
            EqualityComparer<DateTime?>.Default.GetHashCode(ValidFrom) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(ValidTo) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Option) * -1521134295 +
            EqualityComparer<decimal?>.Default.GetHashCode(Amount) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(AmountDescription) * -1521134295
            ;
    }


    public virtual bool Equals(CostOptionDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<DateTime?>.Default.Equals(ValidFrom, other.ValidFrom) &&
            EqualityComparer<DateTime?>.Default.Equals(ValidTo, other.ValidTo) &&
            EqualityComparer<string>.Default.Equals(Option, other.Option) &&
            EqualityComparer<decimal?>.Default.Equals(Amount, other.Amount) &&
            EqualityComparer<string>.Default.Equals(AmountDescription, other.AmountDescription)
            ;
    }
}

