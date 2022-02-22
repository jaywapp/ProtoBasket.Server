using ProtoBasket.Server.Crawler.Service;

namespace ProtoBasket.Server.Console
{
    public static class Crawling
    {
        public static void PrintProto(int year)
        {
            PrintProto(year, CrawlingManager.CrawlProtoNo());
        }

        public static void PrintProto(int year, int protoNo)
        {
            var proto = CrawlingManager.Crawl(year, protoNo);

            System.Console.WriteLine($"프로토 {protoNo}회차");

            foreach (var match in proto.Matches)
                System.Console.WriteLine(match.ToString());

            System.Console.ReadLine();
        }

        public static void PrintMatch(int year, int protoNo, int matchNo)
        {
            var match = CrawlingManager.Crawl(year, protoNo, matchNo);
            
            System.Console.WriteLine(match.ToString());
            System.Console.ReadLine();
        }
    }
}
