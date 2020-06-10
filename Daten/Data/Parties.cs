using System.Collections.Generic;

namespace Daten
{
    public class Parties
    {
        public Parties(string name, int voters, int totalVoters)
        {
            Name = name;
            Voters = voters;
            Percent = (float)voters*100/(float)totalVoters;
        }

        public string Name { get; set; }
        public int Voters { get; set; }
        public float Percent { get; set; }
    }
}
 