using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class OrganisationDtoBuilder
{
    private OpenReferralOrganisationWithServicesDto _openReferralOrganisation;

    public OrganisationDtoBuilder()
    {
        _openReferralOrganisation = new OpenReferralOrganisationWithServicesDto();
    }

    public OrganisationDtoBuilder WithMainProperties(string id, OrganisationTypeDto organisationType, string adminDistrict, string? name, string? description, string? logo, string? uri, string? url)
    {
        _openReferralOrganisation.Id = id;
        _openReferralOrganisation.OrganisationType = organisationType;
        _openReferralOrganisation.AdminDistrict = adminDistrict;
        _openReferralOrganisation.Name = name;
        _openReferralOrganisation.Description = description;
        _openReferralOrganisation.Logo = logo;
        _openReferralOrganisation.Uri = uri;
        _openReferralOrganisation.Url = url;
        return this;
    }

    public OrganisationDtoBuilder WithServices(ICollection<OpenReferralServiceDto>? Services)
    {
        _openReferralOrganisation.Services = Services;
        return this;
    }

    public OpenReferralOrganisationWithServicesDto Build()
    {
        return _openReferralOrganisation;
    }
}
