using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using DevExpress.Data.Mask;
using GoogleApi;

namespace Daten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var dataSource = Operation.GetDataSource(@"C:\Bernhard\Schule\AS\Programmieren\Daten\CSV\EU2019_BE_EndgErg_Wahlbezirke.csv");
            //dataGridViewMain.AutoGenerateColumns = false;
            dataGridViewMain.DataSource = dataSource;
            //DataGridViewColumn column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "DistrictName";
            //column.Name = "Bezierksname";
            //dataGridViewMain.Columns.Add(column);
        }
    }

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
