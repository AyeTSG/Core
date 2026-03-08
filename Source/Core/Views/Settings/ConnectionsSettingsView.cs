using Core.Framework.Models;
using Core.Services.Framework;
using Core.ViewModels.Settings;

namespace Core.Views.Settings;

public partial class ConnectionsSettingsView : ViewBase<ConnectionsSettingsViewModel>
{
    public ConnectionsSettingsView() : base(AppServices.Settings.Connections)
    {
        InitializeComponent();
    }
}
