using System;
using data_runner;

namespace grid_scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var MoneroBenchmarks = new MoneroBenchmarks();
            MoneroBenchmarks.Scrape();
        }
    }
}
