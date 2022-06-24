using Xunit;

namespace OrbEditor.ViewModels.Tests
{
    public class OrbViewModelTests
    {
        [Fact]
        public void GivenOrb_WhenSizeSet_RaisePropertyChanged()
        {
            OrbViewModel orbViewModel = new();

            string? propertyChanged = null;

            orbViewModel.PropertyChanged += (sender, args) =>
            {
                propertyChanged = args.PropertyName;
            };

            orbViewModel.SizePx = 200;

            Assert.Equal(nameof(orbViewModel.SizePx), propertyChanged);
        }
    }
}
