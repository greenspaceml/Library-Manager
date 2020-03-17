namespace GroupX_HE130699_QuangHoang_Lab3.GUI {
    partial class ReserveGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCheckRevervation = new System.Windows.Forms.Button();
            this.btnCheckMenber = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dtpDate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnReserve);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtDate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCheckRevervation);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCheckMenber);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtName);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtBookNumber);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtMemberCode);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblCode);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtpDate.Location = new System.Drawing.Point(423, 345);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(86, 20);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.Value = new System.DateTime(2020, 3, 14, 18, 35, 40, 0);
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(570, 342);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 12;
            this.btnReserve.Text = "Reverve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.HideSelection = false;
            this.txtDate.Location = new System.Drawing.Point(423, 387);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 11;
            this.txtDate.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(527, 123);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnCheckRevervation
            // 
            this.btnCheckRevervation.Enabled = false;
            this.btnCheckRevervation.Location = new System.Drawing.Point(531, 119);
            this.btnCheckRevervation.Name = "btnCheckRevervation";
            this.btnCheckRevervation.Size = new System.Drawing.Size(150, 23);
            this.btnCheckRevervation.TabIndex = 9;
            this.btnCheckRevervation.Text = "Check reservation condition";
            this.btnCheckRevervation.UseVisualStyleBackColor = true;
            this.btnCheckRevervation.Click += new System.EventHandler(this.btnCheckRevervation_Click);
            // 
            // btnCheckMenber
            // 
            this.btnCheckMenber.Location = new System.Drawing.Point(570, 81);
            this.btnCheckMenber.Name = "btnCheckMenber";
            this.btnCheckMenber.Size = new System.Drawing.Size(111, 23);
            this.btnCheckMenber.TabIndex = 8;
            this.btnCheckMenber.Text = "Check Member";
            this.btnCheckMenber.UseVisualStyleBackColor = true;
            this.btnCheckMenber.Click += new System.EventHandler(this.btnCheckMenber_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(423, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Enabled = false;
            this.txtBookNumber.Location = new System.Drawing.Point(176, 112);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBookNumber.TabIndex = 6;
            this.txtBookNumber.TextChanged += new System.EventHandler(this.txtBookNumber_TextChanged);
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(176, 78);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(100, 20);
            this.txtMemberCode.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "The number of reserve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(95, 81);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(75, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Member code:";
            // 
            // ReserveGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ReserveGUI";
            this.Text = "Reserve";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.Button btnCheckRevervation;
        private System.Windows.Forms.Button btnCheckMenber;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

