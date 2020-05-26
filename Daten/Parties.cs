namespace Daten
{
    class Parties
    {
        public Parties(string name, int voters, int totalVoters)
        {
            Name = name;
            Voters = voters;
            Percent = voters*100/totalVoters;
        }

        public string Name { get; set; }
        public int Voters { get; set; }
        public float Percent { get; set; }
    }
}
