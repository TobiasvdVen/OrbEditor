using FlaUI.Core;

namespace OrbEditor.WPF.Tests.FlaUI.Async
{
    public class AsyncApplication : IDisposable
    {
        private readonly IAutomationDelays delayProvider;

        public AsyncApplication(Application application, IAutomationDelays delayProvider)
        {
            this.delayProvider = delayProvider;

            Application = application;
        }

        public Application Application { get; }
        public bool HasExited => Application.HasExited;

        public static AsyncApplication Launch(string executable, string? arguments = null, IAutomationDelays? delayProvider = null)
        {
            return new AsyncApplication(Application.Launch(executable, arguments), delayProvider ?? new NoDelays());
        }

        public AsyncWindow GetMainWindow(AutomationBase automation)
        {
            return new AsyncWindow(Application.GetMainWindow(automation), delayProvider);
        }

        public void Close()
        {
            Application.Close();
        }

        public async Task CloseAsync()
        {
            await Task.Delay(delayProvider.Delay);

            Close();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            ((IDisposable)Application).Dispose();
        }
    }
}
