using System;
using HtmlAgilityPack;
using System.Linq;

namespace data_runner
{
    class MoneroBenchmarks
    {
        public static void Scrape()
        {
            HtmlWeb web = new HtmlWeb();  
            HtmlDocument document = web.Load("https://xmrig.com/benchmark"); 

            HtmlNode[] nodes = document.DocumentNode
                .SelectNodes("/html/body/div[1]/div/div/div[2]/table/tbody/tr/td[2]/a").ToArray();
            // /html/body/div[1]/div/div/div[2]/table/tbody/tr/td[2]/a
            
            foreach (HtmlNode item in nodes)
            {
                Console.WriteLine(item.InnerHtml);
            }
        }
    }
}