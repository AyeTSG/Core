using CUE4Parse.UE4.Versions;
using Core.Resources.Framework.Base;

namespace Core.Plugins.Interfaces;

public interface IGameVersionUpdatePlugin : IGameIdPlugin
{
    EGame TargetVersion => EGame.GAME_UE5_LATEST;

    public void Update(BaseProfile Profile)
    {
        Profile.Version = TargetVersion;
    }
}
