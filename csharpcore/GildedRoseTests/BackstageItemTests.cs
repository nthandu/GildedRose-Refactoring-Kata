using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    [TestFixture]
    public class BackstageItemTests
    {
        [Test]
        public void QualityShouldIncrementedByOneWhenWithInSellInDate()
        {
            var generalItem = new BackstageItem(12, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(21));
            Assert.That(generalItem.SellIn, Is.EqualTo(11));
        }

        [Test]
        public void QualityShouldBeIncrementedByTwoWhenBeyondSellInDaysLessThanTen()
        {
            var generalItem = new BackstageItem(9, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(22));
            Assert.That(generalItem.SellIn, Is.EqualTo(8));
        }

        [Test]
        public void QualityShouldBeIncrementedByThreeWhenBeyondSellInDaysLessThanFive()
        {
            var generalItem = new BackstageItem(5, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(23));
            Assert.That(generalItem.SellIn, Is.EqualTo(4));
        }

        [Test]
        public void QualityShouldResetWhenSellInIsZeroOrLess()
        {
            var generalItem = new BackstageItem(0, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(0));
            Assert.That(generalItem.SellIn, Is.EqualTo(-1));
        }
    }
}
