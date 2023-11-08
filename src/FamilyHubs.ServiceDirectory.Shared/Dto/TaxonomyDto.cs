using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record TaxonomyDto : DtoBase
{
    public required string Name { get; set; }
    public TaxonomyType TaxonomyType { get; set; }
    public long? ParentId { get; set; }
}
