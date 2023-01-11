namespace ITSS01
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mstrip_POM = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip_WM = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip_IR = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactiontype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mstrip_POM,
            this.Mstrip_WM,
            this.Mstrip_IR});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mstrip_POM
            // 
            this.Mstrip_POM.Name = "Mstrip_POM";
            this.Mstrip_POM.Size = new System.Drawing.Size(215, 26);
            this.Mstrip_POM.Text = "Purchase Order Management";
            this.Mstrip_POM.Click += new System.EventHandler(this.Mstrip_POM_Click);
            // 
            // Mstrip_WM
            // 
            this.Mstrip_WM.Name = "Mstrip_WM";
            this.Mstrip_WM.Size = new System.Drawing.Size(194, 26);
            this.Mstrip_WM.Text = "Warehouses Management";
            // 
            // Mstrip_IR
            // 
            this.Mstrip_IR.Name = "Mstrip_IR";
            this.Mstrip_IR.Size = new System.Drawing.Size(133, 26);
            this.Mstrip_IR.Text = "Inventory Report";
            // 
            // dgv_1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.transactiontype,
            this.Column3,
            this.amount,
            this.Column5,
            this.Column6,
            this.edit,
            this.delete,
            this.Column7});
            this.dgv_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_1.Location = new System.Drawing.Point(0, 30);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_1.RowHeadersVisible = false;
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_1.Size = new System.Drawing.Size(943, 463);
            this.dgv_1.TabIndex = 1;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            this.dgv_1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "partname";
            this.Column1.HeaderText = "Part Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 92;
            // 
            // transactiontype
            // 
            this.transactiontype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactiontype.DataPropertyName = "transactiontype";
            this.transactiontype.HeaderText = "Transaction Type";
            this.transactiontype.MinimumWidth = 6;
            this.transactiontype.Name = "transactiontype";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "date";
            this.Column3.HeaderText = "Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 65;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 81;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "source";
            this.Column5.HeaderText = "Source";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 79;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "destination";
            this.Column6.HeaderText = "Destination";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 103;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForLinkValue = true;
            this.edit.Width = 36;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForLinkValue = true;
            this.delete.Width = 53;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "idorderitems";
            this.Column7.HeaderText = "idorderitems";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 493);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_POM;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_WM;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_IR;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactiontype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private System.Windows.Forms.DataGridViewLinkColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

