namespace FamilyHubs.ServiceDirectory.Shared.Models;

public class KeyVaultConfig
{
    public string KVUrl { get; set; } = default!;
    public string TenantId { get; set; } = default!;
    public string ClientId { get; set; } = default!;
    public string ClientSecretId { get; set; } = default!;
}
