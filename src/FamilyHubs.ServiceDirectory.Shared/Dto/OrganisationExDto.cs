// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedType.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationExDto : OrganisationDto
{
    public string? Email { get; set; }
    public string? ContactName { get; set; }
    public string? ContactPhone { get; set; }
}
