﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Add;
using MVCProject.Edit;

namespace MVCProject.View
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillComInnerJoin(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            frmAddLivro frmAdd = new frmAddLivro();
            frmAdd.ShowDialog();
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }
        MVCProject.SistemaBibliotecaDBDataSet.LivrosRow rowSelecionada;
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(e.RowIndex == -1))
                rowSelecionada = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (rowSelecionada != null)
            {
            frmEditarLivros telaEditar = new frmEditarLivros();
            telaEditar.livrosRow = rowSelecionada;
            telaEditar.ShowDialog();
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            
                if (rowSelecionada != null)
            {
                frmLivroAutor telaAutor = new frmLivroAutor();
                telaAutor.livrosRow = rowSelecionada;
                telaAutor.ShowDialog();
                this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            }
            else
                MessageBox.Show("Selecione um registro para alterar");
        }
    }
}
