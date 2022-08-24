﻿using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLocations;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;

public interface IOpenReferralServiceAtLocationDto
{
    string Id { get; set; }
    IOpenReferralLocationDto Location { get; init; }
}