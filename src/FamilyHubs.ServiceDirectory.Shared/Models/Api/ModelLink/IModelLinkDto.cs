namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.ModelLink
{
    public interface IModelLinkDto
    {
        string Id { get; set; }
        string LinkType { get; set; }
        string ModelOneId { get; set; }
        string ModelTwoId { get; set; }
    }
}