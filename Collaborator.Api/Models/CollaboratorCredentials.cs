namespace Collaborator.Api.Models;

public class CollaboratorCredentials
{
    public string ApiUrl { get; init; }
    public string ApiToken { get; init; }

    public CollaboratorCredentials(string apiUrl, string apiToken)
    {
          ApiUrl = apiUrl;
        ApiToken = apiToken;
    }
}
