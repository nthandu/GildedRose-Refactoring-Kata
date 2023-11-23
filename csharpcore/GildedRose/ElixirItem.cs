namespace GildedRoseKata;

public class ElixirItem : Item, IItemUpdate
{
    public ElixirItem(int sellIn, int quality)
    {
        Name = Constants.ItemNames.Elixir;
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
