using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto
{
    public record ServiceAtLocationDto : DtoBase
    {
        public LocationDto Location { get; set; } = default!;
        public string? Description { get; set; }
        public ICollection<ScheduleDto> Schedules { get; set; } = new List<ScheduleDto>();
    }
}
