using Core.Framework.Models;
using Core.Services.Framework;
using Core.ViewModels.Settings;

namespace Core.Views.Settings;

public partial class ApplicationSettingsView : ViewBase<ApplicationSettingsViewModel>
{
    public ApplicationSettingsView() : base(AppServices.Settings.Application)
    {
        InitializeComponent();
    }
}
