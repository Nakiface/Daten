using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Daten
{
    public partial class DataSourceForm : Form
    {
        List<PollingStation> PollingStationList = new List<PollingStation>();
        public DataSourceForm(List<PollingStation> PollingStationList)
        {
            InitializeComponent();
            dataGridViewDataSource.DataSource = PollingStationList;
        }
    }
}
