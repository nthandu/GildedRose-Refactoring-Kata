namespace GildedRoseKata;

public class AgedItem : Item, IItemUpdate
{
    public AgedItem(int sellIn, int quality)
    {
        Name = Constants.ItemNames.AgedBrie;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        SellIn = SellIn - 1;
        // "Aged Brie" actually increases in Quality the older it gets
        if (Quality < Constants.MaxQuality)
        {
            if(SellIn < Constants.MinSaleIn)
            {
                Quality = Quality + 2;
            }
            else
            {
                Quality = Quality + 1;
            }
        }
        if(Quality > Constants.MaxQuality)
        {
            Quality = Constants.MaxQuality;
        }
    }
}
