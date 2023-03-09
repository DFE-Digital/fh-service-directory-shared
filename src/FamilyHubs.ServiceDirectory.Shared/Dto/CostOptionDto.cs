// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record CostOptionDto
{
    public long Id { get; set; }
    public long ServiceId { get; set; }
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
    public string? Option { get; set; }
    public decimal? Amount { get; set; }
    public string? AmountDescription { get; set; }
    public ICollection<TaxonomyDto> Taxonomies { get; set; } = new List<TaxonomyDto>();
}

