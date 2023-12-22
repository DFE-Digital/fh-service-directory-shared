using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.ReferenceData;

namespace FamilyHubs.ServiceDirectory.Shared.Factories;

public static class LanguageDtoFactory
{
    public static LanguageDto Create(string code)
    {
        return new LanguageDto
        {
            Name = Languages.CodeToName[code],
            Code = code
        };
    }
}