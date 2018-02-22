

namespace EveESIClient.Models.Market
{
    public class GetRegionMarketStatisticsResponse
    {
        public string Date { get; set; }
        public long Rrder_count { get; set; }
        public long Volume { get; set; }
        public double Highest { get; set; }
        public double Average { get; set; }
        public double Lowest { get; set; }
    }
}