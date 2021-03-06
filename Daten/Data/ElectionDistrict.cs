﻿using System.Collections.Generic;

namespace Daten
{
    public class ElectionDistrict
    {
        public string DistrictName { get; set; }
        public int EligibleVoters { get; set; }
        public int TotalVoters { get; set; }
        public List<Parties> PartieList { get; set; }       
    }
}
