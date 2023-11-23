using System;
using System.Collections.Generic;
using GildedRose.Services;
using GildedRoseKata;

namespace GildedRoseTests;

public static class TextTestFixture
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var items = new List<Item>{
            new GeneralItem ("+5 Dexterity Vest", 10,  20),
            new AgedItem(2,0),
            new ElixirItem(5,7),
            new SulfurasItem(0,80),
            new SulfurasItem(-1,80),
            new BackstageItem(15,20),
            new BackstageItem(10,49),
            new BackstageItem(5,49),
            new ConjuredItem(3,6)
        };
        IQualityUpdateService qualityUpdateService = new QualityUpdateService();
        var app = new GildedRoseKata.GildedRose(qualityUpdateService, items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}