using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Services
{
    public interface IQualityUpdateService
    {
        void UpdateQuality(IList<Item> items);
    }
}
