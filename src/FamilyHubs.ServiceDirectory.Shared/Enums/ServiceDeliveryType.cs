using System.ComponentModel;

namespace FamilyHubs.ServiceDirectory.Shared.Enums;

public enum ServiceDeliveryType : byte
{
    [Description("Not Set")]
    NotSet    = 0,
    [Description("In Person")]
    InPerson  = 1,
    [Description("Online")]
    Online    = 2,
    [Description("Telephone")]
    Telephone = 3
}