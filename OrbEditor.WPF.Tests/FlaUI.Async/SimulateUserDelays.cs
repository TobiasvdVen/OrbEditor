namespace OrbEditor.WPF.Tests.FlaUI.Async
{
    internal class SimulateUserDelays : IAutomationDelays
    {
        public TimeSpan Delay => TimeSpan.FromSeconds(1);
    }
}
