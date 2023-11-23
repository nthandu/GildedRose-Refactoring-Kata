using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    public class AgedItemTests
    {
        [Test]
        public void QualityShouldGoUpAsSellInGetsReduced()
        {
            var agedItem = new AgedItem(3, 20);
            agedItem.UpdateQuality();
            Assert.That(agedItem.Quality, Is.EqualTo(21));
            Assert.That(agedItem.SellIn, Is.EqualTo(2));
        }

        [Test]
        public void QualityShouldNotExceedMaxQuality()
        {
            var agedItem = new AgedItem(3, 50);
            agedItem.UpdateQuality();
            Assert.That(agedItem.Quality, Is.EqualTo(50));
            Assert.That(agedItem.SellIn, Is.EqualTo(2));
        }
    }
}
