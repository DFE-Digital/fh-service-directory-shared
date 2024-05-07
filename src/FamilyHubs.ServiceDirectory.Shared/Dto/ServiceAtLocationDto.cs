using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto
{
    public record ServiceAtLocationDto : DtoBase
    {
        public long LocationId { get; set; }
        public string? Description { get; set; }
        public ICollection<ScheduleDto> Schedules { get; set; } = new List<ScheduleDto>();
    }
}
