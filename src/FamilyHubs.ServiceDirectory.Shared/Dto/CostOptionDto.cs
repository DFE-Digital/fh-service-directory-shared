namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public class CostOptionDto
{
    public CostOptionDto() { }
    public CostOptionDto(
        string id,
        string amountDescription,
        decimal amount,
        string? linkId,
        string? option,
        DateTime? validFrom,
        DateTime? validTo
    )
    {
        Id = id;
        AmountDescription = amountDescription;
        Amount = amount;
        LinkId = linkId;
        Option = option;
        ValidFrom = validFrom;
        ValidTo = validTo;
    }
    public string Id { get; set; } = default!;
    public string AmountDescription { get; init; } = default!;
    public decimal Amount { get; init; }
    public string? LinkId { get; init; }
    public string? Option { get; init; }
    public DateTime? ValidFrom { get; init; }
    public DateTime? ValidTo { get; init; }
}

