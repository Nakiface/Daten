using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Daten
{
    static class Operation
    {
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
    }
}
