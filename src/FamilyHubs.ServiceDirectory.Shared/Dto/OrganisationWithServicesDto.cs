// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationWithServicesDto : OrganisationDto
{
    public ICollection<ServiceDto> Services { get; set; } = new List<ServiceDto>();
    public ICollection<ReviewDto> Reviews { get; set; } = new List<ReviewDto>();
}