using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace FamilyHubs.ServiceDirectory.Shared.Extensions;

public static class AzureKeyVaultExtensions
{
    public static (bool isOk, string errorMessage) AddAzureKeyVault(this WebApplicationBuilder builder)
    {
        try
        {
            string kvURL = builder.Configuration.GetValue<string>("KeyVaultConfig:KVUrl");
            string tenantId = builder.Configuration.GetValue<string>("KeyVaultConfig:TenantId");
            string clientId = builder.Configuration.GetValue<string>("KeyVaultConfig:ClientId");
            string clientSecretId = builder.Configuration.GetValue<string>("KeyVaultConfig:ClientSecretId");

            if (string.IsNullOrEmpty(kvURL))
            {
                return (false, "Key Vault URL is empty");
            }

            if (string.IsNullOrEmpty(tenantId))
            {
                return (false, "Key Vault tenantId is empty");
            }
            
            if (string.IsNullOrEmpty(clientId))
            {
                return (false, "Key Vault clientId is empty");
            }
            
            if (string.IsNullOrEmpty(clientSecretId))
            {
                return (false, "Key Vault clientSecretId is empty");
            }

            var credential = new ClientSecretCredential(tenantId, clientId, clientSecretId);
            var client = new SecretClient(new Uri(kvURL), credential);
            builder.Configuration.AddAzureKeyVault(client, new AzureKeyVaultConfigurationOptions());

            return(true, string.Empty);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }
}
