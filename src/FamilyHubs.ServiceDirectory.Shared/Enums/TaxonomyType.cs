using System.ComponentModel;

namespace FamilyHubs.ServiceDirectory.Shared.Enums;

public enum TaxonomyType : byte
{
    [Description("Not Set")]
    NotSet = 0,
    [Description("Service Category")]
    ServiceCategory = 1,
    [Description("Location Type")]
    LocationType = 2,
}