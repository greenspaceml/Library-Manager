using GroupX_HE130699_QuangHoang_Lab3.DTL;
using GroupX_HE130699_QuangHoang_Lab3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupX_HE130699_QuangHoang_Lab3.GUI {
    public partial class MemberGUI : Form {
         BorowerDAO borowerDAO;
        public MemberGUI() {
            InitializeComponent();
            borowerDAO = new BorowerDAO();

            displayMember(BorowerDAO.GetDataTable());
        }

        private void displayMember(DataTable memberDAO) {
            DataTable dt = BorowerDAO.GetDataTable();
            DataView dv = new DataView(dt);
            dataMember.DataSource = dt;
        }

        private void dataMember_CellClick(object sender, DataGridViewCellEventArgs e) {
            txtMemberCode.Text = dataMember.Rows[e.RowIndex].Cells["borrowerNumber"].Value.ToString();
            txtName.Text = dataMember.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtSex.Text = dataMember.Rows[e.RowIndex].Cells["sex"].Value.ToString();
            txtAddress.Text = dataMember.Rows[e.RowIndex].Cells["address"].Value.ToString();
            txtTelephone.Text = dataMember.Rows[e.RowIndex].Cells["telephone"].Value.ToString();
            txtEmail.Text = dataMember.Rows[e.RowIndex].Cells["email"].Value.ToString();
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            displayMember(borowerDAO.FilterMembers());
        }

        private void setEnabled(bool state) {
            txtName.Enabled = state;
            txtSex.Enabled = state;
            txtAddress.Enabled = state;
            txtTelephone.Enabled = state;
            txtEmail.Enabled = state;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (btnAdd.Text.Equals("Add")) {
                btnAdd.Text = "Save";
                setEnabled(true);
            } else {
                int borrowerNumber = int.Parse(txtMemberCode.Text);
                string name = txtName.Text;
                char sex = char.Parse(txtSex.Text);
                string address = txtAddress.Text;
                string telephone = txtTelephone.Text;
                string email = txtEmail.Text;
                Borrower b = new Borrower(borrowerNumber, name, sex, address, telephone, email);
                if (borowerDAO.Insert(b)) {
                    MessageBox.Show("Insert member done!");
                }
                setEnabled(false);
                btnAdd.Text = "Add";
                displayMember(BorowerDAO.GetDataTable());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataMember.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a rows!");
                return;
            }

            if (btnEdit.Text.Equals("Edit")) {
                btnEdit.Text = "Save";
                setEnabled(true);
                txtMemberCode.Enabled = false;
            } else {
                int borrowerNumber = int.Parse(txtMemberCode.Text);
                string name = txtName.Text;
                char sex = char.Parse(txtSex.Text);
                string address = txtAddress.Text;
                string telephone = txtTelephone.Text;
                string email = txtEmail.Text;
                Borrower b = new Borrower(borrowerNumber, name, sex, address, telephone, email);
                if (borowerDAO.Update(b)) {
                    MessageBox.Show("Edit member done!");
                }
                txtMemberCode.Enabled = true;
                setEnabled(false);
                btnEdit.Text = "Edit";
                displayMember(BorowerDAO.GetDataTable());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataMember.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a rows!");
                return;
            }

            string borrowerNumber = txtMemberCode.Text;

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete member with borrowerNumber is " + borrowerNumber, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK) {
                if (borowerDAO.Delete(int.Parse(borrowerNumber))) {
                    MessageBox.Show("Edit member done!");
                    displayMember(BorowerDAO.GetDataTable());
                }
            }
        }
    }
}

