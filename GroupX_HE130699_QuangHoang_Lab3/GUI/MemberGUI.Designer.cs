namespace GroupX_HE130699_QuangHoang_Lab3.GUI {
    partial class MemberGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.lbMemberCode = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMemberCode
            // 
            this.lbMemberCode.AutoSize = true;
            this.lbMemberCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberCode.Location = new System.Drawing.Point(18, 113);
            this.lbMemberCode.Name = "lbMemberCode";
            this.lbMemberCode.Size = new System.Drawing.Size(95, 16);
            this.lbMemberCode.TabIndex = 0;
            this.lbMemberCode.Text = "Member code:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(65, 138);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(79, 167);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(34, 16);
            this.lbSex.TabIndex = 2;
            this.lbSex.Text = "Sex:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(51, 192);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(62, 16);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Address:";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelephone.Location = new System.Drawing.Point(36, 218);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(77, 16);
            this.lbTelephone.TabIndex = 4;
            this.lbTelephone.Text = "Telephone:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(68, 246);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 16);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email:";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(119, 112);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(157, 20);
            this.txtMemberCode.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(119, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtSex
            // 
            this.txtSex.Enabled = false;
            this.txtSex.Location = new System.Drawing.Point(119, 164);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(30, 20);
            this.txtSex.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(119, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Enabled = false;
            this.txtTelephone.Location = new System.Drawing.Point(119, 214);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(157, 20);
            this.txtTelephone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(119, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(119, 349);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(367, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(478, 349);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(596, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataMember
            // 
            this.dataMember.AllowUserToAddRows = false;
            this.dataMember.AllowUserToDeleteRows = false;
            this.dataMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMember.Location = new System.Drawing.Point(292, 36);
            this.dataMember.Name = "dataMember";
            this.dataMember.ReadOnly = true;
            this.dataMember.Size = new System.Drawing.Size(645, 284);
            this.dataMember.TabIndex = 16;
            this.dataMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMember_CellClick);
            // 
            // MemberGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 410);
            this.Controls.Add(this.dataMember);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMemberCode);
            this.Name = "MemberGUI";
            this.Text = "MemberGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMemberCode;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataMember;
    }
}