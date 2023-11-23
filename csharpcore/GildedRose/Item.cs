using System.Runtime.CompilerServices;

namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}

public interface IItemUpdate
{
    void UpdateQuality();
}
