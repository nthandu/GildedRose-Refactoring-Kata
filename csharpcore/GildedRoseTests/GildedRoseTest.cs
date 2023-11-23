using System.Collections.Generic;
using GildedRose.Services;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Foo()
    {
        IQualityUpdateService qualityUpdateService = new QualityUpdateService();
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRoseKata.GildedRose(qualityUpdateService, items);
        app.UpdateQuality();
        Assert.AreEqual("foo", items[0].Name);
    }
}