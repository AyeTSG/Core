using System.Threading.Tasks;

using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

using Core.Windows;

namespace Core.Views.Onboarding;

public partial class OnboardingPreferencesView : UserControl
{
    public OnboardingPreferencesView()
    {
        InitializeComponent();
        
        Task.Run(async () =>
        {
#if !DEBUG
            await Task.Delay(1000);      
#endif

            await Dispatcher.UIThread.InvokeAsync(() =>
            {
                ContinueButton.IsEnabled = true;
            });
        });
    }

    private void Save(object? sender, RoutedEventArgs e)
    {
        var window = VisualRoot as OnboardingWindow;
        window!.GoNext();
    }
}
