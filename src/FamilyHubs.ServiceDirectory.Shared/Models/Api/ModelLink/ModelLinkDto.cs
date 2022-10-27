namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.ModelLink;

public class ModelLinkDto : IModelLinkDto
{
    private ModelLinkDto() { }
    public ModelLinkDto(string id, string linkType, string modelOneId, string modelTwoId)
    {
        Id = id;
        LinkType = linkType;
        ModelOneId = modelOneId;
        ModelTwoId = modelTwoId;
    }

    public string Id { get; set; } = default!;
    public string LinkType { get; set; } = default!;
    public string ModelOneId { get; set; } = default!;
    public string ModelTwoId { get; set; } = default!;
}
