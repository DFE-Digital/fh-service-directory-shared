using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class OrganisationDtoBuilder
{
    private readonly OrganisationWithServicesDto _organisation;

    public OrganisationDtoBuilder()
    {
        _organisation = new OrganisationWithServicesDto();
    }

    public OrganisationDtoBuilder WithMainProperties(string id, OrganisationTypeDto organisationType, string? name, string? description, string? logo, string? uri, string? url)
    {
        _organisation.Id = id;
        _organisation.OrganisationType = organisationType;
        _organisation.Name = name;
        _organisation.Description = description;
        _organisation.Logo = logo;
        _organisation.Uri = uri;
        _organisation.Url = url;
        if (url != null && uri == null)
        {
            _organisation.Uri = new Uri(url).ToString();
        }
        return this;
    }

    public OrganisationDtoBuilder WithAdminAreaCode(string code)
    {
        _organisation.AdminAreaCode = code;
        return this;
    }

    public OrganisationDtoBuilder WithServices(ICollection<ServiceDto>? services)
    {
        _organisation.Services = services;
        return this;
    }

    public OrganisationDtoBuilder WithLinkContact(ICollection<LinkContactDto>? linkContacts)
    {
        _organisation.LinkContacts = linkContacts;
        return this;
    }

    public OrganisationWithServicesDto Build()
    {
        return _organisation;
    }
}
