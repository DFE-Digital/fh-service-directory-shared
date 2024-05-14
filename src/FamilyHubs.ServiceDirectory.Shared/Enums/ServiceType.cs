namespace FamilyHubs.ServiceDirectory.Shared.Enums;

public enum ServiceType
{
    /// <summary>
    /// Unset. May mean 'None' or 'Both'
    /// </summary>
    NotSet             = 0,
    
    /// <summary>
    /// Relates to the 'Connect' application.
    /// </summary>
    InformationSharing = 1,
    
    /// <summary>
    /// Relates to the 'Find' application.
    /// </summary>
    FamilyExperience   = 2
}