namespace ITSS03
{
    partial class Management
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
            this.dgv_management = new System.Windows.Forms.DataGridView();
            this.assetid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emfullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemmain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ManageRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_management)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_management
            // 
            this.dgv_management.AllowUserToAddRows = false;
            this.dgv_management.AllowUserToDeleteRows = false;
            this.dgv_management.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_management.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetid,
            this.assetsn,
            this.assetname,
            this.requestdate,
            this.emfullname,
            this.department,
            this.idemmain});
            this.dgv_management.Location = new System.Drawing.Point(74, 42);
            this.dgv_management.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_management.Name = "dgv_management";
            this.dgv_management.ReadOnly = true;
            this.dgv_management.RowHeadersVisible = false;
            this.dgv_management.RowHeadersWidth = 51;
            this.dgv_management.Size = new System.Drawing.Size(1029, 428);
            this.dgv_management.TabIndex = 4;
            this.dgv_management.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_management_CellClick);
            // 
            // assetid
            // 
            this.assetid.DataPropertyName = "assetid";
            this.assetid.HeaderText = "Assetid";
            this.assetid.MinimumWidth = 6;
            this.assetid.Name = "assetid";
            this.assetid.ReadOnly = true;
            this.assetid.Visible = false;
            this.assetid.Width = 125;
            // 
            // assetsn
            // 
            this.assetsn.DataPropertyName = "assetsn";
            this.assetsn.HeaderText = "Asset SN";
            this.assetsn.MinimumWidth = 6;
            this.assetsn.Name = "assetsn";
            this.assetsn.ReadOnly = true;
            this.assetsn.Width = 125;
            // 
            // assetname
            // 
            this.assetname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assetname.DataPropertyName = "assetname";
            this.assetname.HeaderText = "Asset Name";
            this.assetname.MinimumWidth = 6;
            this.assetname.Name = "assetname";
            this.assetname.ReadOnly = true;
            // 
            // requestdate
            // 
            this.requestdate.DataPropertyName = "emreportdate";
            this.requestdate.HeaderText = "Request Date";
            this.requestdate.MinimumWidth = 6;
            this.requestdate.Name = "requestdate";
            this.requestdate.ReadOnly = true;
            this.requestdate.Width = 125;
            // 
            // emfullname
            // 
            this.emfullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emfullname.DataPropertyName = "emfullname";
            this.emfullname.HeaderText = "Employee Full Name";
            this.emfullname.MinimumWidth = 6;
            this.emfullname.Name = "emfullname";
            this.emfullname.ReadOnly = true;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.DataPropertyName = "name";
            this.department.HeaderText = "Department";
            this.department.MinimumWidth = 6;
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // idemmain
            // 
            this.idemmain.DataPropertyName = "idemmain";
            this.idemmain.HeaderText = "IdEmergencymaintenances";
            this.idemmain.MinimumWidth = 6;
            this.idemmain.Name = "idemmain";
            this.idemmain.ReadOnly = true;
            this.idemmain.Visible = false;
            this.idemmain.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Assets Requesting EM:";
            // 
            // btn_ManageRequest
            // 
            this.btn_ManageRequest.Location = new System.Drawing.Point(75, 487);
            this.btn_ManageRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ManageRequest.Name = "btn_ManageRequest";
            this.btn_ManageRequest.Size = new System.Drawing.Size(193, 28);
            this.btn_ManageRequest.TabIndex = 5;
            this.btn_ManageRequest.Text = "Manage Request";
            this.btn_ManageRequest.UseVisualStyleBackColor = true;
            this.btn_ManageRequest.Click += new System.EventHandler(this.btn_ManageRequest_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 520);
            this.Controls.Add(this.dgv_management);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ManageRequest);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_management)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_management;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetid;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetname;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn emfullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemmain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ManageRequest;
    }
}