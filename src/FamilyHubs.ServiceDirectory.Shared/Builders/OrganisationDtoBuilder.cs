using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class OrganisationDtoBuilder
{
    private readonly OrganisationWithServicesDto _organisation;

    public OrganisationDtoBuilder(long id, OrganisationType organisationType, string name, string description, string adminAreaCode, string? logo, string? uri, string? url)
    {
        _organisation = new OrganisationWithServicesDto
        {
            OrganisationType = organisationType,
            Id = id,
            Name = name,
            Description = description,
            AdminAreaCode = adminAreaCode,
            Logo = logo,
            Uri = uri,
            Url = url
        };
        
        if (url is not null && uri is null)
        {
            _organisation.Uri = new Uri(url).ToString();
        }
    }

    public OrganisationDtoBuilder WithAdminAreaCode(string code)
    {
        _organisation.AdminAreaCode = code;
        return this;
    }

    public OrganisationDtoBuilder WithServices(ICollection<ServiceDto> services)
    {
        _organisation.Services = services;
        return this;
    }

    public OrganisationDtoBuilder WithContact(ICollection<ContactDto> contacts)
    {
        _organisation.Contacts = contacts;
        return this;
    }

    public OrganisationDtoBuilder WithReview(ICollection<ReviewDto> reviews)
    {
        _organisation.Reviews = reviews;
        return this;
    }

    public OrganisationWithServicesDto Build()
    {
        return _organisation;
    }
}
