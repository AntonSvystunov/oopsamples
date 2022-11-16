namespace OOP.Patterns.Creational.Builder
{
    public interface ICredentialsBuilder
    {
        string Build();

        ICredentialsBuilder WithLogin(string login);

        ICredentialsBuilder WithPassord(string password);

        ICredentialsBuilder WithPhoneNumber(string phoneNumber);
    }
}