using GildedRoseKata;
using System.Collections.Generic;

namespace GildedRose.Services
{
    public class QualityUpdateService : IQualityUpdateService
    {
        public void UpdateQuality(IList<Item> items)
        {
            if (items == null || items.Count == 0) return;

            foreach (var item in items)
            {
                var itemUpdate = item as IItemUpdate;
                if (itemUpdate != null)
                {
                    itemUpdate.UpdateQuality();
                }
            }
        }
    }
}
