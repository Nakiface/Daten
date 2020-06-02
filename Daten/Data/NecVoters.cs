using System.Collections.Generic;
using System.Windows.Documents;

namespace Daten
{
    public class NecVoters
    {
        public string Name { get; set; }
        public int TotalVoters { get; set; }
        public double SecureSeat { get; set; }
        public double UnsecureSeat { get; set; }
        public List<NecVotersPatie> NecVoterPartieList { get; set; } = new List<NecVotersPatie>();
    }
}
