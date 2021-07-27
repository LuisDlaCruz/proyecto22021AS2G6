﻿using Polideportivo.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo
{
    public partial class formPolideportivo : Form
    {
        public formPolideportivo()
        {
            InitializeComponent();
        }

        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MenuLateralWrapPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLateral_Click(object sender, EventArgs e)
        {
            if (panelLateralInterno.Width >= 270)
            {
                panelLateralInterno.Width = 68;
                panelLateralWrapper.Width = 90;
                separadorLogo.Width = 52;
            }
            else
            {
                panelLateralInterno.Width = 270;
                panelLateralWrapper.Width = 300;
                separadorLogo.Width = 252;
            }
                  
        }

        private void ContenidoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btnDeportes_Click(object sender, EventArgs e)
        {
            if (formActivo == null)
            {
                formActivo = new formJugador();
                abrirFormHijo(formActivo);
            }
            else
            {
                formActivo.Close();
                formActivo = null;
            }
            
        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formHijo);
            panelPrincipal.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

    }


}
