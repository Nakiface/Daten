using System;
using System.Collections.Generic;
using System.Linq;

namespace Daten.GUI
{
    public class NecVotersLogic
    {
        private List<ElectionDistrict> DistrictList { get; set; }
        private List<PollingStation> StationList { get; set; }
        private double MinProcentage = 0.443;
        private double MaxProcentage = 0.658;
        public NecVotersLogic(List<ElectionDistrict> districtList, List<PollingStation> stationList)
        {
            this.DistrictList = districtList;
            this.StationList = stationList;
        }

        public NecVoters CreateInfoFromDistrict(string districtName)
        {
            var district =
                DistrictList.Select(x => (ElectionDistrict)x.GetType().GetProperty(districtName).GetValue(x)).First();
            NecVoters necVoters = new NecVoters();

            necVoters.Name = district.DistrictName;
            necVoters.TotalVoters = district.TotalVoters;
            necVoters.UnsecureSeat = district.TotalVoters * (MinProcentage / 100);
            necVoters.SecureSeat = district.TotalVoters * (MaxProcentage / 100);

            foreach (var partie in district.PartieList)
            {
                NecVotersPatie necVotersPatie = new NecVotersPatie();
                necVotersPatie.Name = partie.Name;
                necVotersPatie.TotalVoters = partie.Voters;
                necVotersPatie.Difference = Convert.ToInt32(partie.Voters - necVoters.SecureSeat);
                necVoters.NecVoterPartieList.Add(necVotersPatie);
            }
            
            return necVoters;
        }

    }
}
