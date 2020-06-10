using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Daten
{
    public class SortList
    {
        public List<Parties> PartieList(DataGridView dataGridViewMain, DataGridViewColumnCollection columnCollection, List<ElectionDistrict> districtList, string choiceToSort, bool dec)
        {
            string propertyName = "";
            ElectionDistrict electionDistrict = (ElectionDistrict)dataGridViewMain.CurrentRow.DataBoundItem;
            foreach (DataGridViewColumn column in columnCollection)
            {
                if (column.Name == choiceToSort)
                    propertyName = column.DataPropertyName.ToString();
            }
            List<Parties> sortedDistrictList = new List<Parties>();
            if (dec)
            {
                sortedDistrictList =
                    electionDistrict.PartieList.OrderBy(x => x.GetType().GetProperty(propertyName).GetValue(x)).ToList();
            }
            else
            {
                sortedDistrictList =
                    electionDistrict.PartieList.OrderByDescending(x => x.GetType().GetProperty(propertyName).GetValue(x)).ToList();
            }
            return sortedDistrictList;
        }

        public List<ElectionDistrict> DistrictList(DataGridViewColumnCollection columnCollection, List<ElectionDistrict> districtList, string choiceToSort, bool dec)
        {
            string propertyName = "";
            foreach (DataGridViewColumn column in columnCollection)
            {
                if (column.Name == choiceToSort)
                    propertyName = column.DataPropertyName.ToString();
            }
            List<ElectionDistrict> sortedDistrictList = new List<ElectionDistrict>();
            if (dec)
            {
                sortedDistrictList =
                    districtList.OrderBy(x => x.GetType().GetProperty(propertyName).GetValue(x)).ToList();
            }
            else
            {
                sortedDistrictList =
                    districtList.OrderByDescending(x => x.GetType().GetProperty(propertyName).GetValue(x)).ToList();
            }
            return sortedDistrictList;
        }
    }
}
