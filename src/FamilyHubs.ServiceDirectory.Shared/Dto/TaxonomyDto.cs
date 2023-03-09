// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record TaxonomyDto
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public TaxonomyType TaxonomyType { get; set; }
    public long? ParentId { get; set; }
}
