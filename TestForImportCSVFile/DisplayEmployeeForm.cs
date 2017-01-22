using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TestForImportCSVFile
{
    public partial class EmployeeDetails : Form
    {
        private int row = 0;


        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private string fileName;


        //This method will be called when the import botton clicked. It will import the files
        private void btnImportCsv_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "|*.csv";
            DialogResult result = dialog.ShowDialog();
            fileName = dialog.FileName;

            if (result == DialogResult.OK)
            {
                importCsvFile();
            }
        }

        //Reads the rows from csv file and add to dataGridView
        private void importCsvFile()
        {
            try
            {
               StreamReader reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    var fields = reader.ReadLine().Split(',');
                    dataGridView.Rows.Add(fields);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        //This method will be called when add botton is clicked.
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //Object of AddEmployeeForm class to get the values of the form through delegates
            AddEmployeeForm addEmp = new AddEmployeeForm();
            addEmp.IdentityUpdated += new AddEmployeeForm.IdentityHandler(this.SaveRecord);
            addEmp.ShowDialog();
        }


        //Method to add values received from delegates to dataGridView
        private void SaveRecord(object sender, AddEmployeeForm.IdentityEventArgs e)
        {
            int count = dataGridView.Rows.Count - 1;
            dataGridView.Rows.Add();
            dataGridView.Rows[count].Cells[0].Value = e.Id;
            dataGridView.Rows[count].Cells[1].Value = e.Name;
            dataGridView.Rows[count].Cells[2].Value = e.Address;
            dataGridView.Rows[count].Cells[3].Value = e.ContactNo;
            dataGridView.Rows[count].Cells[4].Value = e.Email;
            dataGridView.Rows[count].Cells[5].Value = e.Desigination;       
            dataGridView.Rows[count].Cells[6].Value = e.Department;
            dataGridView.Rows[count].Cells[7].Value = e.DateOfJoin;
            dataGridView.Rows[count].Cells[8].Value = e.WageRate;
            dataGridView.Rows[count].Cells[9].Value = e.HourWorked;
        }

        //Method to calculate the salary of employee
        private void CalculateTotalWage()
        {
            try
            {
                for (int i = 0; i < dataGridView.Rows.Count-1; i++)
                {
                    int wageRate = Int32.Parse(dataGridView.Rows[i].Cells[8].Value.ToString());
                    int workedHour = Int32.Parse(dataGridView.Rows[i].Cells[9].Value.ToString());
                    dataGridView.Rows[i].Cells[10].Value = wageRate * workedHour;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Local member variable which holds the details of employee of deleted rows on dataGridView
                row = dataGridView.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridView.Rows[row].Cells[0].Value);
                string name = Convert.ToString(dataGridView.Rows[row].Cells[1].Value);
                string address = Convert.ToString(dataGridView.Rows[row].Cells[2].Value);
                string contact = Convert.ToString(dataGridView.Rows[row].Cells[3].Value);
                string email = Convert.ToString(dataGridView.Rows[row].Cells[4].Value);
                string desigination = Convert.ToString(dataGridView.Rows[row].Cells[5].Value);
                string department = Convert.ToString(dataGridView.Rows[row].Cells[6].Value);
                string dateOfJoin = Convert.ToString(dataGridView.Rows[row].Cells[7].Value);
                string wageRate = Convert.ToString(dataGridView.Rows[row].Cells[8].Value);
                string hourWorked = Convert.ToString(dataGridView.Rows[row].Cells[9].Value);

                //Passes the current value to child edit form through construct parameter and gets new updated value through delegates
                AddEmployeeForm addEmp = new AddEmployeeForm();
                addEmp.loadData(id, name, address, contact, email, desigination, department, dateOfJoin, wageRate,hourWorked);
                addEmp.IdentityUpdated += new AddEmployeeForm.IdentityHandler(this.UpdateRecord);
                addEmp.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

}

        //This method will set new updated values received through delegates to dataGridView's cell
        private void UpdateRecord(object sender, AddEmployeeForm.IdentityEventArgs e)
        {
            dataGridView.Rows[row].Cells[0].Value = e.Id;
            dataGridView.Rows[row].Cells[1].Value = e.Name;
            dataGridView.Rows[row].Cells[2].Value = e.Address;
            dataGridView.Rows[row].Cells[3].Value = e.ContactNo;
            dataGridView.Rows[row].Cells[4].Value = e.Email;
            dataGridView.Rows[row].Cells[5].Value = e.Desigination;
            dataGridView.Rows[row].Cells[6].Value = e.Department;
            dataGridView.Rows[row].Cells[7].Value = e.DateOfJoin;
            dataGridView.Rows[row].Cells[8].Value = e.WageRate;
            dataGridView.Rows[row].Cells[9].Value = e.HourWorked;

        }


        //Method to delete the selected rows
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method will be called when calculate total wage bottom is clicked and call CalculateTotalWage method
        private void btnCalculateTotalWage_Click(object sender, EventArgs e)
        {
            CalculateTotalWage();
        }


        //This method is called when generate report is clicked
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport report = new GenerateReport(dataGridView);
            report.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
