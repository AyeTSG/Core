using CommunityToolkit.Mvvm.ComponentModel;

using Core.Framework.Models;
using Core.Models.Profiles;

namespace Core.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    [ObservableProperty]
    private Profile? currentProfile = new();
}
