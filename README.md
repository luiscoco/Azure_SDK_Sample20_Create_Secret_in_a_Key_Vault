# Azure SDK  Sample20 Create Secret in a Key Vault

https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/keyvault/Azure.Security.KeyVault.Secrets

## 1. Cretate an Azure KeyVault

Login in Azure portal and navigate into the KeyVault service.

Create a new KeyVault pressing the "Create key vault" button

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/91601346-b558-47e4-8c42-0c2c2a8497f5)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/610e487c-1005-42d2-b1ea-5798844db865)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/11e0ae4e-8f97-4476-b39a-b8f689967764)

IMPORTANT NOTE: pay attention go to the "**Access configuration**" tab, and select the option "**Azure role-based access control (recommended)**"

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/1a05e5c1-3e66-4cdc-8e85-9cc5a1bae0aa)

## 2. Grant permission to the KeyVault ResourceGroup to 

Navigate to the Azure ResourceGroup where the Azure KeyVault was created

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/e75c266a-3f4b-4fcf-971c-342c41e891f8)

Grant permssion to the ResourceGroup as KeyVault Administrator 

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/20cc896e-6cb9-494e-b857-fd7a8fe42c11)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/5160a99a-5a00-45b1-b06e-afe700e5372a)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/1eb08593-23ae-43db-9c31-24d0f5632195)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/a146bda0-501f-4c34-a2a8-f255a269528f)

![image](https://github.com/luiscoco/Azure_SDK_Sample20_Create_Secret_in_a_Key_Vault/assets/32194879/4e097128-f331-46e7-b60f-582dae2867f7)

## 3. Input the C# console application source code

```csharp
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

// Create a secret client using the DefaultAzureCredential
var client = new SecretClient(new Uri("https://myNewVault2000.vault.azure.net/"), new DefaultAzureCredential());

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


