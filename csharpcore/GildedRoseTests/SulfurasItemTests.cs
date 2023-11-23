using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    [TestFixture]
    public class SulfurasItemTests
    {
        [Test]
        public void QualityAndSellInShouldNotChange()
        {
            var generalItem = new SulfurasItem(12, 20);
            generalItem.UpdateQuality();
            Assert.That(generalItem.Quality, Is.EqualTo(20));
            Assert.That(generalItem.SellIn, Is.EqualTo(12));
        }
    }
}
