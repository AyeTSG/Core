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
    }

    private void Save(object? sender, RoutedEventArgs e)
    {
        var window = VisualRoot as OnboardingWindow;
        window!.GoNext();
    }
}
