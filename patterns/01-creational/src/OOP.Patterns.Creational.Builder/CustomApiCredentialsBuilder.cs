using System.Text;

namespace OOP.Patterns.Creational.Builder;

public class CustomApiCredentialsBuilder : ICredentialsBuilder
{
    private readonly StringBuilder stringBuilder = new();

    public string Build()
    {
        return stringBuilder.ToString();
    }

    public ICredentialsBuilder WithLogin(string login)
    {
        stringBuilder.AppendLine("login: " + login);

        return this;
    }

    public ICredentialsBuilder WithPassord(string password)
    {
        stringBuilder.AppendLine("password: " + password);

        return this;
    }

    public ICredentialsBuilder WithPhoneNumber(string phoneNumber)
    {
        stringBuilder.AppendLine("phoneNumber: " + phoneNumber);

        return this;
    }
}
