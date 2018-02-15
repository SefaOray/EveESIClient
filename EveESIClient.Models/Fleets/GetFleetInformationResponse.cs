

namespace EveESIClient.Models.Fleets
{
    public class GetFleetInformationResponse
    {
        /// <summary>
        /// Fleet MOTD in CCP flavoured HTML
        /// </summary>
        public string Motd { get; set; }

        /// <summary>
        /// Is free-move enabled
        /// </summary>
        public bool Is_free_move { get; set; }

        /// <summary>
        /// Does the fleet have an active fleet advertisement
        /// </summary>
        public bool Is_registered { get; set; }

        /// <summary>
        /// Is EVE Voice enabled
        /// </summary>
        public bool Is_voice_enabled { get; set; }
    }
}
