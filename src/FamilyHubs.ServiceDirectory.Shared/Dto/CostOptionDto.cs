using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record CostOptionDto : DtoBase
{
    public long ServiceId { get; set; }
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
    public string? Option { get; set; }
    public decimal? Amount { get; set; }
    public string? AmountDescription { get; set; }
}
