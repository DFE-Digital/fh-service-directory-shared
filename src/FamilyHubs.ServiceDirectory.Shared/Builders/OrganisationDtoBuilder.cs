using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class OrganisationDtoBuilder
{
    private IOpenReferralOrganisationWithServicesDto _openReferralOrganisation;

    public OrganisationDtoBuilder()
    {
        _openReferralOrganisation = new OpenReferralOrganisationWithServicesDto();
    }

    public OrganisationDtoBuilder WithMainProperties(string id, string? name, string? description, string? logo, string? uri, string? url)
    {
        _openReferralOrganisation.Id = id;
        _openReferralOrganisation.Name = name;
        _openReferralOrganisation.Description = description;
        _openReferralOrganisation.Logo = logo;
        _openReferralOrganisation.Uri = uri;
        _openReferralOrganisation.Url = url;
        return this;
    }

    public OrganisationDtoBuilder WithServices(ICollection<IOpenReferralServiceDto>? Services)
    {
        _openReferralOrganisation.Services = Services;
        return this;
    }

    public IOpenReferralOrganisationWithServicesDto Build()
    {
        return _openReferralOrganisation;
    }
}
