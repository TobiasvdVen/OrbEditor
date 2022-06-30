using FlaUI.Core.AutomationElements;

namespace OrbEditor.WPF.Tests.FlaUI.Async
{
    public class AsyncSlider : AsyncAutomationElement
    {
        public AsyncSlider(Slider slider, IAutomationDelays delayProvider) : base(slider, delayProvider)
        {
            Slider = slider;
        }

        public Slider Slider { get; }

        public AsyncThumb Thumb => new(Slider.Thumb, delayProvider);
    }
}
