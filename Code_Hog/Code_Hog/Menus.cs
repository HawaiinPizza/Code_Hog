﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Hog {
    public partial class Menus : Form {
        public Menus() {
            InitializeComponent();
        }

        private void Menus_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'codeHogDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.codeHogDataSet1.Users);
            // TODO: This line of code loads data into the 'codeHogDataSet1.User_Roles' table. You can move, or remove it, as needed.
            this.user_RolesTableAdapter.Fill(this.codeHogDataSet1.User_Roles);
            // TODO: This line of code loads data into the 'codeHogDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.codeHogDataSet.Tickets);

        }

        private void ticketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }
    }
}
