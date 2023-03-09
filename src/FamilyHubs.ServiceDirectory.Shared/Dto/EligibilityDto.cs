// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record EligibilityDto
{
    public long Id { get; set; }
    public required long ServiceId { get; set; }
    public EligibilityType EligibilityType { get; set; }
    public required int MaximumAge { get; set; }
    public required int MinimumAge { get; set; }
    public ICollection<TaxonomyDto> Taxonomies { get; set; } = new List<TaxonomyDto>();
}