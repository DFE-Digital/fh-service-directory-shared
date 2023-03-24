using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests.Comparer;

public class ReviewComparerTests : DtoComparerTestBase<ReviewDto, string>
{
    public ReviewComparerTests() : base(new ReviewDto
    {
        Id = 0,
        Title = "Test",
    }, new ReviewDto
    {
        Id = 0,
        Title = "Test",
    }, dto => dto.Title)
    {

    }
}