using System;
using System.IO;
using Core.Resources.Framework.Base;

namespace Core.Resources.Migration;

public static class AppDataMigration
{
    private const string PreviousName = "vj0";

    public static void Apply()
    {
        MigrateDirectory(PreviousName, Globals.CODENAME);
        MigrateDirectory(Path.Combine(Globals.CODENAME, "Profiles"), Path.Combine(Globals.CODENAME, ".profiles"));
    }
    
    public static void MigrateDirectory(string oldRelativePath, string newRelativePath)
    {
        var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        var oldPath = Path.Combine(appData, oldRelativePath);
        var newPath = Path.Combine(appData, newRelativePath);

        if (!Directory.Exists(oldPath) || Directory.Exists(newPath))
        {
            return;
        }

        try
        {
            Directory.Move(oldPath, newPath);
        }
        catch
        {
            /* Fallback if move across volumes fails */
            CopyDirectory(oldPath, newPath);
            Directory.Delete(oldPath, true);
        }
    }

    public static void ApplyToProfile(BaseProfile profile)
    {
        var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        var oldPath = Path.Combine(appData, PreviousName);
        var newPath = Path.Combine(appData, Globals.CODENAME);

        var path = profile.MappingsContainer.Path;

        if (!string.IsNullOrEmpty(path) && path.StartsWith(oldPath, StringComparison.OrdinalIgnoreCase))
        {
            profile.MappingsContainer.Path = Path.Combine(newPath, path.Substring(oldPath.Length).TrimStart('\\'));
        }
    }

    private static void CopyDirectory(string source, string destination)
    {
        Directory.CreateDirectory(destination);

        foreach (var file in Directory.GetFiles(source))
        {
            var dest = Path.Combine(destination, Path.GetFileName(file));
            File.Copy(file, dest, true);
        }

        foreach (var dir in Directory.GetDirectories(source))
        {
            var dest = Path.Combine(destination, Path.GetFileName(dir));
            CopyDirectory(dir, dest);
        }
    }
}