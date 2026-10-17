namespace Friendzone.Core.Email;

public class Endpoint
{
    public string Host { get; private set; }
    public int Port { get; private set; }

    public Endpoint(string host, int port)
    {
        if (string.IsNullOrWhiteSpace(host) ||
            Uri.CheckHostName(host) == UriHostNameType.Unknown)
        {
            throw new ArgumentException("Host is not a valid domain.");
        }

        if (port <= 0 || port > 65535)
        {
            throw new ArgumentException("Port must be a positive integer between 1 and 65535.");
        }

        Host = host;
        Port = port;
    }
}
