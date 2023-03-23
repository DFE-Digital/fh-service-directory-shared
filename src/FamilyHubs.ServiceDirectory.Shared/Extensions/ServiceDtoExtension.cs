using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.Extensions
{
    public static class ServiceDtoExtension
    {
        //  This should only be used while only one contact can exist per service
        public static ContactDto? GetContact(this ServiceDto service)
        {
            if (!service.ServiceDeliveries.Any())
                return null;
            
            return service.Contacts.FirstOrDefault() ?? 
                   service.Locations.SelectMany(x => x.Contacts).FirstOrDefault();
        }
    }
}
