namespace OrbEditor.ViewModels.Design
{
    public class DesignMainWindowViewModel : MainWindowViewModel
    {
        public DesignMainWindowViewModel() : base(MockOrbViewModel())
        {
        }

        private static OrbViewModel MockOrbViewModel()
        {
            return new OrbViewModel()
            {
                SizePx = 256
            };
        }
    }
}
