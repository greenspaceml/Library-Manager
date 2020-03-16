using GroupX_HE130699_QuangHoang_Lab3.DTL;
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
    public partial class ReserveGUI : Form {
        public ReserveGUI() {
            InitializeComponent();
        }





        private void btnCheckMenber_Click(object sender, EventArgs e) {
            string memberCode = txtMemberCode.Text;
            txtBookNumber.Text = "";
            txtDate.Text = "";
            string name = null;

            DAL.ReserveDAO reserveDB = new DAL.ReserveDAO();
            name = reserveDB.getNameByID(memberCode);
            dataGridView1.DataSource = reserveDB.GetDataTable(memberCode);
            if(name != null) {
                txtName.Text = name;
                txtBookNumber.Enabled = true;
            }
            else {
                txtName.Text = "";
                txtBookNumber.Enabled = false;
            }
        }


        private void txtBookNumber_TextChanged(object sender, EventArgs e) {
            if(txtBookNumber.Text.Equals("")) {
                btnCheckRevervation.Enabled = false;
            }
            else {
                btnCheckRevervation.Enabled = true;
            }
        }

        private void btnCheckRevervation_Click(object sender, EventArgs e) {
            if(dataGridView1.Rows.Count == 1 && checkCopies()) {
                //txtDate.Enabled = true;
                dtpDate.Enabled = true;
                btnReserve.Enabled = true;
            }
            else {
                MessageBox.Show("can't reserve ");
                //txtDate.Enabled = false;
                dtpDate.Enabled = false;
                btnReserve.Enabled = false;
            }
        }

        private bool checkCopies() {
            string bookNumber = txtBookNumber.Text;
            DAL.ReserveDAO reserveDB = new DAL.ReserveDAO();
            int countCopy = reserveDB.countCopy(bookNumber);
            int countCopyBorrowed = reserveDB.countCopyBorrowed(bookNumber);
            if(countCopy == countCopyBorrowed && countCopy > 0)
                return true;
            return false;
        }

        private void btnReserve_Click(object sender, EventArgs e) {

            int borrowerNumber = int.Parse(txtMemberCode.Text);
            int bookNumber = int.Parse(txtBookNumber.Text);
            DateTime dateTime = dtpDate.Value;

            Reservation a = new Reservation(borrowerNumber, bookNumber, dateTime);
            DAL.ReserveDAO reserveDB = new DAL.ReserveDAO();
            reserveDB.Insert(a);
            MessageBox.Show("successful reserve");

            btnReserve.Enabled = false;
            dtpDate.Enabled = false;
            txtBookNumber.Text = "";
            string memberCode = txtMemberCode.Text;
            string name = reserveDB.getNameByID(memberCode);
            dataGridView1.DataSource = reserveDB.GetDataTable(memberCode);
        }
    }
}
