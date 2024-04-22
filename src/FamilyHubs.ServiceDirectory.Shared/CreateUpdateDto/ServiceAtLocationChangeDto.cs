using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.CreateUpdateDto;

public record ServiceAtLocationChangeDto : DtoBase
{
    public long LocationId { get; set; }
    public string? Description { get; set; }
    public ICollection<ScheduleDto> Schedules { get; set; } = new List<ScheduleDto>();
}