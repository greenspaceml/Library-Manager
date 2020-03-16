namespace GroupX_HE130699_QuangHoang_Lab3.GUI {
    partial class ReturnGUI {
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
            this.btnMember = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBorrowerNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNumberBorrowedBooks = new System.Windows.Forms.Label();
            this.txtReturnedDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFine = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.Enabled = false;
            this.btnMember.Location = new System.Drawing.Point(310, 38);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(118, 23);
            this.btnMember.TabIndex = 16;
            this.btnMember.Text = "Check member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(144, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 15;
            // 
            // txtBorrowerNumber
            // 
            this.txtBorrowerNumber.Enabled = false;
            this.txtBorrowerNumber.Location = new System.Drawing.Point(144, 40);
            this.txtBorrowerNumber.Name = "txtBorrowerNumber";
            this.txtBorrowerNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowerNumber.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Member code:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // lblNumberBorrowedBooks
            // 
            this.lblNumberBorrowedBooks.AutoSize = true;
            this.lblNumberBorrowedBooks.Location = new System.Drawing.Point(27, 115);
            this.lblNumberBorrowedBooks.Name = "lblNumberBorrowedBooks";
            this.lblNumberBorrowedBooks.Size = new System.Drawing.Size(147, 13);
            this.lblNumberBorrowedBooks.TabIndex = 17;
            this.lblNumberBorrowedBooks.Text = "Number of borrowed books: 1";
            // 
            // txtReturnedDate
            // 
            this.txtReturnedDate.Enabled = false;
            this.txtReturnedDate.Location = new System.Drawing.Point(144, 298);
            this.txtReturnedDate.Name = "txtReturnedDate";
            this.txtReturnedDate.Size = new System.Drawing.Size(100, 20);
            this.txtReturnedDate.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Returned date:";
            // 
            // btnFine
            // 
            this.btnFine.Location = new System.Drawing.Point(66, 350);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(85, 23);
            this.btnFine.TabIndex = 25;
            this.btnFine.Text = "Confirm Fine";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(157, 350);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(69, 23);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Enabled = false;
            this.txtFineAmount.Location = new System.Drawing.Point(604, 305);
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.Size = new System.Drawing.Size(100, 20);
            this.txtFineAmount.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fine Amount:";
            // 
            // ReturnGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFineAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.txtReturnedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNumberBorrowedBooks);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBorrowerNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReturnGUI";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBorrowerNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNumberBorrowedBooks;
        private System.Windows.Forms.TextBox txtReturnedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label label3;
    }
}