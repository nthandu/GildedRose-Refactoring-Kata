using GildedRose.Services;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;
    private readonly IQualityUpdateService _qualityUpdateService;

    public GildedRose(IQualityUpdateService qualityUpdateService, IList<Item> items)
    {   
        _qualityUpdateService = qualityUpdateService;
        _items = items;
    }

    public void UpdateQuality()
    {
        _qualityUpdateService.UpdateQuality(_items);
    }
}