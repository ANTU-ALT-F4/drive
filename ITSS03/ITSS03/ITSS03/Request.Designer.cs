namespace ITSS03
{
    partial class Request
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cb_partname = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_request = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_tech = new System.Windows.Forms.TextBox();
            this.date_com = new System.Windows.Forms.DateTimePicker();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_depart = new System.Windows.Forms.Label();
            this.lb_aname = new System.Windows.Forms.Label();
            this.lb_asn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(578, 531);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(487, 34);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(132, 22);
            this.txt_amount.TabIndex = 6;
            // 
            // cb_partname
            // 
            this.cb_partname.FormattingEnabled = true;
            this.cb_partname.Location = new System.Drawing.Point(117, 34);
            this.cb_partname.Margin = new System.Windows.Forms.Padding(4);
            this.cb_partname.Name = "cb_partname";
            this.cb_partname.Size = new System.Drawing.Size(160, 24);
            this.cb_partname.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(672, 28);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "+ Add to list";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Part Name:";
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.MinimumWidth = 6;
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.action.Text = "Remove";
            this.action.UseColumnTextForLinkValue = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // partname
            // 
            this.partname.HeaderText = "Part Name";
            this.partname.MinimumWidth = 6;
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            // 
            // idpart
            // 
            this.idpart.HeaderText = "idpart";
            this.idpart.MinimumWidth = 6;
            this.idpart.Name = "idpart";
            this.idpart.ReadOnly = true;
            this.idpart.Visible = false;
            // 
            // dgv_request
            // 
            this.dgv_request.AllowUserToAddRows = false;
            this.dgv_request.AllowUserToDeleteRows = false;
            this.dgv_request.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_request.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpart,
            this.partname,
            this.amount,
            this.action});
            this.dgv_request.Location = new System.Drawing.Point(32, 75);
            this.dgv_request.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_request.Name = "dgv_request";
            this.dgv_request.ReadOnly = true;
            this.dgv_request.RowHeadersVisible = false;
            this.dgv_request.RowHeadersWidth = 51;
            this.dgv_request.Size = new System.Drawing.Size(780, 151);
            this.dgv_request.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(245, 531);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(100, 28);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_request);
            this.groupBox3.Controls.Add(this.txt_amount);
            this.groupBox3.Controls.Add(this.cb_partname);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(26, 281);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(841, 242);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement Parts";
            // 
            // txt_tech
            // 
            this.txt_tech.Location = new System.Drawing.Point(144, 82);
            this.txt_tech.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tech.Multiline = true;
            this.txt_tech.Name = "txt_tech";
            this.txt_tech.Size = new System.Drawing.Size(676, 51);
            this.txt_tech.TabIndex = 6;
            // 
            // date_com
            // 
            this.date_com.CustomFormat = "dd/MM/yyyy";
            this.date_com.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_com.Location = new System.Drawing.Point(589, 30);
            this.date_com.Margin = new System.Windows.Forms.Padding(4);
            this.date_com.Name = "date_com";
            this.date_com.Size = new System.Drawing.Size(169, 22);
            this.date_com.TabIndex = 5;
            // 
            // date_start
            // 
            this.date_start.CustomFormat = "dd/MM/yyyy";
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_start.Location = new System.Drawing.Point(120, 28);
            this.date_start.Margin = new System.Windows.Forms.Padding(4);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(169, 22);
            this.date_start.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Technician Note:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tech);
            this.groupBox2.Controls.Add(this.date_com);
            this.groupBox2.Controls.Add(this.date_start);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(841, 142);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset EM Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Completed On:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start Date:";
            // 
            // lb_depart
            // 
            this.lb_depart.AutoSize = true;
            this.lb_depart.Location = new System.Drawing.Point(647, 41);
            this.lb_depart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_depart.Name = "lb_depart";
            this.lb_depart.Size = new System.Drawing.Size(64, 16);
            this.lb_depart.TabIndex = 7;
            this.lb_depart.Text = "lb_depart";
            // 
            // lb_aname
            // 
            this.lb_aname.AutoSize = true;
            this.lb_aname.Location = new System.Drawing.Point(357, 39);
            this.lb_aname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_aname.Name = "lb_aname";
            this.lb_aname.Size = new System.Drawing.Size(67, 16);
            this.lb_aname.TabIndex = 6;
            this.lb_aname.Text = "lb_aname";
            // 
            // lb_asn
            // 
            this.lb_asn.AutoSize = true;
            this.lb_asn.Location = new System.Drawing.Point(97, 41);
            this.lb_asn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_asn.Name = "lb_asn";
            this.lb_asn.Size = new System.Drawing.Size(47, 16);
            this.lb_asn.TabIndex = 5;
            this.lb_asn.Text = "lb_asn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asset Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset SN:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_depart);
            this.groupBox1.Controls.Add(this.lb_aname);
            this.groupBox1.Controls.Add(this.lb_asn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(841, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 574);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_request)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cb_partname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewLinkColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpart;
        private System.Windows.Forms.DataGridView dgv_request;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_tech;
        private System.Windows.Forms.DateTimePicker date_com;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_depart;
        private System.Windows.Forms.Label lb_aname;
        private System.Windows.Forms.Label lb_asn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}