namespace OrbEditor.ViewModels.Design
{
    public class DesignEditorViewModel : EditorViewModel
    {
        public DesignEditorViewModel() : base(MockOrbViewModel())
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
