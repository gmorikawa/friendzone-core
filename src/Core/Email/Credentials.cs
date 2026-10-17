namespace Friendzone.Core.Email;

public class Credentials
{
    public string Username { get; private set; }
    public string Password { get; private set; }

    public Credentials(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentException("Username cannot be null or empty.");
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Password cannot be null or empty.");
        }

        Username = username;
        Password = password;
    }
}
