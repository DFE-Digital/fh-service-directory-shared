﻿using System.ComponentModel.DataAnnotations;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.Referrals;

public class ReferralDto
{
    private ReferralDto() { }
    public ReferralDto(string id, string organisationId, string serviceId, string serviceName, string serviceDescription, string serviceAsJson, string referrer, string fullName, string hasSpecialNeeds, string? email, string? phone, string? text, string reasonForSupport, string? reasonForRejection, ICollection<ReferralStatusDto> status)
    {
        Id = id;
        OrganisationId = organisationId;
        ServiceId = serviceId;
        ServiceName = serviceName;
        ServiceDescription = serviceDescription;
        ServiceAsJson = serviceAsJson;
        Referrer = referrer;
        FullName = fullName;
        HasSpecialNeeds = hasSpecialNeeds;
        Email = email;
        Phone = phone;
        Text = text;
        ReasonForSupport = reasonForSupport;
        ReasonForRejection = reasonForRejection;
        Status = status;
    }

    public string Id { get; set; } = default!;
    public string OrganisationId { get; set; } = default!;
    public string ServiceId { get; set; } = default!;
    public string ServiceName { get; set; } = default!;
    public string ServiceDescription { get; set; } = default!;
    public string ServiceAsJson { get; set; } = default!;
    public string Referrer { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public string HasSpecialNeeds { get; set; } = default!;
    [MaxLength(255)]
    public string? Email { get; set; } = default!;
    [Phone]
    [MaxLength(50)]
    public string? Phone { get; set; } = default!;
    [Phone]
    [MaxLength(50)]
    public string? Text { get; set; } = default!;
    [MaxLength(1000)]
    public string ReasonForSupport { get; set; } = default!;
    [MaxLength(1000)]
    public string? ReasonForRejection { get; set; } = default!;
    public virtual ICollection<ReferralStatusDto> Status { get; set; } = default!;
}
