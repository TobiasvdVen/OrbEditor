using CommunityToolkit.Mvvm.ComponentModel;

namespace OrbEditor.ViewModels
{
    [INotifyPropertyChanged]
    public partial class MainWindowViewModel
    {
        public const string DefaultTitle = "Title";
        public const float DefaultOrbSizeCm = 2.5f;
        public const uint DefaultCmToPixels = 100;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private float orbSizeCm;

        [ObservableProperty]
        private uint cmToPixels;

        public MainWindowViewModel(OrbViewModel orbViewModel)
        {
            OrbViewModel = orbViewModel;

            title = DefaultTitle;
            orbSizeCm = DefaultOrbSizeCm;
            cmToPixels = DefaultCmToPixels;
        }

        public OrbViewModel OrbViewModel { get; }

        partial void OnOrbSizeCmChanged(float value)
        {
            OrbViewModel.SizePx = (uint)(value * cmToPixels);
        }
    }
}
