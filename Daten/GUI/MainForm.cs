using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper.Configuration.Attributes;
using DevExpress.Data.Helpers;
using DevExpress.Data.Mask;
using GoogleApi;
using LiveCharts;
using LiveCharts.Wpf;
using System.Reflection;
using DevExpress.Utils.Extensions;
using Daten.GUI;

namespace Daten
{
    public partial class MainForm : Form
    {
        List<ElectionDistrict> DistrictList = new List<ElectionDistrict>();
        List<PollingStation> StationList = new List<PollingStation>();
        public MainForm()
        {
            InitializeComponent();
            InitializeEventhandler();
            LoadingGlobalVariables();
            ConfigureDataGrids();
            InitializeComboBox(comboBoxMain, dataGridViewMain);           
        }

        private void InitializeComboBox(ComboBox comboBoxMain, DataGridView dataGridView)
        {
            comboBoxMain.DataSource = Operation.GetColumnNames(dataGridView);
        }

        private void BuildDiagram(List<Parties> partieList)
        {
            int i = 0;
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            pieChart1.Series = new SeriesCollection();
            foreach (var partie in partieList)
            {
                var partieColorList = Operation.CreatePariteColorList();
                if (partieColorList.Select(x => x.Name == partie.Name).Contains(true))
                {
                    var partieColor = partieColorList.Where(x => x.Name == partie.Name).ToList();
                    pieChart1.Series.Add(
                    new PieSeries
                    {
                        Title = partie.Name,
                        Values = new ChartValues<double> { partie.Voters },
                        DataLabels = false,
                        LabelPoint = labelPoint,
                        Fill = partieColor.First().Color
                    });
                }
                else
                {
                    pieChart1.Series.Add(
                    new PieSeries
                    {
                        Title = partie.Name,
                        Values = new ChartValues<double> { partie.Voters },
                        DataLabels = false,
                        LabelPoint = labelPoint,
                    });
                }
            }
        }

        private void ConfigureDataGrids()
        {
            dataGridViewMain.AutoGenerateColumns = false;
            dataGridViewMain.DataSource = DistrictList;
            DataGridViewColumn columnDistrictName = new DataGridViewTextBoxColumn();
            columnDistrictName.DataPropertyName = "DistrictName";
            columnDistrictName.Name = "Bezierksname";
            dataGridViewMain.Columns.Add(columnDistrictName);
            DataGridViewColumn columnDistrictVoters = new DataGridViewTextBoxColumn();
            columnDistrictVoters.DataPropertyName = "EligibleVoters";
            columnDistrictVoters.Name = "Wahlberechtigte";
            dataGridViewMain.Columns.Add(columnDistrictVoters);
            DataGridViewColumn columnDistrictTotalVoter = new DataGridViewTextBoxColumn();
            columnDistrictTotalVoter.DataPropertyName = "TotalVoters";
            columnDistrictTotalVoter.Name = "Wähler";
            dataGridViewMain.Columns.Add(columnDistrictTotalVoter);

            dataGridViewSecond.AutoGenerateColumns = false;
            DataGridViewColumn columnPartieName = new DataGridViewTextBoxColumn();
            columnPartieName.DataPropertyName = "Name";
            columnPartieName.Name = "Name";
            dataGridViewSecond.Columns.Add(columnPartieName);
            DataGridViewColumn columnPartieVoters = new DataGridViewTextBoxColumn();
            columnPartieVoters.DataPropertyName = "Voters";
            columnPartieVoters.Name = "Wähler";
            dataGridViewSecond.Columns.Add(columnPartieVoters);
            DataGridViewColumn columnPartiePercentage = new DataGridViewTextBoxColumn();
            columnPartiePercentage.DataPropertyName = "Percent";
            columnPartiePercentage.Name = "Stimmanteil";
            dataGridViewSecond.Columns.Add(columnPartiePercentage);
            dataGridViewSecond.Columns[2].DefaultCellStyle.Format = "#.000\\%";
        }

        private void LoadingGlobalVariables()
        {
            StationList = Operation.GetDataSource(@"C:\Projekte_Bernhard\Programme\Daten\CSV\EU2019_BE_EndgErg_Wahlbezirke.csv");
            MappingObject mappingObject = new MappingObject(StationList);
            DistrictList = mappingObject.GetDistrictList();
        }

        private void InitializeEventhandler()
        {
            dataGridViewMain.SelectionChanged += DataGridViewMain_SelectionChanged;
        }

        private void DataGridViewMain_SelectionChanged(object sender, EventArgs e)
        {
            var test = dataGridViewMain.Columns;
            
            ElectionDistrict electionDistrict = (ElectionDistrict)dataGridViewMain.CurrentRow.DataBoundItem;
            dataGridViewSecond.DataSource = electionDistrict.PartieList;
            BuildDiagram(electionDistrict.PartieList);
        }

        private void buttonSourceData_Click(object sender, EventArgs e)
        {
            DataSourceForm dataSource = new DataSourceForm(StationList);
            dataSource.ShowDialog();
        }

        private void ButtonShowVoter_Click(object sender, EventArgs e)
        {
            NacessaryVotesForm nacessaryVotes = new NacessaryVotesForm(DistrictList, StationList);
            nacessaryVotes.ShowDialog();
        }

        private void ButtonMainDec_Click(object sender, EventArgs e)
        {
            var choiceToSort = comboBoxMain.SelectedItem.ToString();
            OrderList(choiceToSort, true);
        }

        private void OrderList(string choiceToSort, bool dec)
        {
            string propertyName = "";
            foreach (DataGridViewColumn column in dataGridViewMain.Columns)
            {
                if (column.Name == choiceToSort)
                    propertyName = column.DataPropertyName.ToString();
            }
            List<ElectionDistrict> sortedDistrictList = new List<ElectionDistrict>();
            if (dec)
            {
                sortedDistrictList =
                    DistrictList.OrderBy(x => x.GetType().GetProperty(propertyName).GetValue(x)).ToList();
            }
            else
            {
                sortedDistrictList =
                    DistrictList.OrderByDescending(x => x.GetType().GetProperty(propertyName).GetValue(x)).ToList();
            }
            dataGridViewMain.DataSource = sortedDistrictList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var choiceToSort = comboBoxMain.SelectedItem.ToString();
            OrderList(choiceToSort, false);
        }
    }
}
