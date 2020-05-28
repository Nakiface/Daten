using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
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
    public partial class DiagamForm : Form
    {
        public DiagamForm(List<Parties> partieList)
        {
            InitializeComponent();
            InitializeDiagram(partieList);
            
        }

        private void InitializeDiagram(List<Parties> partieList)
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
    }
}
