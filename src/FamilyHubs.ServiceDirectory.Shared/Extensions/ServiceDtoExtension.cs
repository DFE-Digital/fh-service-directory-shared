using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Extensions
{
    public static class ServiceDtoExtension
    {
        //  This should only be used while only one contact can exist per service
        public static ContactDto? GetContact(this ServiceDto service)
        {
            if (!service.ServiceDeliveries.Any())
                return null;
            
            switch (service.ServiceDeliveries.First().Name)
            {
                case ServiceDeliveryType.Telephone:
                case ServiceDeliveryType.Online:
                    return service.Contacts.FirstOrDefault();
                case ServiceDeliveryType.InPerson:
                    return service.Locations.FirstOrDefault()?.Contacts.FirstOrDefault();
                case ServiceDeliveryType.NotSet:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
