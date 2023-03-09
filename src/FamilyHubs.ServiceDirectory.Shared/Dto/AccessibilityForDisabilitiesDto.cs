﻿// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record AccessibilityForDisabilitiesDto
{
    public required long Id { get; set; }
    public required long LocationId { get; set; }
    public string? Accessibility { get; set; }
}