using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.Display;

public static class LocationDisplayExtensions
{
    public static string GetDisplayName(this LocationDto location)
    {
        if (!string.IsNullOrEmpty(location.Name))
        {
            return location.Name;
        }

        if (!string.IsNullOrEmpty(location.Address2))
        {
            return string.Join(", ", location.Address1, location.Address2);
        }

        return location.Address1;
    }

    public static IEnumerable<string> GetAddress(this LocationDto location)
    {
        return RemoveEmpty(
            location.Name,
            location.Address1,
            location.Address2,
            location.City,
            location.StateProvince,
            location.PostCode);
    }

    private static IEnumerable<string> RemoveEmpty(params string?[] list)
    {
        return list.Where(x => !string.IsNullOrWhiteSpace(x))!;
    }
}