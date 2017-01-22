using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForImportCSVFile
{
    public partial class AddEmployeeForm : Form
    {
        /*******
         * 
         * 
         * This class is made to Add New Employee Details
         * 
         * 
         ********/

        //Registrating delegats
        public delegate void IdentityHandler(object sender, IdentityEventArgs e);
        
        //Event of Delegate type is added
        public event IdentityHandler IdentityUpdated;
        public AddEmployeeForm()
        {
            InitializeComponent();
            comboBoxDepartment.Items.Add("Developer");
            comboBoxDepartment.Items.Add("Management");
            comboBoxDepartment.Items.Add("Accounting");
            comboBoxDepartment.Items.Add("IT");
            comboBoxDepartment.SelectedIndex = 0;
        }


        //Method gets value through constructor while editing the employee details
        public void loadData(string id, string name, string address, string contact, string email, string desigination,
            string department, string dateOfJoin, string wageRate, string hourWorked)
        {
            textBoxID.Text = id;
            textBoxName.Text = name;
            textBoxAddress.Text = address;
            textBoxContactNo.Text = contact;
            textBoxEmial.Text = email;
            textBoxDesigination.Text = desigination;
            comboBoxDepartment.Text = department;
            dateTimePicker.Text = dateOfJoin;
            textBoxWageRate.Text = wageRate;
            textBoxHourWorked.Text = hourWorked;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //This method will be called while save botton and add employee details
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string contactNo = textBoxContactNo.Text;
            string email = textBoxEmial.Text;
            string desigination = textBoxDesigination.Text;
            string department = comboBoxDepartment.Text;
            string dateOfJoin = dateTimePicker.Text;
            string wageRate = textBoxWageRate.Text;
            string hourWorked = textBoxHourWorked.Text;


            //instance the event args and pass it each value
            IdentityEventArgs args = new IdentityEventArgs(id, name, address, contactNo,email,desigination,department,dateOfJoin, wageRate, hourWorked);

            //rise the event with the update arguments of delegates
            IdentityUpdated(this, args);

            this.Hide();

        }



        public class IdentityEventArgs : EventArgs
        {
            //local member variable to hold the values from text.
            private string id;
            private string name;
            private string address;
            private string contactNo;
            private string email;
            private string desigination;
            private string department;
            private string dateOfJoin;
            private string wageRate;
            private string hourWorked;
            

            public IdentityEventArgs(string id, string name, string address, string contactNo, string email, string desigination, string department, string dateOfJoin, string wageRate,string hourWorked)
            {
                this.id = id;
                this.name = name;
                this.address = address;
                this.contactNo = contactNo;
                this.email = email;
                this.desigination = desigination;
                this.department = department;
                this.dateOfJoin = dateOfJoin;
                this.wageRate = wageRate;
                this.hourWorked = hourWorked;
            }

            //Properties to get value
            public string Id
            {
                get { return id; }
            }

            public string Name {
                get { return name; }
            }

            public string Address
            {
                get { return address; }
            }

            public string ContactNo
            {
                get { return contactNo; }
            }

            public string Email
            {
                get { return email; }
            }

            public string Desigination
            {
                get { return desigination; }
            }

            public string Department
            {
                get { return department; }
            }

            public string WageRate
            {
                get { return wageRate; }
            }

            public string DateOfJoin
            {
                get { return dateOfJoin; }
            }

            public string HourWorked
            {
                get { return hourWorked; }
            }
        }

        private void textBoxHourWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
