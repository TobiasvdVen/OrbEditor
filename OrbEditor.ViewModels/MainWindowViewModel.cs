namespace OrbEditor.ViewModels
{
    public partial class MainWindowViewModel
    {
        public MainWindowViewModel(EditorViewModel editorViewModel)
        {
            EditorViewModel = editorViewModel;
        }

        public EditorViewModel EditorViewModel { get; }
    }
}
