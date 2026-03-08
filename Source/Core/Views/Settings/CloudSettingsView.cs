using Core.Framework.Models;
using Core.Services.Framework;
using Core.ViewModels.Settings;

namespace Core.Views.Settings;

public partial class CloudSettingsView : ViewBase<CloudSettingsViewModel>
{
    public CloudSettingsView() : base(AppServices.Settings.Cloud)
    {
        InitializeComponent();
    }
}
