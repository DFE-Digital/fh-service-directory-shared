using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralOrganisations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OrganisationType;

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class OrganisationDtoBuilder
{
    private readonly OpenReferralOrganisationWithServicesDto _openReferralOrganisation;

    public OrganisationDtoBuilder()
    {
        _openReferralOrganisation = new OpenReferralOrganisationWithServicesDto();
    }

    public OrganisationDtoBuilder WithMainProperties(string id, OrganisationTypeDto organisationType, string? name, string? description, string? logo, string? uri, string? url)
    {
        _openReferralOrganisation.Id = id;
        _openReferralOrganisation.OrganisationType = organisationType;
        _openReferralOrganisation.Name = name;
        _openReferralOrganisation.Description = description;
        _openReferralOrganisation.Logo = logo;
        _openReferralOrganisation.Uri = uri;
        _openReferralOrganisation.Url = url;
        if (url != null && uri == null)
        {
            _openReferralOrganisation.Uri = new Uri(url).ToString();
        }
        return this;
    }

    public OrganisationDtoBuilder WithAdministractiveDistrictCode(string code)
    {
        _openReferralOrganisation.AdministractiveDistrictCode = code;
        return this;
    }

    public OrganisationDtoBuilder WithServices(ICollection<OpenReferralServiceDto>? services)
    {
        _openReferralOrganisation.Services = services;
        return this;
    }

    public OpenReferralOrganisationWithServicesDto Build()
    {
        return _openReferralOrganisation;
    }
}
