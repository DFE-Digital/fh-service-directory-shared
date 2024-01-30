using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.Display;

public static class LocationDisplayExtensions
{
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