﻿using Vista;
using System;
using System.Windows.Forms;
using Modelo.DTO;
using Modelo.DAO;
using static Vista.utilidadForms;

namespace Controlador
{
    public class controladorPartido
    {
        private formPartido vista;

        // Se declaran los campos que se van a llenar a partir de la fila seleccionada de la tabla
        private int id;

        private string equipo1;
        private string equipo2;
        private string campo;
        private string fecha;
        private string fase;
        private int fkIdCampeonato;
        private int fkIdEmpleado;
        private int fkIdResultado;
        private int fkIdEstado;
        private int fkIdFase;

        private dtoPartido modeloFila = new dtoPartido();

        public controladorPartido(formPartido Vista)
        {
            vista = Vista;
            // Creación de eventos
            vista.Load += new EventHandler(cargarForm);
            vista.tablaPartidos.CellClick += new DataGridViewCellEventHandler(clickCeldaDeLaTabla);
            vista.btnActualizar.Click += new EventHandler(clickActualizarPartido);
            vista.btnAgregarPartido.Click += new EventHandler(clickAgregarPartido);
            vista.btnModificar.Click += new EventHandler(clickModificarPartido);
            vista.btnEliminar.Click += new EventHandler(clickEliminarPartido);
            vista.txtFiltrar.TextChanged += new EventHandler(cambioEnTextoFiltrarPartido);
            vista.cboBuscar.SelectedIndexChanged += new EventHandler(opcionSeleccionadaBuscarPartido);
        }

        public controladorPartido()
        {
        }

        private void cargarForm(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwPartido.vwpartido' Puede moverla o quitarla según sea necesario.
            vista.vwpartidoTableAdapter.Fill(vista.vwPartido.vwpartido);
            vista.cboBuscar.SelectedIndex = 0;
            vista.tablaPartidos.CurrentCell = vista.tablaPartidos.Rows[0].Cells[1];
            llenarModeloConFilaSeleccionada();
        }

        private void clickCeldaDeLaTabla(object sender, DataGridViewCellEventArgs e)
        {
            llenarModeloConFilaSeleccionada();
        }

        private void clickActualizarPartido(object sender, EventArgs e)
        {
            actualizarTablaPartido();
        }

        private void clickAgregarPartido(object sender, EventArgs e)
        {
            abrirForm(new formPartidoEventos(this));
        }

        private void clickModificarPartido(object sender, EventArgs e)
        {
            abrirForm(new formPartidoEventos(modeloFila, this));
        }

        private void opcionSeleccionadaBuscarPartido(object sender, EventArgs e)
        {
            vista.txtFiltrar.Text = "";
        }

        private void clickEliminarPartido(object sender, EventArgs e)
        {
            llenarModeloConFilaSeleccionada();
            daoPartido daoPartido = new daoPartido();
            daoPartido.eliminarPartido(modeloFila);
            actualizarTablaPartido();
        }

        private void cambioEnTextoFiltrarPartido(object sender, EventArgs e)
        {
            filtrarTabla();
        }

        public void actualizarTablaPartido()
        {
            vista.vwpartidoTableAdapter.Fill(vista.vwPartido.vwpartido);
        }

        public void llenarModeloConFilaSeleccionada()
        {
            id = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[0].Value.ToString());
            equipo1 = vista.tablaPartidos.SelectedRows[0].Cells[2].Value.ToString();
            equipo2 = vista.tablaPartidos.SelectedRows[0].Cells[3].Value.ToString();
            campo = vista.tablaPartidos.SelectedRows[0].Cells[4].Value.ToString();
            fecha = vista.tablaPartidos.SelectedRows[0].Cells[9].Value.ToString();
            fkIdEstado = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[5].Value.ToString());
            fkIdCampeonato = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[6].Value.ToString());
            fkIdEmpleado = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[7].Value.ToString());
            fkIdResultado = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[8].Value.ToString());
            fkIdFase = stringAInt(vista.tablaPartidos.SelectedRows[0].Cells[10].Value.ToString());
            modeloFila.pkId = id;
            modeloFila.equipo1 = equipo1;
            modeloFila.equipo2 = equipo2;
            modeloFila.fkIdEstadoPartido = fkIdEstado;
            modeloFila.fkIdCampeonato = fkIdCampeonato;
            modeloFila.fkIdEmpleado = fkIdEmpleado;
            modeloFila.fkIdFase = fkIdFase;
        }

        private void filtrarTabla()
        {
            if (string.IsNullOrEmpty(vista.txtFiltrar.Text))
            {
                vista.vwpartidoBindingSource.Filter = string.Empty;
            }
            else
            {
                vista.vwpartidoBindingSource.Filter = string.Format("{0}='{1}'", vista.cboBuscar.Text, vista.txtFiltrar.Text);
            }
        }
    }
}