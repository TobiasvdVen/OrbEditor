using FlaUI.UIA3;
using OrbEditor.WPF.Tests.FlaUI.Async;
using Xunit;

namespace OrbEditor.WPF.Tests
{
    public class EditorViewTests : IClassFixture<AutomationDelaysProvider>
    {
        private const string OrbEditorExePathEnvironmentVariable = "ORB_EDITOR_WPF_EXE_PATH";

        private readonly IAutomationDelays delays;

        public EditorViewTests(AutomationDelaysProvider delaysProvider)
        {
            delays = delaysProvider.AutomationDelays;
        }

        [Fact]
        public async Task WhenSliderMovedRight_OrbIncreasesInSize()
        {
            string orbEditorExePath = GetOrbEditorExePath();

            using AsyncApplication orbEditor = AsyncApplication.Launch(orbEditorExePath, arguments: null, delays);

            try
            {
                using UIA3Automation automation = new();

                AsyncWindow window = orbEditor.GetMainWindow(automation);
                AsyncAutomationElement editor = window.FindFirstChild("EditorView");

                AsyncSlider sizeSlider = editor.FindFirstChild("SizeSlider").AsSlider();
                AsyncAutomationElement orbView = editor.FindFirstChild("OrbView");

                int widthBefore = orbView.Properties.BoundingRectangle.Value.Width;

                await sizeSlider.Thumb.SlideHorizontallyAsync(64);

                int widthAfter = orbView.Properties.BoundingRectangle.Value.Width;

                Assert.True(widthAfter > widthBefore, "OrbView was not larger after moving the slider to the right.");
            }
            finally
            {
                await orbEditor.CloseAsync();
            }
        }

        private string GetOrbEditorExePath()
        {
            return Environment.GetEnvironmentVariable(OrbEditorExePathEnvironmentVariable) ?? throw new FileNotFoundException($"Unable to find environment variable specifying executable path: {OrbEditorExePathEnvironmentVariable}");
        }
    }
}
