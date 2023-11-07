using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable MemberCanBePrivate.Global
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record HolidayScheduleDto : DtoBase
{
    public bool Closed { get; set; }
    public DateTime? OpensAt { get; set; }
    public DateTime? ClosesAt { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public long? ServiceId { get; set; }
    public long? LocationId { get; set; }

    public override int GetHashCode()
    {
        return
            EqualityComparer<bool>.Default.GetHashCode(Closed) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(OpensAt) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(ClosesAt) * -1521134295 +
            EqualityComparer<DateTime>.Default.GetHashCode(StartDate) * -1521134295 +
            EqualityComparer<DateTime>.Default.GetHashCode(EndDate) * -1521134295
            ;
    }

    public virtual bool Equals(HolidayScheduleDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<bool>.Default.Equals(Closed, other.Closed) &&
            EqualityComparer<DateTime?>.Default.Equals(OpensAt, other.OpensAt) &&
            EqualityComparer<DateTime?>.Default.Equals(ClosesAt, other.ClosesAt) &&
            EqualityComparer<DateTime>.Default.Equals(StartDate, other.StartDate) &&
            EqualityComparer<DateTime>.Default.Equals(EndDate, other.EndDate)
            ;
    }
}
