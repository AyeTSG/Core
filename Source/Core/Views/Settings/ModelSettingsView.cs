using Core.Framework.Models;
using Core.Services.Framework;
using Core.ViewModels.Settings;

namespace Core.Views.Settings;

public partial class ModelSettingsView : ViewBase<ModelSettingsViewModel>
{
    public ModelSettingsView() : base(AppServices.Settings.Model)
    {
        InitializeComponent();
    }
}
