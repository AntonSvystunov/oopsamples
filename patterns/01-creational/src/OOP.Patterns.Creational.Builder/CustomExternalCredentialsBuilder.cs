using System.Security.Cryptography;
using System.Text;

namespace OOP.Patterns.Creational.Builder;

public class CustomExternalCredentialsBuilder : ICredentialsBuilder
{
    private string? clientId;

    private string? clientSecret;

    public string Build()
    {
        return $"{clientId}---{clientSecret}";
    }

    public ICredentialsBuilder WithLogin(string login)
    {
        clientId = "lgn:" + login;

        return this;
    }

    public ICredentialsBuilder WithPassord(string password)
    {
        using var hashAlgorithm = SHA256.Create();

        clientSecret = Encoding.UTF8.GetString(hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(password)));

        return this;
    }

    public ICredentialsBuilder WithPhoneNumber(string phoneNumber)
    {
        clientId = "p:" + phoneNumber.Replace("+", "%");

        return this;
    }
}
