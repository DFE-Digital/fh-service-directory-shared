using System.ComponentModel;

namespace FamilyHubs.ServiceDirectory.Shared.Enums;

public enum AttendingType : byte
{
    [Description("In Person")]
    InPerson,
    [Description("Online")]
    Online,
    [Description("Telephone")]
    Telephone
}