using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public class DataUploadRowDto
{
    public int ExcelRowId { get; set; }
    public required string ServiceOwnerReferenceId { get; set; }
    public required string LocalAuthority { get; set; }
    public OrganisationType OrganisationType { get; set; }
    public string? NameOfOrganisation { get; set; }
    public required string NameOfService { get; set; }
    public required ServiceDeliveryType DeliveryMethod { get; set; }
    public string? LocationName { get; set; }
    public string? LocationDescription { get; set; }
    public required string AddressLineOne { get; set; }
    public string? AddressLineTwo { get; set; }
    public required string TownOrCity { get; set; }
    public string? County { get; set; }
    public required string Postcode { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactPhone { get; set; }
    public string? Website { get; set; }
    public string? ContactSms { get; set; }
    public string? SubCategory { get; set; }
    public string? CostInPounds { get; set; }
    public string? CostPer { get; set; }
    public string? CostDescription { get; set; }
    public string? Language { get; set; }
    public string? AgeFrom { get; set; }
    public string? AgeTo { get; set; }
    public string? OpeningHoursDescription { get; set; }
    public string? ServiceDescription { get; set; }
}