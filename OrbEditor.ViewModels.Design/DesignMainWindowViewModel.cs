namespace OrbEditor.ViewModels.Design
{
    public class DesignMainWindowViewModel : MainWindowViewModel
    {
        public DesignMainWindowViewModel() : base(MockEditorViewModel())
        {
        }

        private static EditorViewModel MockEditorViewModel()
        {
            return new DesignEditorViewModel();
        }
    }
}
