namespace GildedRoseKata;

public class GeneralItem : Item, IItemUpdate
{
    public GeneralItem(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public void UpdateQuality()
    {
        if (Quality > 0)
        {
            Quality = Quality - 1;
        }
        if (Quality > 0 && SellIn <= 0)
        {
            Quality = Quality - 1;
        }
        SellIn = SellIn - 1;
    }
}
