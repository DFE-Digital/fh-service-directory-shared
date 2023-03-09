// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

//We should be using this class
//Instead of using Admin Area Code
//ServiceAreaName = AdminAreaCode
public record ServiceAreaDto
{
    public long Id { get; set; }
    public required long ServiceId { get; set; }
    public string? ServiceAreaName { get; set; }
    public string? Extent { get; set; }
    public string? Uri { get; set; }
    public ICollection<TaxonomyDto> Taxonomies { get; set; } = new List<TaxonomyDto>();
}
