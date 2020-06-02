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
        private NecVotersLogic NecVoteLogic { get; set; }
        public NacessaryVotesForm(List<ElectionDistrict> districtList, List<PollingStation> stationList)
        {
            this.DistrictList = districtList;
            this.StationList = stationList;
            this.NecVoteLogic = new NecVotersLogic(districtList, stationList);
            InitializeComponent();
            InitializeComboBoxScope();
            InitializeEvents();
            InitiliazeDataGrid();
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
            var necVoteInfo = NecVoteLogic.CreateInfoFromDistrict(comboBoxChoice.Text);
            dataGridViewNV.DataSource = necVoteInfo.NecVoterPartieList;
            CreateLabelInfo(necVoteInfo);
        }

        private void CreateLabelInfo(NecVoters necVoteInfo)
        {
            labelInfo.Text = $"In {necVoteInfo.Name} haben wir {necVoteInfo.TotalVoters} Wähler.\nMan benötigt {Convert.ToInt32(necVoteInfo.SecureSeat)} Stimmen um einen Sitz im EU Parlament zu erhalten";
        }

        private void InitiliazeDataGrid()
        {
            dataGridViewNV.AutoGenerateColumns = false;

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
