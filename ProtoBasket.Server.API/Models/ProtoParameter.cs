using Newtonsoft.Json;

namespace ProtoBasket.Server.API.Models
{
    public class ProtoParameter
    {
        [JsonProperty]
        public int Year { get; set; }
        [JsonProperty]
        public int ProtoNo { get; set; }
        [JsonProperty]
        public int MatchNo { get; set; }

        public int GetID() => Year * 10000 + ProtoNo * 100 + MatchNo;
    }
}
