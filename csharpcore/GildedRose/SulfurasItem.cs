namespace GildedRoseKata;

public class SulfurasItem : Item, IItemUpdate
{
    public SulfurasItem(int sellIn, int quality)
    {
        Name = Constants.ItemNames.Sulfuras;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        // "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
        Quality = Quality;
        SellIn = SellIn;
    }
}
