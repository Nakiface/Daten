using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daten.GUI
{
    public partial class NacessaryVotesForm : Form
    {
        private List<ElectionDistrict> DistrictList { get; set; }
        private List<PollingStation> StationList { get; set; }
        public NacessaryVotesForm(List<ElectionDistrict> districtList, List<PollingStation> stationList)
        {
            this.DistrictList = districtList;
            this.StationList = stationList;
            InitializeComponent();
            InitializeComboBoxScope();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            comboBoxScope.SelectedValueChanged += ComboBoxScope_SelectedValueChanged;
        }

        private void ComboBoxScope_SelectedValueChanged(object sender, EventArgs e)
        {
            BuildComboBoxChoice();
        }

        private void BuildComboBoxChoice()
        {
            var scope = comboBoxScope.Text;
            List<string> dataSource = new List<string>();
            switch (scope)
            {
                case "Berlin":
                    dataSource.Add("Berlin");
                    break;
                case "Bezirke":
                    dataSource.AddRange(Operation.GetAllDistrictNames(DistrictList));
                    break;
                case "Wahllokal":
                    dataSource.AddRange(Operation.GetAllStationNamens(StationList));
                    break;
                default:
                    break;
            }
            comboBoxChoice.DataSource = dataSource;
        }

        private void InitializeComboBoxScope()
        {
            List<string> ScopeList = new List<string>
            {
                "Berlin",
                "Bezirke",
                "Wahllokal"
            };
            comboBoxScope.DataSource = ScopeList;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InitiliazeDataGrid();
        }

        private void InitiliazeDataGrid()
        {
            dataGridViewNV.AutoGenerateColumns = false;
            dataGridViewNV.DataSource = DistrictList;

            DataGridViewColumn columnName = new DataGridViewTextBoxColumn();
            columnName.DataPropertyName = "Name";
            columnName.Name = "Name";
            dataGridViewNV.Columns.Add(columnName);

            DataGridViewColumn columnTotalVoters = new DataGridViewTextBoxColumn();
            columnTotalVoters.DataPropertyName = "TotalVoters";
            columnTotalVoters.Name = "Wähler";
            dataGridViewNV.Columns.Add(columnTotalVoters);

            DataGridViewColumn columnDifference = new DataGridViewTextBoxColumn();
            columnDifference.DataPropertyName = "Difference";
            columnDifference.Name = "Stimmen für Sicheren Sitz +/-";
            dataGridViewNV.Columns.Add(columnDifference);
        }
    }
}
