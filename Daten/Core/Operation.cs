using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using CsvHelper;

namespace Daten
{
    static class Operation
    {
        public static List<string> GetColumnNames(DataGridView dataGridView)
        {
            List<string> dataGridColums = new List<string>();
            foreach (DataGridViewColumn colum in dataGridView.Columns)
            {
                dataGridColums.Add(colum.Name);
            }
            return dataGridColums;
        }
        public static List<PollingStation> GetDataSource (string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.BadDataFound = null;
                var records = csv.GetRecords<PollingStation>();
                var stationList = records.ToList();
                MappingObject mappingObject = new MappingObject(stationList);
                mappingObject.GetDistrictList();
                return stationList;

            }           
        }

        public static List<PartieColor> CreatePariteColorList()
        {
            List<PartieColor> partieColorList = new List<PartieColor>()
            {
                new PartieColor
                {
                    Name = "SPD",
                    Color = System.Windows.Media.Brushes.Red
                },
                new PartieColor
                {
                    Name = "CDU",
                    Color = System.Windows.Media.Brushes.Black
                },
                new PartieColor
                {
                    Name = "Grüne",
                    Color = System.Windows.Media.Brushes.Green
                },
                new PartieColor
                {
                    Name = "Die Linke",
                    Color = System.Windows.Media.Brushes.Violet
                },
                new PartieColor
                {
                    Name = "AfD",
                    Color = System.Windows.Media.Brushes.Blue
                },
                new PartieColor
                {
                    Name = "Piraten",
                    Color = System.Windows.Media.Brushes.Orange
                },
                new PartieColor
                {
                    Name = "FDP",
                    Color = System.Windows.Media.Brushes.Yellow
                }
            };
            return partieColorList;
        }

        internal static IEnumerable<string> GetAllStationNamens(List<PollingStation> stationList)
        {
            List<string> result = stationList.Where(x => x.Address != "").Select(y => y.Address).ToList();
            return result;
        }

        internal static List<string> GetAllDistrictNames(List<ElectionDistrict> districtList)
        {
            List<string> result = districtList.Where(x => x.DistrictName != "Berlin").Select(y => y.DistrictName).ToList();
            return result;
        }
    }
}
