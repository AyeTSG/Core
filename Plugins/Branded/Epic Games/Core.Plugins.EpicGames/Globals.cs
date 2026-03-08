using Core.Plugins.EpicGames.API;
using Core.Plugins.EpicGames.API.Responses;

namespace Core.Plugins.EpicGames;

public static class Globals
{
    public static EpicAuthResponse? EpicAuth;
    
    public static EpicGamesAPI API { get; } = new(Core.API.Globals.RestClient);
}
