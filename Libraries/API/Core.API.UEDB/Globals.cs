namespace Core.API.UEDB;

public static class Globals
{
    /* Use mappings from FN */
    public static API.UEDB API { get; } = new(Core.API.Globals.RestClient, "fortnite");
}
