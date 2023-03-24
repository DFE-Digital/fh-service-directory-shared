using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class TaxonomyComparerTests : DtoComparerTestBase<TaxonomyDto, string>
{
    public TaxonomyComparerTests() : base(new TaxonomyDto
    {
        Id = 0,
        Name = "Test",
        TaxonomyType = TaxonomyType.ServiceCategory,
        ParentId = 1
    }, new TaxonomyDto
    {
        Id = 0,
        Name = "Test",
        TaxonomyType = TaxonomyType.ServiceCategory,
        ParentId = 1
    }, dto => dto.Name)
    {

    }
}