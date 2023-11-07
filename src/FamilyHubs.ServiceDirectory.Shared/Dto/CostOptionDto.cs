using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
#pragma warning disable CS8604
#pragma warning disable CS8607

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record CostOptionDto : ServiceDtoBase<long>
{
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
    public string? Option { get; set; }
    public decimal? Amount { get; set; }
    public string? AmountDescription { get; set; }
}
