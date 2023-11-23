using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    [TestFixture]
    public class ConjuredItemTests
    {
        [Test]
        public void QualityShouldRedcucedByTwoWhenWithInSellInDate()
        {
            var generalItem = new ConjuredItem(10, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(19));
            Assert.That(generalItem.SellIn, Is.EqualTo(9));
        }

        [Test]
        public void QualityShouldNotBeNegative()
        {
            var generalItem = new ConjuredItem(0, 1);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(0));
            Assert.That(generalItem.SellIn, Is.EqualTo(-1));
        }
    }
}
