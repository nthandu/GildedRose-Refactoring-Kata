using System.Diagnostics.Metrics;
using System;

namespace GildedRoseKata;
public class BackstageItem : Item, IItemUpdate
{
    public BackstageItem(int sellIn, int quality)
    {
        Name = Constants.ItemNames.Backstage;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        SellIn = SellIn - 1;

        // Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
        // Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
        // Quality drops to 0 after the concert

        if (Quality < Constants.MaxQuality)
        {
            Quality = Quality + 1;

            if (SellIn < 10)
            {
                Quality = Quality + 1;

                if (SellIn < 5)
                {
                    Quality = Quality + 1;
                }
            }
        }

        if (SellIn < Constants.MinSaleIn)
        {
            Quality = Constants.MinQuaity;
        }

        if (Quality > Constants.MaxQuality)
        {
            Quality = Constants.MaxQuality;
        }
    }
}
