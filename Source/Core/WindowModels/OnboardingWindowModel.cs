using System;
using System.Collections.Generic;

using CommunityToolkit.Mvvm.ComponentModel;

using Core.Framework.Models;
using Core.Views.Onboarding;
using Core.Windows;

namespace Core.WindowModels;

public partial class OnboardingWindowModel : WindowModelBase
{
    private List<Type> PageTypes { get; } =
    [
        typeof(OnboardingWelcomeView),
        typeof(OnboardingPreferencesView),
        typeof(MainWindow),
    ];

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanGoBack))]
    [NotifyPropertyChangedFor(nameof(CanGoNext))]
    [NotifyPropertyChangedFor(nameof(CurrentPageType))]
    private int _currentPageIndex;

    public Type CurrentPageType => (CurrentPageIndex >= 0 && CurrentPageIndex < PageTypes.Count)
        ? PageTypes[CurrentPageIndex]
        : typeof(OnboardingWelcomeView);

    public bool CanGoBack => CurrentPageIndex > 0;
    public bool CanGoNext => CurrentPageIndex < PageTypes.Count - 1;
    
    public void GoBack()
    {
        if (CanGoBack)
        {
            CurrentPageIndex--;
        }
    }

    public void GoNext()
    {
        if (CanGoNext)
        {
            CurrentPageIndex++;
        }
    }
}
