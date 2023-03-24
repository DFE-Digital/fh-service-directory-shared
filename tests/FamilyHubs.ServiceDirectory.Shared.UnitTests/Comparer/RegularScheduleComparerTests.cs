using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class RegularScheduleComparerTests : DtoComparerTestBase<RegularScheduleDto, DateTime?>
{
    public RegularScheduleComparerTests() : base(new RegularScheduleDto
    {
        Id = 0,
        Weekday = DayOfWeek.Sunday,
        OpensAt = new DateTime(2023, 1, 1),
    }, new RegularScheduleDto
    {
        Id = 0,
        Weekday = DayOfWeek.Sunday,
        OpensAt = new DateTime(2023, 1, 1),
    }, dto => dto.OpensAt)
    {

    }
}