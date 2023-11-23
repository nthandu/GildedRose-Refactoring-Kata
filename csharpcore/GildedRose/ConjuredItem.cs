namespace GildedRoseKata;

public class ConjuredItem : Item, IItemUpdate
{
    public ConjuredItem(int sellIn, int quality)
    {
        Name = Constants.ItemNames.Conjured;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        // "Conjured" items degrade in Quality twice as fast as normal items

        if (Quality > Constants.MinQuaity)
        {
            Quality = Quality - 1;
            if (SellIn <= 0)
            {
                Quality = Quality - 1;
            }
        }

        if (Quality < 0)
        {
            Quality = 0;
        }
        SellIn = SellIn - 1;
    }
}