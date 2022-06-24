using Xunit;

namespace OrbEditor.ViewModels.Tests
{
    public class MainWindowViewModelTests
    {
        public const uint SizeToPixels = 200;

        [Theory]
        [InlineData(2.5f, 500)]
        [InlineData(1.0f, 200)]
        [InlineData(3.2f, 640)]
        public void WhenSizeCmChanges_UpdateOrbViewModelSizePx(float sizeCm, uint expectedSizePx)
        {
            OrbViewModel orbViewModel = new();

            MainWindowViewModel mainWindowViewModel = new(orbViewModel)
            {
                CmToPixels = SizeToPixels,
                OrbSizeCm = 0
            };

            mainWindowViewModel.OrbSizeCm = sizeCm;

            Assert.Equal(expectedSizePx, mainWindowViewModel.OrbViewModel.SizePx);
        }
    }
}
