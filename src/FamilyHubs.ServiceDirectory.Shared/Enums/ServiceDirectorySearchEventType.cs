namespace FamilyHubs.ServiceDirectory.Shared.Enums;

public enum ServiceDirectorySearchEventType : short
{
    /// <summary>
    /// Describes an initial, unfiltered search by a user.
    /// </summary>
    ServiceDirectoryInitialSearch = 1,

    /// <summary>
    /// Describes a filtered search by a user.
    /// </summary>
    ServiceDirectorySearchFilter = 2
}
