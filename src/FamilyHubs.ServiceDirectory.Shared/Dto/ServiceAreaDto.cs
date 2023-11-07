using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

//We should be using this class
//Instead of using Admin Area Code
//ServiceAreaName = AdminAreaCode
public record ServiceAreaDto : ServiceDtoBase<long>
{
    public string? ServiceAreaName { get; set; }
    public string? Extent { get; set; }
    public string? Uri { get; set; }
}
