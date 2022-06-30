using FlaUI.Core.AutomationElements;

namespace OrbEditor.WPF.Tests.FlaUI.Async
{
    public class AsyncWindow : AsyncAutomationElement
    {
        public AsyncWindow(Window window, IAutomationDelays delayProvider) : base(window, delayProvider)
        {
            Window = window;
        }

        public Window Window { get; }
    }
}