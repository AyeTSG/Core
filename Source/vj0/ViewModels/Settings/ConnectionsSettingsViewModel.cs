using CommunityToolkit.Mvvm.ComponentModel;

using vj0.Framework.Models;

namespace vj0.ViewModels.Settings;

public partial class ConnectionsSettingsViewModel : ViewModelBase
{
    [ObservableProperty] private bool _useDiscordRichPresence = true;
    [ObservableProperty] private bool _syncFModel = false;

    partial void OnUseDiscordRichPresenceChanged(bool value)
    {
        if (value)
        {
            Discord.Initialize();
        }
        else
        {
            Discord.Deinitialize();
        }
    }
}
