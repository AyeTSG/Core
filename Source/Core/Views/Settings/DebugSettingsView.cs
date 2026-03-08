using System.IO;

using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.VisualTree;

using Core.Extensions;
using Core.Framework.Models;
using Core.Services;
using Core.Services.Framework;
using Core.ViewModels.Settings;
using Core.Windows;

namespace Core.Views.Settings;

public partial class DebugSettingsView : ViewBase<DebugSettingsViewModel>
{
    public DebugSettingsView() : base(AppServices.Settings.Debug)
    {
        InitializeComponent();
    }

    private void OpenLogsFolder(object? sender, RoutedEventArgs e)
    {
        var folder = LogsFolder.FullName;

        if (Directory.Exists(folder))
        {
            AppService.OpenLink(folder);
        }
    }

    private void OpenStartup(object? sender, RoutedEventArgs e)
    {
        var win = new OnboardingWindow();

        if (this.GetVisualRoot() is not Window window) return;
        
        win.CenterToScreen(window);
        win.Show();
    }
    
    private void OpenGallery(object? sender, RoutedEventArgs e)
    {
        var win = new GalleryWindow();

        if (this.GetVisualRoot() is not Window window) return;
        
        win.CenterToScreen(window);
        win.Show();
    }
}
