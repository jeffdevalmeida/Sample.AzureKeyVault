using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

string uri = "https://samplevault.vault.azure.net";
SecretClient client = new SecretClient(new Uri(uri), new DefaultAzureCredential(true));

string secretName = "auto-secret";
string secretValue = "Valor super secreto";

await client.SetSecretAsync(secretName, secretValue);
