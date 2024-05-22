
namespace FamilyHubs.ServiceDirectory.Shared.Display;

public static class GeneralDisplayExtensions
{
    //todo: better name?
    public static string GetDisplay(this string? description)
    {
        return string.IsNullOrEmpty(description) ? "None provided" : description;
    }
}