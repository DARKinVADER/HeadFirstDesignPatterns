using Decorator.Decorables;

using FluentAssertions;

namespace Decorator.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HouseBlend_ShouldReturn_CorrectDescription()
        {
            // Arrange
            // Act
            HouseBlend houseBlend = new();
            // Assert
            houseBlend.GetDescription().Should().Be("House Blend");
        }

        [Test]
        public void Cost_ShouldReturn_HouseBlendPrice()
        {
            // Arrange
            // Act
            HouseBlend houseBlend = new();
            // Assert
            houseBlend.Cost().Should().Be(0.89);
        }
    }
}
