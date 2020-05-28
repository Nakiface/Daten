using System.Collections.Generic;
using System.Linq;

namespace Daten
{
    class MappingObject
    {
        public List<PollingStation> StationList { get; set; }
        public MappingObject(List<PollingStation> stationList)
        {
            this.StationList = stationList;
        }
        private List<Parties> CreatePartyList(IGrouping<string, PollingStation> cl)
        {
            var partieList = new List<Parties>()
                    {
                        new Parties("SPD", cl.Sum(x => x.SPD), cl.Sum(x => x.Voters)),
                        new Parties("CDU", cl.Sum(x => x.CDU), cl.Sum(x => x.Voters)),
                        new Parties("Grüne", cl.Sum(x => x.Gruene), cl.Sum(x => x.Voters)),
                        new Parties("Die Linke", cl.Sum(x => x.DieLinke), cl.Sum(x => x.Voters)),
                        new Parties("AfD", cl.Sum(x => x.AfD), cl.Sum(x => x.Voters)),
                        new Parties("Piraten", cl.Sum(x => x.Piraten), cl.Sum(x => x.Voters)),
                        new Parties("FDP", cl.Sum(x => x.FDP), cl.Sum(x => x.Voters)),
                        new Parties("Tierschutzpartei", cl.Sum(x => x.Tierschutzpartei), cl.Sum(x => x.Voters)),
                        new Parties("Die Partei", cl.Sum(x => x.DiePartei), cl.Sum(x => x.Voters)),
                        new Parties("NPD", cl.Sum(x => x.NPD), cl.Sum(x => x.Voters)),
                        new Parties("Familie", cl.Sum(x => x.Familie), cl.Sum(x => x.Voters)),
                        new Parties("Volksabstimmung", cl.Sum(x => x.Volksabstimmung), cl.Sum(x => x.Voters)),
                        new Parties("ÖDP", cl.Sum(x => x.OeDP), cl.Sum(x => x.Voters)),
                        new Parties("Freie Wähler", cl.Sum(x => x.FreieWaehler), cl.Sum(x => x.Voters)),
                        new Parties("DKP", cl.Sum(x => x.DKP), cl.Sum(x => x.Voters)),
                        new Parties("MLPD", cl.Sum(x => x.MLPD), cl.Sum(x => x.Voters)),
                        new Parties("SGP", cl.Sum(x => x.SGP), cl.Sum(x => x.Voters)),
                        new Parties("BP", cl.Sum(x => x.BP), cl.Sum(x => x.Voters)),
                        new Parties("Tierschutz hier!", cl.Sum(x => x.TierschutzHier), cl.Sum(x => x.Voters)),
                        new Parties("Tierschutzallianz", cl.Sum(x => x.Tierschutzallianz), cl.Sum(x => x.Voters)),
                        new Parties("Bündnis C", cl.Sum(x => x.BuendnisC), cl.Sum(x => x.Voters)),
                        new Parties("BIG", cl.Sum(x => x.BIG), cl.Sum(x => x.Voters)),
                        new Parties("BGE", cl.Sum(x => x.BGE), cl.Sum(x => x.Voters)),
                        new Parties("Die Direkte!", cl.Sum(x => x.DieDirekte), cl.Sum(x => x.Voters)),
                        new Parties("DiEM25", cl.Sum(x => x.DieM25), cl.Sum(x => x.Voters)),
                        new Parties("III. Weg", cl.Sum(x => x.IIIWeg), cl.Sum(x => x.Voters)),
                        new Parties("Die Grauen", cl.Sum(x => x.DieGrauen), cl.Sum(x => x.Voters)),
                        new Parties("Die Rechte", cl.Sum(x => x.DieRechte), cl.Sum(x => x.Voters)),
                        new Parties("Die Violetten", cl.Sum(x => x.DieVioletten), cl.Sum(x => x.Voters)),
                        new Parties("Liebe", cl.Sum(x => x.Liebe), cl.Sum(x => x.Voters)),
                        new Parties("Die Frauen", cl.Sum(x => x.DieFrauen), cl.Sum(x => x.Voters)),
                        new Parties("Graue Panther", cl.Sum(x => x.GrauePanther), cl.Sum(x => x.Voters)),
                        new Parties("LKR", cl.Sum(x => x.LKR), cl.Sum(x => x.Voters)),
                        new Parties("Menschliche Welt", cl.Sum(x => x.MeschlicheWelt), cl.Sum(x => x.Voters)),
                        new Parties("NL", cl.Sum(x => x.NL), cl.Sum(x => x.Voters)),
                        new Parties("ÖkoLinX", cl.Sum(x => x.OekoLinX), cl.Sum(x => x.Voters)),
                        new Parties("Die Humanisten", cl.Sum(x => x.DieHumanisten), cl.Sum(x => x.Voters)),
                        new Parties("Partei für die Tiere", cl.Sum(x => x.ParteiFuerTiere), cl.Sum(x => x.Voters)),
                        new Parties("Gesundheitsforschung", cl.Sum(x => x.Gesundheitsforschung), cl.Sum(x => x.Voters)),
                        new Parties("Volt", cl.Sum(x => x.Volt), cl.Sum(x => x.Voters))
                    };
            return partieList;
        }
        public List<ElectionDistrict> GetDistrictList()
        {
            List<ElectionDistrict> result = new List<ElectionDistrict>();
            result.Add
                (
                StationList
                .GroupBy(l => l.VoteFor)
                .Select(cl => new ElectionDistrict
                {
                    DistrictName = "Berlin",
                    EligibleVoters = cl.Sum(x => x.EligibleVoters),
                    TotalVoters = cl.Sum(x => x.Voters),
                    PartieList = CreatePartyList(cl)
                }
                ).ToList().First()
                );
            result.AddRange(StationList
                .GroupBy(l => l.DistrictName)
                .Select(cl => new ElectionDistrict
                {
                    DistrictName = cl.First().DistrictName,
                    EligibleVoters = cl.Sum(x => x.EligibleVoters),
                    TotalVoters = cl.Sum(x => x.Voters),
                    PartieList = CreatePartyList(cl)
                }
                ).ToList());          
            return result;
        }
    }
}
