namespace ITSS01
{
    partial class PurchaseOrders
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
            this.btn_addlist = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bnumber = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.cb_part = new System.Windows.Forms.ComboBox();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.idpart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.cb_ware = new System.Windows.Forms.ComboBox();
            this.cb_sup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addlist
            // 
            this.btn_addlist.Location = new System.Drawing.Point(869, 34);
            this.btn_addlist.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addlist.Name = "btn_addlist";
            this.btn_addlist.Size = new System.Drawing.Size(100, 28);
            this.btn_addlist.TabIndex = 13;
            this.btn_addlist.Text = "+ Add to list";
            this.btn_addlist.UseVisualStyleBackColor = true;
            this.btn_addlist.Click += new System.EventHandler(this.btn_addlist_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(775, 37);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(71, 22);
            this.txt_amount.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Batch number :";
            // 
            // txt_bnumber
            // 
            this.txt_bnumber.Location = new System.Drawing.Point(466, 38);
            this.txt_bnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bnumber.Name = "txt_bnumber";
            this.txt_bnumber.Size = new System.Drawing.Size(237, 22);
            this.txt_bnumber.TabIndex = 17;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(548, 327);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(307, 326);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(100, 28);
            this.btn_submit.TabIndex = 15;
            this.btn_submit.Text = "Save";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Visible = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parts name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_part);
            this.groupBox1.Controls.Add(this.dgv_order);
            this.groupBox1.Controls.Add(this.txt_bnumber);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_submit);
            this.groupBox1.Controls.Add(this.btn_addlist);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Location = new System.Drawing.Point(28, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(994, 363);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts list";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(305, 326);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(100, 28);
            this.btn_capnhat.TabIndex = 19;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Visible = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // cb_part
            // 
            this.cb_part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_part.FormattingEnabled = true;
            this.cb_part.Location = new System.Drawing.Point(109, 38);
            this.cb_part.Margin = new System.Windows.Forms.Padding(4);
            this.cb_part.Name = "cb_part";
            this.cb_part.Size = new System.Drawing.Size(231, 24);
            this.cb_part.TabIndex = 14;
            this.cb_part.SelectionChangeCommitted += new System.EventHandler(this.cb_part_SelectionChangeCommitted);
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.AllowUserToOrderColumns = true;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpart,
            this.partname,
            this.batchnumber,
            this.amount,
            this.idorder,
            this.Remove});
            this.dgv_order.Location = new System.Drawing.Point(26, 83);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersWidth = 51;
            this.dgv_order.RowTemplate.Height = 24;
            this.dgv_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_order.Size = new System.Drawing.Size(943, 236);
            this.dgv_order.TabIndex = 18;
            this.dgv_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellContentClick);
            // 
            // idpart
            // 
            this.idpart.HeaderText = "idpart";
            this.idpart.MinimumWidth = 6;
            this.idpart.Name = "idpart";
            this.idpart.Visible = false;
            this.idpart.Width = 125;
            // 
            // partname
            // 
            this.partname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partname.HeaderText = "Part Name";
            this.partname.MinimumWidth = 6;
            this.partname.Name = "partname";
            // 
            // batchnumber
            // 
            this.batchnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.batchnumber.HeaderText = "Batch Number";
            this.batchnumber.MinimumWidth = 6;
            this.batchnumber.Name = "batchnumber";
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // idorder
            // 
            this.idorder.HeaderText = "idorder";
            this.idorder.MinimumWidth = 6;
            this.idorder.Name = "idorder";
            this.idorder.Visible = false;
            this.idorder.Width = 125;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Action";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForLinkValue = true;
            this.Remove.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date:";
            // 
            // dateTP
            // 
            this.dateTP.CustomFormat = "yyyy/MM/dd";
            this.dateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP.Location = new System.Drawing.Point(104, 109);
            this.dateTP.Margin = new System.Windows.Forms.Padding(4);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(265, 22);
            this.dateTP.TabIndex = 11;
            // 
            // cb_ware
            // 
            this.cb_ware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ware.FormattingEnabled = true;
            this.cb_ware.Location = new System.Drawing.Point(696, 22);
            this.cb_ware.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ware.Name = "cb_ware";
            this.cb_ware.Size = new System.Drawing.Size(324, 24);
            this.cb_ware.TabIndex = 10;
            // 
            // cb_sup
            // 
            this.cb_sup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sup.FormattingEnabled = true;
            this.cb_sup.Location = new System.Drawing.Point(104, 22);
            this.cb_sup.Margin = new System.Windows.Forms.Padding(4);
            this.cb_sup.Name = "cb_sup";
            this.cb_sup.Size = new System.Drawing.Size(329, 24);
            this.cb_sup.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Warehouse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Suppliers:";
            // 
            // PurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.cb_ware);
            this.Controls.Add(this.cb_sup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrders";
            this.Load += new System.EventHandler(this.PurchaseOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addlist;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bnumber;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.ComboBox cb_ware;
        private System.Windows.Forms.ComboBox cb_sup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.ComboBox cb_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpart;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorder;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.Button btn_capnhat;
    }
}