namespace EmployeeManagementSystem
{
    partial class frmEmployeeDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDetails));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.ColumnEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.txtSearchEmployeeName = new System.Windows.Forms.TextBox();
            this.lblSearchEmpName = new System.Windows.Forms.Label();
            this.lblSearchEmpID = new System.Windows.Forms.Label();
            this.txtSearchEmployeeID = new System.Windows.Forms.TextBox();
            this.bindingNavigatorEmployee = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.groupBoxEmployee.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEmployee)).BeginInit();
            this.bindingNavigatorEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(464, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AllowUserToAddRows = false;
            this.dgvEmployeeDetails.AllowUserToDeleteRows = false;
            this.dgvEmployeeDetails.AllowUserToResizeRows = false;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmployeeID,
            this.ColumnEmployeeName,
            this.ColumnEmail,
            this.ColumnGender,
            this.ColumnStatus,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(12, 260);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.RowHeadersVisible = false;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(884, 286);
            this.dgvEmployeeDetails.TabIndex = 1;
            this.dgvEmployeeDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellContentClick);
            // 
            // ColumnEmployeeID
            // 
            this.ColumnEmployeeID.DataPropertyName = "id";
            this.ColumnEmployeeID.HeaderText = "Employee ID";
            this.ColumnEmployeeID.Name = "ColumnEmployeeID";
            this.ColumnEmployeeID.ReadOnly = true;
            this.ColumnEmployeeID.Width = 130;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.DataPropertyName = "name";
            this.ColumnEmployeeName.HeaderText = "Employee Name";
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.ReadOnly = true;
            this.ColumnEmployeeName.Width = 180;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.DataPropertyName = "email";
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 230;
            // 
            // ColumnGender
            // 
            this.ColumnGender.DataPropertyName = "gender";
            this.ColumnGender.HeaderText = "Gender";
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.ReadOnly = true;
            this.ColumnGender.Width = 120;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.DataPropertyName = "status";
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 120;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Edit";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Text = "Edit";
            this.ColumnEdit.UseColumnTextForLinkValue = true;
            this.ColumnEdit.Width = 50;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 50;
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.tableLayoutPanel);
            this.groupBoxEmployee.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(884, 153);
            this.groupBoxEmployee.TabIndex = 2;
            this.groupBoxEmployee.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.32637F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.67363F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.tableLayoutPanel.Controls.Add(this.txtEmployeeID, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.lblEmployeeID, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblEmployeeName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtEmployeeName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblGender, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.lblStatus, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.cboGender, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.cboStatus, 3, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(739, 123);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(93, 3);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(213, 20);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(415, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 39);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(95, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(3, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 3;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(3, 39);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(93, 42);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(213, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(361, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(361, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cboGender.Location = new System.Drawing.Point(415, 3);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(184, 21);
            this.cboGender.TabIndex = 4;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.cboStatus.Location = new System.Drawing.Point(415, 42);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(184, 21);
            this.cboStatus.TabIndex = 4;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnExportCSV);
            this.groupBoxSearch.Controls.Add(this.txtSearchEmployeeName);
            this.groupBoxSearch.Controls.Add(this.lblSearchEmpName);
            this.groupBoxSearch.Controls.Add(this.lblSearchEmpID);
            this.groupBoxSearch.Controls.Add(this.txtSearchEmployeeID);
            this.groupBoxSearch.Controls.Add(this.btnRefresh);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 171);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(884, 69);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(793, 40);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(85, 23);
            this.btnExportCSV.TabIndex = 4;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // txtSearchEmployeeName
            // 
            this.txtSearchEmployeeName.Location = new System.Drawing.Point(251, 23);
            this.txtSearchEmployeeName.Name = "txtSearchEmployeeName";
            this.txtSearchEmployeeName.Size = new System.Drawing.Size(193, 20);
            this.txtSearchEmployeeName.TabIndex = 1;
            // 
            // lblSearchEmpName
            // 
            this.lblSearchEmpName.AutoSize = true;
            this.lblSearchEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmpName.Location = new System.Drawing.Point(210, 26);
            this.lblSearchEmpName.Name = "lblSearchEmpName";
            this.lblSearchEmpName.Size = new System.Drawing.Size(35, 13);
            this.lblSearchEmpName.TabIndex = 3;
            this.lblSearchEmpName.Text = "Name";
            // 
            // lblSearchEmpID
            // 
            this.lblSearchEmpID.AutoSize = true;
            this.lblSearchEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmpID.Location = new System.Drawing.Point(6, 26);
            this.lblSearchEmpID.Name = "lblSearchEmpID";
            this.lblSearchEmpID.Size = new System.Drawing.Size(18, 13);
            this.lblSearchEmpID.TabIndex = 3;
            this.lblSearchEmpID.Text = "ID";
            // 
            // txtSearchEmployeeID
            // 
            this.txtSearchEmployeeID.Location = new System.Drawing.Point(30, 23);
            this.txtSearchEmployeeID.Name = "txtSearchEmployeeID";
            this.txtSearchEmployeeID.Size = new System.Drawing.Size(152, 20);
            this.txtSearchEmployeeID.TabIndex = 1;
            // 
            // bindingNavigatorEmployee
            // 
            this.bindingNavigatorEmployee.AddNewItem = null;
            this.bindingNavigatorEmployee.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorEmployee.DeleteItem = null;
            this.bindingNavigatorEmployee.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorEmployee.Location = new System.Drawing.Point(12, 549);
            this.bindingNavigatorEmployee.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorEmployee.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorEmployee.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorEmployee.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorEmployee.Name = "bindingNavigatorEmployee";
            this.bindingNavigatorEmployee.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorEmployee.Size = new System.Drawing.Size(240, 25);
            this.bindingNavigatorEmployee.TabIndex = 0;
            this.bindingNavigatorEmployee.Text = "bindingNavigator1";
            this.bindingNavigatorEmployee.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bindingNavigatorEmployee_ItemClicked);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 620);
            this.Controls.Add(this.bindingNavigatorEmployee);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxEmployee);
            this.Controls.Add(this.dgvEmployeeDetails);
            this.Name = "frmEmployeeDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.frmEmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.groupBoxEmployee.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEmployee)).EndInit();
            this.bindingNavigatorEmployee.ResumeLayout(false);
            this.bindingNavigatorEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtSearchEmployeeName;
        private System.Windows.Forms.Label lblSearchEmpName;
        private System.Windows.Forms.Label lblSearchEmpID;
        private System.Windows.Forms.TextBox txtSearchEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingNavigator bindingNavigatorEmployee;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}