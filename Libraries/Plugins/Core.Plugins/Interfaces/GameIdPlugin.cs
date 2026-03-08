using Core.Resources.Framework.Base;

namespace Core.Plugins.Interfaces;

public interface IGameIdPlugin : IGamePlugin
{
    string GameId => string.Empty;

    bool IGamePlugin.DoesInherentlyMatch(BaseProfile profile) => profile.AutoDetectedGameId == GameId;
    bool IGamePlugin.DoesCharacteristicsMatch(BaseProfile profile) => false;
}
