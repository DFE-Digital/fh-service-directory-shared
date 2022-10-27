namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.ModelLink;

public class ModelLinkDto : IModelLinkDto
{
    public string Id { get; set; } = default!;
    public string LinkType { get; set; } = default!;
    public string ModelOneId { get; set; } = default!;
    public string ModelTwoId { get; set; } = default!;
}
