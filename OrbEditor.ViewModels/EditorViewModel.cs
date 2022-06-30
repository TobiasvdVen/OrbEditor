using CommunityToolkit.Mvvm.ComponentModel;

namespace OrbEditor.ViewModels
{
    [INotifyPropertyChanged]
    public partial class EditorViewModel
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

        public EditorViewModel(OrbViewModel orbViewModel)
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
