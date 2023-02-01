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
    public string AmountDescription { get; set; } = default!;
    public decimal Amount { get; set; }
    public string? LinkId { get; set; }
    public string? Option { get; set; }
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
}

