using CommunityToolkit.Mvvm.ComponentModel;

namespace OrbEditor.ViewModels
{
    [INotifyPropertyChanged]
    public partial class OrbViewModel
    {
        public const uint DefaultSizePx = 100;

        [ObservableProperty]
        private uint sizePx;

        public OrbViewModel()
        {
            sizePx = DefaultSizePx;
        }
    }
}
