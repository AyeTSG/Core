global using static Core.Resources.Globals;

using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using Core.API.Models.GitHub;

namespace Core.API;

public static class Globals
{
    public static RestClient RestClient { get; } = new(
        new RestClientOptions
        {
            UserAgent = $"{APP_NAME}/{VERSION}"
        },
        configureSerialization: s => s.UseSerializer<JsonNetSerializer>());
    
    public static GitHubAPI GitHub { get; } = new(RestClient);
}
