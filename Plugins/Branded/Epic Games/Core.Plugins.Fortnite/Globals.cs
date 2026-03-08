using Core.API.UEDB.API;

namespace Core.Plugins.Fortnite;

public static class Globals
{
    public static UEDB API { get; } = new(Core.API.Globals.RestClient, "fortnite");
}
