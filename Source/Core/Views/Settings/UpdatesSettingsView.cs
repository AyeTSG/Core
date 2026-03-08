using Core.Framework.Models;
using Core.Services.Framework;
using Core.ViewModels.Settings;

namespace Core.Views.Settings;

public partial class UpdatesSettingsView : ViewBase<UpdatesSettingsViewModel>
{
    public UpdatesSettingsView() : base(AppServices.Settings.Updates)
    {
        InitializeComponent();
    }
}
