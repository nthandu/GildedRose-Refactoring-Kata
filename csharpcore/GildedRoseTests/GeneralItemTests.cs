using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    [TestFixture]
    public class GeneralItemTests
    {
        [Test]
        public void QualityShouldRedcucedByOneWhenWithInSellInDate()
        {
            var generalItem = new GeneralItem("+5 Dexterity Vest", 10, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(19));
            Assert.That(generalItem.SellIn, Is.EqualTo(9));
        }

        [Test]
        public void QualityShouldRedcucedByTwoWhenBeyondSellInDate()
        {
            var generalItem = new GeneralItem("+5 Dexterity Vest", 0, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(18));
            Assert.That(generalItem.SellIn, Is.EqualTo(-1));
        }

        [Test]
        public void QualityShouldNotBeNegative()
        {
            var generalItem = new GeneralItem("+5 Dexterity Vest", 0, 0);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(0));
            Assert.That(generalItem.SellIn, Is.EqualTo(-1));
        }
    }
}
