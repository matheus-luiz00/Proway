﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseGiomarDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.databaseGiomarDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.DatabaseGiomarDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id);
                        break;
                    }
            }

            this.usuariosTableAdapter.CustomQuery(databaseGiomarDataSet1.Usuarios);
        }
    }
}
