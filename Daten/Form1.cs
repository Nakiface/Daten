using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper.Configuration.Attributes;
using DevExpress.Data.Mask;
using GoogleApi;

namespace Daten
{
    public partial class Form1 : Form
    {
        List<ElectionDistrict> DistrictList = new List<ElectionDistrict>();
        public Form1()
        {
            InitializeComponent();
            dataGridViewMain.SelectionChanged += DataGridViewMain_SelectionChanged;
            var dataSource = Operation.GetDataSource(@"C:\Bernhard\Schule\AS\Programmieren\Daten\CSV\EU2019_BE_EndgErg_Wahlbezirke.csv");
            //dataGridViewMain.AutoGenerateColumns = false;
             
            MappingObject mappingObject = new MappingObject(dataSource);
            DistrictList = mappingObject.GetDistrictList();
            dataGridViewMain.DataSource = DistrictList;
            //DataGridViewColumn column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "DistrictName";
            //column.Name = "Bezierksname";
            //dataGridViewMain.Columns.Add(column);
        }

        private void DataGridViewMain_SelectionChanged(object sender, EventArgs e)
        {
            ElectionDistrict electionDistrict = (ElectionDistrict)dataGridViewMain.CurrentRow.DataBoundItem;
            dataGridViewSecond.DataSource = electionDistrict.PartieList;
        }
    }
}
