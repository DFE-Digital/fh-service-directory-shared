﻿using System.ComponentModel;

namespace FamilyHubs.ServiceDirectory.Shared.Enums;

public static class Utility
{
    public static string GetEnumDescription(Enum value)
    {
        var fi = value.GetType().GetField(value.ToString());

        if (fi != null && fi.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Any())
        {
            return attributes.First().Description;
        }

        return value.ToString();
    }
}
