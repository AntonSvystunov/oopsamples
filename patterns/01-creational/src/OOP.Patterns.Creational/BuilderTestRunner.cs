using OOP.Patterns.Creational.Builder;

namespace OOP.Patterns.Creational;

public static class BuilderTestRunner
{
    private static void PrintCredentials<TBuilder>(string login, string password)
        where TBuilder : ICredentialsBuilder, new()
    {
        var builder = new TBuilder();

        if (login.StartsWith("+"))
        {
            builder.WithPhoneNumber(login);
        }
        else
        {
            builder.WithLogin(login);
        }

        builder.WithPassord(password);

        Console.WriteLine(builder.Build());
    }

    public static void Run()
    {
        Console.WriteLine("Testing builder implementation...");

        PrintCredentials<CustomApiCredentialsBuilder>("anton", "123");
        PrintCredentials<CustomApiCredentialsBuilder>("+12232341231232", "123");

        PrintCredentials<CustomExternalCredentialsBuilder>("anton", "123");
        PrintCredentials<CustomExternalCredentialsBuilder>("+12232341231232", "123");

        Console.WriteLine();
    }
}
