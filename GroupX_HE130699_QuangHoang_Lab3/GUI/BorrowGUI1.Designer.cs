namespace GroupX_HE130699_QuangHoang_Lab3.GUI {
    partial class BorrowGUI {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBorrowerNumber = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtBorrowedDate = new System.Windows.Forms.TextBox();
            this.txtCopyNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumberBorrowedBooks = new System.Windows.Forms.Label();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnCondition = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Copy number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Borrow date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Due date:";
            // 
            // txtBorrowerNumber
            // 
            this.txtBorrowerNumber.Enabled = false;
            this.txtBorrowerNumber.Location = new System.Drawing.Point(152, 73);
            this.txtBorrowerNumber.Name = "txtBorrowerNumber";
            this.txtBorrowerNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowerNumber.TabIndex = 5;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Enabled = false;
            this.txtDueDate.Location = new System.Drawing.Point(152, 373);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(100, 20);
            this.txtDueDate.TabIndex = 6;
            // 
            // txtBorrowedDate
            // 
            this.txtBorrowedDate.Enabled = false;
            this.txtBorrowedDate.Location = new System.Drawing.Point(152, 331);
            this.txtBorrowedDate.Name = "txtBorrowedDate";
            this.txtBorrowedDate.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowedDate.TabIndex = 7;
            // 
            // txtCopyNumber
            // 
            this.txtCopyNumber.Location = new System.Drawing.Point(152, 282);
            this.txtCopyNumber.Name = "txtCopyNumber";
            this.txtCopyNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCopyNumber.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(152, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // lblNumberBorrowedBooks
            // 
            this.lblNumberBorrowedBooks.AutoSize = true;
            this.lblNumberBorrowedBooks.Location = new System.Drawing.Point(330, 57);
            this.lblNumberBorrowedBooks.Name = "lblNumberBorrowedBooks";
            this.lblNumberBorrowedBooks.Size = new System.Drawing.Size(147, 13);
            this.lblNumberBorrowedBooks.TabIndex = 10;
            this.lblNumberBorrowedBooks.Text = "Number of borrowed books: 1";
            // 
            // btnMember
            // 
            this.btnMember.Enabled = false;
            this.btnMember.Location = new System.Drawing.Point(131, 167);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(118, 23);
            this.btnMember.TabIndex = 11;
            this.btnMember.Text = "Check member";
            this.btnMember.UseVisualStyleBackColor = true;
            // 
            // btnCondition
            // 
            this.btnCondition.Location = new System.Drawing.Point(386, 308);
            this.btnCondition.Name = "btnCondition";
            this.btnCondition.Size = new System.Drawing.Size(156, 23);
            this.btnCondition.TabIndex = 12;
            this.btnCondition.Text = "Check borrow condition";
            this.btnCondition.UseVisualStyleBackColor = true;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Enabled = false;
            this.btnBorrow.Location = new System.Drawing.Point(386, 363);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(156, 23);
            this.btnBorrow.TabIndex = 13;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // BorrowGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnCondition);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.lblNumberBorrowedBooks);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCopyNumber);
            this.Controls.Add(this.txtBorrowedDate);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtBorrowerNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BorrowGUI";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBorrowerNumber;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtBorrowedDate;
        private System.Windows.Forms.TextBox txtCopyNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNumberBorrowedBooks;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnCondition;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}