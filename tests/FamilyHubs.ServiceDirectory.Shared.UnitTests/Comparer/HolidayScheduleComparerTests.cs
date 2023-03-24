using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class HolidayScheduleComparerTests : DtoComparerTestBase<HolidayScheduleDto, DateTime>
{
    public HolidayScheduleComparerTests() : base(new HolidayScheduleDto
    {
        Id = 0,
        ServiceId = 0,
        StartDate = new DateTime(2023, 1, 1),
        EndDate = new DateTime(2023, 1, 1),
    }, new HolidayScheduleDto
    {
        Id = 0,
        ServiceId = 0,
        StartDate = new DateTime(2023, 1, 1),
        EndDate = new DateTime(2023, 1, 1),
    }, dto => dto.StartDate)
    {

    }
}