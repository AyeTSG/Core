using CommunityToolkit.Mvvm.ComponentModel;

using Core.Framework.Models;
using Core.Models;
using Core.Models.Profiles;
using Core.Resources.Framework.Base;
using Core.Resources.Utilities;

namespace Core.ViewModels.Profiles.Framework;

public partial class ProfileViewModelBase : ViewModelBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(AutoDetectedGameToOpacity))]
    [NotifyPropertyChangedFor(nameof(LastUsed))]
    [NotifyPropertyChangedFor(nameof(IsUncompletedProfile))]
    [NotifyPropertyChangedFor(nameof(IsRunning))]
    private Profile? _profile;

    public virtual void UpdateProfileProperties()
    {
        OnPropertyChanged(nameof(LastUsed));
        OnPropertyChanged(nameof(IsUncompletedProfile));
        OnPropertyChanged(nameof(IsRunning));
    }

    protected ProfileViewModelBase()
    {
        Profile = new Profile();
    }
    
    /* Metadata ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
    public double AutoDetectedGameToOpacity => Profile!.IsAutoDetected ? 0.5 : 1.0;
    public bool? IsRunning => Profile?.Status.State == EProfileStatus.Active;
    
    public string LastUsed => Profile!.Display.LastUsed.HasValue
        ? TimeUtilities.GetRelativeTime(Profile.Display.LastUsed.Value, RelativeTimeClock.Now)
        : "Never";
    
    public bool IsUncompletedProfile => Profile is null || Profile.Status.State == EProfileStatus.Uncompleted;
    
    /* Splash ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
    public new virtual void Initialize()
    {
    }
}
