﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupX_HE130699_QuangHoang_Lab3.GUI {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            //label1.EnabledChanged() = ;
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e) {
            BookGUI f = new BookGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutGUI f = new AboutGUI();
            embed(toolStripContainer1.ContentPanel,f);
        }
        private void embed(Panel panel, Form f) {
            panel.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Show();

            panel.Controls.Add(f);

        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e) {
            MemberGUI f = new MemberGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e) {
            BorrowGUI f = new BorrowGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e) {
            ReturnGUI f = new ReturnGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e) {
            ReserveGUI f = new ReserveGUI();
            embed(toolStripContainer1.ContentPanel, f);
        }
    }
}
