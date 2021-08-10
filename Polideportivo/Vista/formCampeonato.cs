﻿using Controlador;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using static Vista.utilidadForms;

namespace Vista
{
    public partial class formCampeonato : Form
    {
        public formCampeonato()
        {
            InitializeComponent();
            controladorCampeonato controladorCampeonato = new controladorCampeonato(this);
        }

        private void tablaCampeonatos_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show(anError.RowIndex + " " + anError.ColumnIndex);
            //MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                //MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                //MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                //MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                //MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                //DataGridView view = (DataGridView)sender;
                //view.Rows[anError.RowIndex].ErrorText = "an error";
                //view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                //anError.ThrowException = false;
            }
        }
    }
}