using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
#pragma warning disable CS8604
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record RegularScheduleDto : DtoBase
{
    public DayOfWeek? Weekday { get; set; }
    public DateTime? OpensAt { get; set; }
    public DateTime? ClosesAt { get; set; }
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
    public string? DtStart { get; set; }
    public FrequencyType Freq { get; set; }
    public string? Interval { get; set; }
    public string? ByDay { get; set; }
    public string? ByMonthDay { get; set; }
    public string? Description { get; set; }
    public long? ServiceId { get; set; }
    public long? LocationId { get; set; }

    public override int GetHashCode()
    {
        return
            EqualityComparer<Enum>.Default.GetHashCode(Weekday) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(OpensAt) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(ClosesAt) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(ValidFrom) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(ValidTo) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(DtStart) * -1521134295 +
            EqualityComparer<Enum>.Default.GetHashCode(Freq) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Interval) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(ByDay) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(ByMonthDay) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Description) * -1521134295 
            ;
    }

    public virtual bool Equals(RegularScheduleDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<Enum>.Default.Equals(Weekday, other.Weekday) && 
            EqualityComparer<DateTime?>.Default.Equals(OpensAt, other.OpensAt) && 
            EqualityComparer<DateTime?>.Default.Equals(ClosesAt, other.ClosesAt) && 
            EqualityComparer<DateTime?>.Default.Equals(ValidFrom, other.ValidFrom) && 
            EqualityComparer<DateTime?>.Default.Equals(ValidTo, other.ValidTo) && 
            EqualityComparer<string?>.Default.Equals(DtStart, other.DtStart) && 
            EqualityComparer<Enum>.Default.Equals(Freq, other.Freq) && 
            EqualityComparer<string?>.Default.Equals(Interval, other.Interval) && 
            EqualityComparer<string?>.Default.Equals(ByDay, other.ByDay) && 
            EqualityComparer<string?>.Default.Equals(ByMonthDay, other.ByMonthDay) && 
            EqualityComparer<string?>.Default.Equals(Description, other.Description)
            ;
    }
}