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
                DistrictList.Where(x => x.DistrictName == districtName).First();
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

        internal NecVoters CreateInfoFromStation(string stationName)
        {
            var station =
                StationList.Where(x => x.Address == stationName).First();
            NecVoters necVoters = new NecVoters();

            necVoters.Name = station.Address;
            necVoters.TotalVoters = station.Voters;
            necVoters.UnsecureSeat = station.Voters * (MinProcentage / 100);
            necVoters.SecureSeat = station.Voters * (MaxProcentage / 100);
            necVoters.NecVoterPartieList = new List<NecVotersPatie>()
            {
                AddPartieToList("SPD", station, necVoters.SecureSeat),
                AddPartieToList("CDU", station, necVoters.SecureSeat),
                AddPartieToList("Gruene", station, necVoters.SecureSeat),
                AddPartieToList("DieLinke", station, necVoters.SecureSeat),
                AddPartieToList("AfD", station, necVoters.SecureSeat),
                AddPartieToList("Piraten", station, necVoters.SecureSeat),
                AddPartieToList("FDP", station, necVoters.SecureSeat),
                AddPartieToList("Tierschutzpartei", station, necVoters.SecureSeat),
                AddPartieToList("DiePartei", station, necVoters.SecureSeat),
                AddPartieToList("NPD", station, necVoters.SecureSeat),
                AddPartieToList("Familie", station, necVoters.SecureSeat),
                AddPartieToList("Volksabstimmung", station, necVoters.SecureSeat),
                AddPartieToList("OeDP", station, necVoters.SecureSeat),
                AddPartieToList("FreieWaehler", station, necVoters.SecureSeat),
                AddPartieToList("DKP", station, necVoters.SecureSeat),
                AddPartieToList("MLPD", station, necVoters.SecureSeat),
                AddPartieToList("SGP", station, necVoters.SecureSeat),
                AddPartieToList("BP", station, necVoters.SecureSeat),
                AddPartieToList("TierschutzHier", station, necVoters.SecureSeat),
                AddPartieToList("Tierschutzallianz", station, necVoters.SecureSeat),
                AddPartieToList("BuendnisC", station, necVoters.SecureSeat),
                AddPartieToList("BIG", station, necVoters.SecureSeat),
                AddPartieToList("BGE", station, necVoters.SecureSeat),
                AddPartieToList("DieDirekte", station, necVoters.SecureSeat),
                AddPartieToList("DieM25", station, necVoters.SecureSeat),
                AddPartieToList("IIIWeg", station, necVoters.SecureSeat),
                AddPartieToList("DieGrauen", station, necVoters.SecureSeat),
                AddPartieToList("DieRechte", station, necVoters.SecureSeat),
                AddPartieToList("DieVioletten", station, necVoters.SecureSeat),
                AddPartieToList("Liebe", station, necVoters.SecureSeat),
                AddPartieToList("DieFrauen", station, necVoters.SecureSeat),
                AddPartieToList("GrauePanther", station, necVoters.SecureSeat),
                AddPartieToList("LKR", station, necVoters.SecureSeat),
                AddPartieToList("MeschlicheWelt", station, necVoters.SecureSeat),
                AddPartieToList("NL", station, necVoters.SecureSeat),
                AddPartieToList("OekoLinX", station, necVoters.SecureSeat),
                AddPartieToList("DieHumanisten", station, necVoters.SecureSeat),
                AddPartieToList("ParteiFuerTiere", station, necVoters.SecureSeat),
                AddPartieToList("Gesundheitsforschung", station, necVoters.SecureSeat),
                AddPartieToList("Volt", station, necVoters.SecureSeat)
                };
            return necVoters;
        }

        private NecVotersPatie AddPartieToList(string partieName, PollingStation station, double secureSeat)
        {
            NecVotersPatie necVotersPatie = new NecVotersPatie();
            necVotersPatie.Name = partieName;
            necVotersPatie.TotalVoters = Convert.ToInt32(station.GetType().GetProperty(partieName).GetValue(station));
            necVotersPatie.Difference = necVotersPatie.TotalVoters - Convert.ToInt32(secureSeat);
            return necVotersPatie;
        }
    }
}
