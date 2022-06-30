using FlaUI.Core.AutomationElements;

namespace OrbEditor.WPF.Tests.FlaUI.Async
{
    public class AsyncThumb : AsyncAutomationElement
    {
        public AsyncThumb(Thumb thumb, IAutomationDelays delayProvider) : base(thumb, delayProvider)
        {
            Thumb = thumb;
        }

        public Thumb Thumb { get; }

        public async Task SlideHorizontallyAsync(int distance)
        {
            await Task.Delay(delayProvider.Delay);

            Thumb.SlideHorizontally(distance);
        }
    }
}
