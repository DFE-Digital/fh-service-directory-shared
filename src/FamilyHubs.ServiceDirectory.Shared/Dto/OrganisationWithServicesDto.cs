namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationWithServicesDto : OrganisationDto
{
    public ICollection<ServiceDto> Services { get; set; } = new List<ServiceDto>();
}