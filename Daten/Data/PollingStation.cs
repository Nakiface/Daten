using CsvHelper.Configuration.Attributes;
using DevExpress.Data.Filtering.Helpers;
using Org.BouncyCastle.Asn1.Mozilla;

namespace Daten
{
    public class PollingStation
    {
        [Name("Stimmart")]
        public string VoteFor { get; set; }
        
        [Name("Adresse")]
        public string Address { get; set; }

        [Name("Bezirksnummer")]
        public int DistrictNumber { get; set; }

        [Name("Bezirksname")]
        public string DistrictName { get; set; }

        [Name("Wahlbezirk")]
        public string Constituency { get; set; }

        [Name("Wahlbezirksart")]
        public string ConstituencyType { get; set; }

        [Name("Abgeordneten-hauswahlkreis")]
        public int DeputyConstituency { get; set; }

        [Name("Bundestags-wahlkreis")]
        public int BundestagsConstituency { get; set; }

        [Name("OstWest")]
        public char EastWest { get; set; }

        [Name("Wahlberechtigteinsgesamt")]
        public int EligibleVoters { get; set; }
        
        [Name("WahlberechtigteA1")]
        public int VotersA1 { get; set; }

        [Name("WahlberechtigteA2")]
        public int VotersA2 { get; set; }

        [Name("WahlberechtigteA3")]
        public int VotersA3 { get; set; }

        [Name("Waehler")]
        public int Voters { get; set; }
        
        [Name("darunterWaehlerB1")]
        public int VotersB3 { get; set; }

        [Name("UngueltigeStimmen")]
        public int InvalidVotes { get; set; }

        [Name("GueltigeStimmen")]
        public int ValidVotes { get; set; }

        [Name("SPD")]
        public int SPD { get; set; }

        [Name("CDU")]
        public int CDU { get; set; }

        [Name("GRueNE")]
        public int Gruene { get; set; }

        [Name("DIELINKE")]
        public int DieLinke { get; set; }

        [Name("AfD")]
        public int AfD { get; set; }

        [Name("PIRATEN")]
        public int Piraten { get; set; }

        [Name("FDP")]
        public int FDP { get; set; }

        [Name("Tierschutzpartei")]
        public int Tierschutzpartei { get; set; }

        [Name("DiePARTEI")]
        public int DiePartei { get; set; }

        [Name("NPD")]
        public int NPD { get; set; }

        [Name("FAMILIE")]
        public int Familie { get; set; }

        [Name("Volksabstimmung")]
        public int Volksabstimmung { get; set; }

        [Name("OeDP")]
        public int OeDP { get; set; }

        [Name("FREIEWaeHLER")]
        public int FreieWaehler { get; set; }

        [Name("DKP")]
        public int DKP { get; set; }

        [Name("MLPD")]
        public int MLPD { get; set; }

        [Name("SGP")]
        public int SGP { get; set; }
        
        [Name("BP")]
        public int BP { get; set; }

        [Name("TIERSCHUTZhier!")]
        public int TierschutzHier { get; set; }

        [Name("Tierschutzallianz")]
        public int Tierschutzallianz { get; set; }

        [Name("BuendnisC")]
        public int BuendnisC { get; set; }

        [Name("BIG")]
        public int BIG { get; set; }

        [Name("BGE")]
        public int BGE { get; set; }

        [Name("DIEDIREKTE!")]
        public int DieDirekte { get; set; }

        [Name("DiEM25")]
        public int DieM25 { get; set; }

        [Name("III.Weg")]
        public int IIIWeg { get; set; }

        [Name("DieGrauen")]
        public int DieGrauen { get; set; }

        [Name("DIERECHTE")]
        public int DieRechte { get; set; }

        [Name("DIEVIOLETTEN")]
        public int DieVioletten { get; set; }

        [Name("LIEBE")]
        public int Liebe { get; set; }

        [Name("DIEFRAUEN")]
        public int DieFrauen { get; set; }

        [Name("GrauePanther")]
        public int GrauePanther { get; set; }

        [Name("LKR")]
        public int LKR { get; set; }

        [Name("MENSCHLICHEWELT")]
        public int MeschlicheWelt { get; set; }

        [Name("NL")]
        public int NL { get; set; }

        [Name("OekoLinX")]
        public int OekoLinX { get; set; }

        [Name("DieHumanisten")]
        public int DieHumanisten { get; set; }

        [Name("PARTEIFueRDIETIERE")]
        public int ParteiFuerTiere { get; set; }

        [Name("Gesundheitsforschung")]
        public int Gesundheitsforschung { get; set; }

        [Name("Volt")]
        public int Volt { get; set; }
    }
}
