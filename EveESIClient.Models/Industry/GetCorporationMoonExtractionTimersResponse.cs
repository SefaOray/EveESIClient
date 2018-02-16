using System;

namespace EveESIClient.Models.Industry
{
    public class GetCorporationMoonExtractionTimersResponse
    {
        public long Structure_id { get; set; }
        public int Moon_id { get; set; }
        public DateTime Extraction_start_time { get; set; }
        public DateTime Chunk_arrival_time { get; set; }
        public DateTime Natural_decay_time { get; set; }
    }
}
