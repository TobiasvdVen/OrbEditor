using OrbEditor.WPF.Tests.FlaUI.Async;

namespace OrbEditor.WPF.Tests
{
    public class AutomationDelaysProvider
    {
        public AutomationDelaysProvider()
        {
            bool isTeamCity = Environment.GetEnvironmentVariable("TEAMCITY_VERSION") != null;

            if (isTeamCity)
            {
                AutomationDelays = new NoDelays();
            }
            else
            {
                AutomationDelays = new SimulateUserDelays();
            }
        }

        public IAutomationDelays AutomationDelays { get; }
    }
}
