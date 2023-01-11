namespace ITSS02
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
            this.lb_dp = new System.Windows.Forms.Label();
            this.lb_aname = new System.Windows.Forms.Label();
            this.lb_asn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_priority = new System.Windows.Forms.ComboBox();
            this.txt_oc = new System.Windows.Forms.TextBox();
            this.txt_de = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSentReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_dp
            // 
            this.lb_dp.AutoSize = true;
            this.lb_dp.Location = new System.Drawing.Point(567, 48);
            this.lb_dp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dp.Name = "lb_dp";
            this.lb_dp.Size = new System.Drawing.Size(44, 16);
            this.lb_dp.TabIndex = 5;
            this.lb_dp.Text = "label9";
            // 
            // lb_aname
            // 
            this.lb_aname.AutoSize = true;
            this.lb_aname.Location = new System.Drawing.Point(312, 48);
            this.lb_aname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_aname.Name = "lb_aname";
            this.lb_aname.Size = new System.Drawing.Size(44, 16);
            this.lb_aname.TabIndex = 4;
            this.lb_aname.Text = "label8";
            // 
            // lb_asn
            // 
            this.lb_asn.AutoSize = true;
            this.lb_asn.Location = new System.Drawing.Point(117, 48);
            this.lb_asn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_asn.Name = "lb_asn";
            this.lb_asn.Size = new System.Drawing.Size(44, 16);
            this.lb_asn.TabIndex = 3;
            this.lb_asn.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "AssetName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "AssetSN:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(405, 466);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_dp);
            this.groupBox1.Controls.Add(this.lb_aname);
            this.groupBox1.Controls.Add(this.lb_asn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(669, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset";
            // 
            // cb_priority
            // 
            this.cb_priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_priority.FormattingEnabled = true;
            this.cb_priority.Location = new System.Drawing.Point(147, 34);
            this.cb_priority.Margin = new System.Windows.Forms.Padding(4);
            this.cb_priority.Name = "cb_priority";
            this.cb_priority.Size = new System.Drawing.Size(418, 24);
            this.cb_priority.TabIndex = 9;
            // 
            // txt_oc
            // 
            this.txt_oc.Location = new System.Drawing.Point(147, 218);
            this.txt_oc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_oc.Name = "txt_oc";
            this.txt_oc.Size = new System.Drawing.Size(418, 22);
            this.txt_oc.TabIndex = 8;
            // 
            // txt_de
            // 
            this.txt_de.Location = new System.Drawing.Point(147, 138);
            this.txt_de.Margin = new System.Windows.Forms.Padding(4);
            this.txt_de.Name = "txt_de";
            this.txt_de.Size = new System.Drawing.Size(418, 22);
            this.txt_de.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = " Other Considerations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description of Emergency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priority:";
            // 
            // btnSentReport
            // 
            this.btnSentReport.Location = new System.Drawing.Point(239, 471);
            this.btnSentReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSentReport.Name = "btnSentReport";
            this.btnSentReport.Size = new System.Drawing.Size(100, 28);
            this.btnSentReport.TabIndex = 10;
            this.btnSentReport.Text = "Send Report";
            this.btnSentReport.UseVisualStyleBackColor = true;
            this.btnSentReport.Click += new System.EventHandler(this.btnSentReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_priority);
            this.groupBox2.Controls.Add(this.txt_oc);
            this.groupBox2.Controls.Add(this.txt_de);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(63, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(669, 284);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Report";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSentReport);
            this.Controls.Add(this.groupBox2);
            this.Name = "Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_dp;
        private System.Windows.Forms.Label lb_aname;
        private System.Windows.Forms.Label lb_asn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_priority;
        private System.Windows.Forms.TextBox txt_oc;
        private System.Windows.Forms.TextBox txt_de;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSentReport;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}