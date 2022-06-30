using FlaUI.Core;
using FlaUI.Core.AutomationElements;

namespace OrbEditor.WPF.Tests.FlaUI.Async
{
    public class AsyncAutomationElement
    {
        protected readonly IAutomationDelays delayProvider;

        public AsyncAutomationElement(AutomationElement automationElement, IAutomationDelays delayProvider)
        {
            AutomationElement = automationElement ?? throw new ArgumentNullException(nameof(automationElement));

            this.delayProvider = delayProvider;
        }

        public AutomationElement AutomationElement { get; }

        public FrameworkAutomationElementBase.IProperties Properties => AutomationElement.Properties;

        public AsyncAutomationElement FindFirstChild(string automationId)
        {
            AutomationElement? automationElement = AutomationElement.FindFirstChild(automationId);

            if (automationElement == null)
            {
                throw new ArgumentException($"Could not find element with automation ID: {automationId})");
            }

            return new AsyncAutomationElement(automationElement, delayProvider);
        }

        public AsyncSlider AsSlider()
        {
            return new AsyncSlider(AutomationElement.AsSlider(), delayProvider);
        }
    }
}
