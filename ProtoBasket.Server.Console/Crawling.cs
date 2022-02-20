using ProtoBasket.Server.Crawler.Model;
using ProtoBasket.Server.Crawler.Service;

namespace ProtoBasket.Server.Console
{
    public static class Crawling
    {
        public static void PrintProto(int year, int no)
        {
            var url = new ProtoURL(year, no);
            var proto = url.Create();

            System.Console.WriteLine($"프로토 {url.ProtoNo}회차");

            foreach (var match in proto.Matches)
                System.Console.WriteLine(match.ToString());

            System.Console.ReadLine();
        }
    }
}
