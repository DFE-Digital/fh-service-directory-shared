namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record OrganisationDetailsDto : OrganisationDto
{
    public ICollection<ServiceDto> Services { get; set; } = new List<ServiceDto>();
    public ICollection<LocationDto> Locations { get; set; } = new List<LocationDto>();
}