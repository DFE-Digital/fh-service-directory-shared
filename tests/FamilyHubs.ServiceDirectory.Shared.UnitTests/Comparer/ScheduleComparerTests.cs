using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class ScheduleComparerTests : DtoComparerTestBase<ScheduleDto, DateTime?>
{
    public ScheduleComparerTests() : base(new ScheduleDto
    {
        Id = 0,
        Weekday = DayOfWeek.Sunday,
        OpensAt = new DateTime(2023, 1, 1),
    }, new ScheduleDto
    {
        Id = 0,
        Weekday = DayOfWeek.Sunday,
        OpensAt = new DateTime(2023, 1, 1),
    }, dto => dto.OpensAt)
    {

    }
}