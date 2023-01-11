namespace ITSS02
{
    partial class Main
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(12, 69);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(1061, 361);
            this.dgv_1.TabIndex = 0;
            this.dgv_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellClick);
            this.dgv_1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_1_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Assets:";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(12, 445);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(314, 23);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send Emergency Maintenance Request ";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 481);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Send;
    }
}