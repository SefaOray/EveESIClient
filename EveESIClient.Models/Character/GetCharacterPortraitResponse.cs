using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Models.Character
{
    public class GetCharacterPortraitResponse
    {
        public string Px64x64 { get; set; }
        public string Px128x128 { get; set; }
        public string Px256x256 { get; set; }
        public string Px512x512 { get; set; }
    }
}