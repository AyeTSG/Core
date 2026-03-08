using Core.Framework.Models;
using Core.Services.Framework;
using Core.ViewModels.Settings;

namespace Core.Views.Settings;

public partial class SerializationSettingsView : ViewBase<SerializationSettingsViewModel>
{
    public SerializationSettingsView() : base(AppServices.Settings.Serialization)
    {
        InitializeComponent();
    }
}
