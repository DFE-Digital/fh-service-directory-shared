﻿using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceTaxonomys;

public interface IOpenReferralServiceTaxonomyDto
{
    string Id { get; set; }
    IOpenReferralTaxonomyDto? Taxonomy { get; init; }
}