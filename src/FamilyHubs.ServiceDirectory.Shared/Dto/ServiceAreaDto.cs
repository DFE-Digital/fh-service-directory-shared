using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

//We should be using this class
//Instead of using Admin Area Code
//ServiceAreaName = AdminAreaCode
public record ServiceAreaDto : DtoBase
{
    public long ServiceId { get; set; }
    public string? ServiceAreaName { get; set; }
    public string? Extent { get; set; }
    public string? Uri { get; set; }
}
