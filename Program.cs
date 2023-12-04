using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

// Create a secret client using the DefaultAzureCredential
var client = new SecretClient(new Uri("https://myNewVault1974.vault.azure.net/"), new DefaultAzureCredential());

try
{
    KeyVaultSecret secret = client.SetSecret("mysecret1", "Luiscoco123456789");
    // Retrieve a secret using the secret client.
    secret = client.GetSecret("mysecret1");
    Console.WriteLine(secret.Value);
}
catch (AuthenticationFailedException e)
{
    Console.WriteLine($"Authentication Failed. {e.Message}");
}

