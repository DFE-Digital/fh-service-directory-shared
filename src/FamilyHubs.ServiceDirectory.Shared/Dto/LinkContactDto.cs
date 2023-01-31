﻿namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public class LinkContactDto
{
    public LinkContactDto(string? id, string linkType, string linkId, ContactDto contact)
    {
        Id = id;
        LinkType = linkType;
        LinkId = linkId;
        Contact = contact;
    }

    public string? Id { get; set; }
    public string LinkType { get; init; }
    public string LinkId { get; set; }
    public ContactDto Contact { get; init; }
}