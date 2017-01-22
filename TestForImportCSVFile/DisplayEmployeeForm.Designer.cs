namespace TestForImportCSVFile
{
    partial class EmployeeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImportCsv = new System.Windows.Forms.Button();
            this.employeeDataGridViewPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desigination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wageRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCalculateTotalWage = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.employeeDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportCsv
            // 
            this.btnImportCsv.Location = new System.Drawing.Point(954, 433);
            this.btnImportCsv.Name = "btnImportCsv";
            this.btnImportCsv.Size = new System.Drawing.Size(75, 23);
            this.btnImportCsv.TabIndex = 0;
            this.btnImportCsv.Text = "Import";
            this.btnImportCsv.UseVisualStyleBackColor = true;
            this.btnImportCsv.Click += new System.EventHandler(this.btnImportCsv_Click);
            // 
            // employeeDataGridViewPanel
            // 
            this.employeeDataGridViewPanel.Controls.Add(this.dataGridView);
            this.employeeDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeDataGridViewPanel.Location = new System.Drawing.Point(0, 0);
            this.employeeDataGridViewPanel.Name = "employeeDataGridViewPanel";
            this.employeeDataGridViewPanel.Size = new System.Drawing.Size(1205, 422);
            this.employeeDataGridViewPanel.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.number,
            this.email,
            this.desigination,
            this.department,
            this.dateOfJoin,
            this.wageRate,
            this.hourWorked,
            this.totalWage});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1205, 422);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // desigination
            // 
            this.desigination.HeaderText = "Desigination";
            this.desigination.Name = "desigination";
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            // 
            // dateOfJoin
            // 
            this.dateOfJoin.HeaderText = "Date Of Join";
            this.dateOfJoin.Name = "dateOfJoin";
            // 
            // wageRate
            // 
            this.wageRate.HeaderText = "Wage Rate";
            this.wageRate.Name = "wageRate";
            // 
            // hourWorked
            // 
            this.hourWorked.HeaderText = "Hour Worked";
            this.hourWorked.Name = "hourWorked";
            // 
            // totalWage
            // 
            this.totalWage.HeaderText = "Total Wage";
            this.totalWage.Name = "totalWage";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(1039, 433);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1124, 433);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(873, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCalculateTotalWage
            // 
            this.btnCalculateTotalWage.Location = new System.Drawing.Point(726, 433);
            this.btnCalculateTotalWage.Name = "btnCalculateTotalWage";
            this.btnCalculateTotalWage.Size = new System.Drawing.Size(141, 23);
            this.btnCalculateTotalWage.TabIndex = 2;
            this.btnCalculateTotalWage.Text = "Calculate Total Wage";
            this.btnCalculateTotalWage.UseVisualStyleBackColor = true;
            this.btnCalculateTotalWage.Click += new System.EventHandler(this.btnCalculateTotalWage_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(579, 433);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(141, 23);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 465);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnCalculateTotalWage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.employeeDataGridViewPanel);
            this.Controls.Add(this.btnImportCsv);
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.employeeDataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportCsv;
        private System.Windows.Forms.Panel employeeDataGridViewPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn desigination;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn wageRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWage;
        private System.Windows.Forms.Button btnCalculateTotalWage;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}

