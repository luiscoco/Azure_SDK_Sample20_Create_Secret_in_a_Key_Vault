# Azure SDK  Sample20 Create Secret in a Key Vault

## 1. Cretate an Azure KeyVault

Login in Azure portal and navigate into the KeyVault service.

Create a new KeyVault pressing the "Create key vault" button

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/91601346-b558-47e4-8c42-0c2c2a8497f5)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/610e487c-1005-42d2-b1ea-5798844db865)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/11e0ae4e-8f97-4476-b39a-b8f689967764)

IMPORTANT NOTE: pay attention go to the "**Access configuration**" tab, and select the option "**Azure role-based access control (recommended)**"

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/1a05e5c1-3e66-4cdc-8e85-9cc5a1bae0aa)


## 2. Grant permission to the KeyVault ResourceGroup to 





## Input the source code

```csharp
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
```


