using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEExamples
{
    internal class Movie : Media
    {
        public List<string> Cast;
        public List<string> Crew;
        public double Duration; // in seconds
        public bool AwardWinning;
        public bool InTheatres;

        // method
        public override void Play()
        {
            Console.WriteLine("Wow, I wish [favorite cast member] was in this!");
        }
    }
}
