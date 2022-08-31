using System.ComponentModel;

namespace FamilyHubs.ServiceDirectory.Shared.Enums;

public enum ServiceDelivery : byte
{
    [Description("Not Entered")]
    NotEntered = 0,
    [Description("In Person")]
    InPerson = 1,
    [Description("Online")]
    Online = 2,
    [Description("Telephone")]
    Telephone = 3
}

