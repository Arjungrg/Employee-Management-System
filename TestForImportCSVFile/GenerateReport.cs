using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestForImportCSVFile
{
    public partial class GenerateReport : Form
    {
        //List which hold departments
        List<string> departments = new List<string>();

        //This will hold the total wage of departments
        List<int> totalWages = new List<int>();

        public GenerateReport(DataGridView dgv)
        {
            InitializeComponent();
            GenerateList(dgv);
            MakeChart();
        }


        //Method to seperate unique value from deparment
        private void GenerateList(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count-1; i++)
            {
                string dept = dgv.Rows[i].Cells[6].Value.ToString();
                if (! departments.Contains(dept))
                {
                    departments.Add(dept);
                    totalWages.Add(0);
                }
            }

            //logic to calculate the total wage of deparment
            for (int i = 0; i < dgv.Rows.Count-1; i++)
            {
                string empDept = dgv.Rows[i].Cells[6].Value.ToString();
                for (int j = 0; j<departments.Count; j++)
                {
                    if (departments[j] == empDept)
                    {
                        totalWages[j] += Convert.ToInt32(dgv.Rows[i].Cells[10].Value);
                    }
                }
            }    
        }


        //Method to make chart
        private void MakeChart()
        {
            for (int i = 0; i < departments.Count; i++)
            {
                chart1.Series[0].Points.AddY(totalWages[i]);
                chart1.Series[0].Points[i].LegendText = departments[i];
            }
        }
    }

}
