using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace FamilyHubs.ServiceDirectory.Shared.Extensions;

public static class AzureKeyVaultExtensions
{
    public static void AddAzureKeyVault(this WebApplicationBuilder builder)
    {
        string kvURL = builder.Configuration.GetValue<string>("KeyVaultConfig:KVUrl");
        string tenantId = builder.Configuration.GetValue<string>("KeyVaultConfig:TenantId");
        string clientId = builder.Configuration.GetValue<string>("KeyVaultConfig:ClientId");
        string clientSecretId = builder.Configuration.GetValue<string>("KeyVaultConfig:ClientSecretId");

        var credential = new ClientSecretCredential(tenantId, clientId, clientSecretId);
        var client = new SecretClient(new Uri(kvURL), credential);
        builder.Configuration.AddAzureKeyVault(client, new AzureKeyVaultConfigurationOptions());
    }
}
