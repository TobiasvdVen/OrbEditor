namespace OrbEditor.WPF.Tests.FlaUI.Async
{
    internal class NoDelays : IAutomationDelays
    {
        public TimeSpan Delay => TimeSpan.Zero;
    }
}
