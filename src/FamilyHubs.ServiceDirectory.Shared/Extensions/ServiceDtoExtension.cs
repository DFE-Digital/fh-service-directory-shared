using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Extensions
{
    public static class ServiceDtoExtension
    {
        //  This should only be used while only one contact can exist per service
        public static ContactDto? GetContact(this ServiceDto service)
        {
            if (service.ServiceDeliveries == null || !service.ServiceDeliveries.Any())
                return null;
            
            switch (service.ServiceDeliveries.First().Name)
            {
                case ServiceDeliveryType.Telephone:
                case ServiceDeliveryType.Online:
                    return service.LinkContacts?.First().Contact;
                case ServiceDeliveryType.InPerson:
                    return service.ServiceAtLocations?.First().LinkContacts?.First().Contact;
                case ServiceDeliveryType.NotEntered:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
