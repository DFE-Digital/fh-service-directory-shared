using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.CreateUpdateDto;

public record ServiceAtLocationChangeDto
{
    public long LocationId { get; set; }
    public string? Description { get; set; }
    public ICollection<ScheduleDto> Schedules { get; set; } = new List<ScheduleDto>();
}