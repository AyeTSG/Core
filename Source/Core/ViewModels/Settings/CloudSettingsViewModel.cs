using CommunityToolkit.Mvvm.ComponentModel;

using Core.Framework.Models;
using Core.Services.Framework;

namespace Core.ViewModels.Settings;

public partial class CloudSettingsViewModel : ViewModelBase
{
    [ObservableProperty] private bool _runHostedAPI = true;
    
    partial void OnRunHostedAPIChanged(bool value)
    {
        if (value)
        {
            AppServices.Cloud.Initialize();
        }
        else
        {
            AppServices.Cloud.Stop();
        }
        
        MainWM.UpdateAPIServiceEnabled();
    }
}
