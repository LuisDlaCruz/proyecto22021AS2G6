﻿
using Datos;

namespace Vista
{
    partial class formEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEquipo));
            this.tablaEquipo = new Zuby.ADGV.AdvancedDataGridView();
            this.vwequipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwEquipo = new Datos.vwEquipo();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.btnActualizarEquipo = new System.Windows.Forms.Button();
            this.panelBuscarCol = new System.Windows.Forms.Panel();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.vwequipoTableAdapter = new Datos.vwEquipoTableAdapters.vwequipoTableAdapter();
            this.pkIdEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkIdDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwequipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEquipo)).BeginInit();
            this.parrotGradientPanel1.SuspendLayout();
            this.panelBuscarCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEquipo
            // 
            this.tablaEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaEquipo.AutoGenerateColumns = false;
            this.tablaEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEquipo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaEquipo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaEquipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdEquipoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pkIdDeporteDataGridViewTextBoxColumn,
            this.deporteDataGridViewTextBoxColumn});
            this.tablaEquipo.DataSource = this.vwequipoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaEquipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEquipo.FilterAndSortEnabled = true;
            this.tablaEquipo.Location = new System.Drawing.Point(69, 139);
            this.tablaEquipo.Name = "tablaEquipo";
            this.tablaEquipo.ReadOnly = true;
            this.tablaEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablaEquipo.RowHeadersVisible = false;
            this.tablaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaEquipo.Size = new System.Drawing.Size(768, 413);
            this.tablaEquipo.TabIndex = 5;
            this.tablaEquipo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tablaEquipo_DataError);
            // 
            // vwequipoBindingSource
            // 
            this.vwequipoBindingSource.DataMember = "vwequipo";
            this.vwequipoBindingSource.DataSource = this.vwEquipo;
            // 
            // vwEquipo
            // 
            this.vwEquipo.DataSetName = "vwEquipo";
            this.vwEquipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotGradientPanel1.Controls.Add(this.btnEliminarEquipo);
            this.parrotGradientPanel1.Controls.Add(this.btnActualizarEquipo);
            this.parrotGradientPanel1.Controls.Add(this.panelBuscarCol);
            this.parrotGradientPanel1.Controls.Add(this.panel2);
            this.parrotGradientPanel1.Controls.Add(this.btnModificarEquipo);
            this.parrotGradientPanel1.Controls.Add(this.btnAgregarEquipo);
            this.parrotGradientPanel1.Controls.Add(this.tablaEquipo);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(900, 595);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 8;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.CornflowerBlue;
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEquipo.BackColor = System.Drawing.Color.White;
            this.btnEliminarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEquipo.FlatAppearance.BorderSize = 0;
            this.btnEliminarEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEquipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEquipo.Image")));
            this.btnEliminarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEquipo.Location = new System.Drawing.Point(627, 36);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEliminarEquipo.Size = new System.Drawing.Size(210, 36);
            this.btnEliminarEquipo.TabIndex = 33;
            this.btnEliminarEquipo.Text = "   E L I M I N A R";
            this.btnEliminarEquipo.UseVisualStyleBackColor = false;
            // 
            // btnActualizarEquipo
            // 
            this.btnActualizarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEquipo.BackColor = System.Drawing.Color.White;
            this.btnActualizarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEquipo.FlatAppearance.BorderSize = 0;
            this.btnActualizarEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEquipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarEquipo.Image")));
            this.btnActualizarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEquipo.Location = new System.Drawing.Point(392, 36);
            this.btnActualizarEquipo.Name = "btnActualizarEquipo";
            this.btnActualizarEquipo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnActualizarEquipo.Size = new System.Drawing.Size(210, 36);
            this.btnActualizarEquipo.TabIndex = 32;
            this.btnActualizarEquipo.Text = "      A C T U A L I Z A R";
            this.btnActualizarEquipo.UseVisualStyleBackColor = false;
            // 
            // panelBuscarCol
            // 
            this.panelBuscarCol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuscarCol.BackColor = System.Drawing.Color.White;
            this.panelBuscarCol.Controls.Add(this.cboBuscar);
            this.panelBuscarCol.Controls.Add(this.pictureBox2);
            this.panelBuscarCol.Location = new System.Drawing.Point(69, 36);
            this.panelBuscarCol.Name = "panelBuscarCol";
            this.panelBuscarCol.Size = new System.Drawing.Size(299, 36);
            this.panelBuscarCol.TabIndex = 31;
            // 
            // cboBuscar
            // 
            this.cboBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "nombre",
            "deporte"});
            this.cboBuscar.Location = new System.Drawing.Point(36, 6);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(263, 26);
            this.cboBuscar.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtFiltrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(69, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 36);
            this.panel2.TabIndex = 30;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(37, 9);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(252, 20);
            this.txtFiltrar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarEquipo
            // 
            this.btnModificarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarEquipo.BackColor = System.Drawing.Color.White;
            this.btnModificarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEquipo.FlatAppearance.BorderSize = 0;
            this.btnModificarEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEquipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnModificarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarEquipo.Image")));
            this.btnModificarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEquipo.Location = new System.Drawing.Point(627, 85);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnModificarEquipo.Size = new System.Drawing.Size(210, 36);
            this.btnModificarEquipo.TabIndex = 28;
            this.btnModificarEquipo.Text = "    M O D I F I C A R";
            this.btnModificarEquipo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEquipo.BackColor = System.Drawing.Color.White;
            this.btnAgregarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEquipo.FlatAppearance.BorderSize = 0;
            this.btnAgregarEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEquipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEquipo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEquipo.Image")));
            this.btnAgregarEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(392, 85);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAgregarEquipo.Size = new System.Drawing.Size(210, 36);
            this.btnAgregarEquipo.TabIndex = 27;
            this.btnAgregarEquipo.Text = "     A G R E G A R";
            this.btnAgregarEquipo.UseVisualStyleBackColor = false;
            // 
            // vwequipoTableAdapter
            // 
            this.vwequipoTableAdapter.ClearBeforeFill = true;
            // 
            // pkIdEquipoDataGridViewTextBoxColumn
            // 
            this.pkIdEquipoDataGridViewTextBoxColumn.DataPropertyName = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.HeaderText = "pkIdEquipo";
            this.pkIdEquipoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdEquipoDataGridViewTextBoxColumn.Name = "pkIdEquipoDataGridViewTextBoxColumn";
            this.pkIdEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdEquipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pkIdDeporteDataGridViewTextBoxColumn
            // 
            this.pkIdDeporteDataGridViewTextBoxColumn.DataPropertyName = "pkIdDeporte";
            this.pkIdDeporteDataGridViewTextBoxColumn.HeaderText = "pkIdDeporte";
            this.pkIdDeporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.pkIdDeporteDataGridViewTextBoxColumn.Name = "pkIdDeporteDataGridViewTextBoxColumn";
            this.pkIdDeporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkIdDeporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.pkIdDeporteDataGridViewTextBoxColumn.Visible = false;
            // 
            // deporteDataGridViewTextBoxColumn
            // 
            this.deporteDataGridViewTextBoxColumn.DataPropertyName = "deporte";
            this.deporteDataGridViewTextBoxColumn.HeaderText = "deporte";
            this.deporteDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.deporteDataGridViewTextBoxColumn.Name = "deporteDataGridViewTextBoxColumn";
            this.deporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.deporteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // formEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 595);
            this.Controls.Add(this.parrotGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEquipo";
            this.Text = "formEquipo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwequipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEquipo)).EndInit();
            this.parrotGradientPanel1.ResumeLayout(false);
            this.panelBuscarCol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelBuscarCol;
        public System.Windows.Forms.PictureBox pictureBox2;
        public vwEquipo vwEquipo;
        public System.Windows.Forms.BindingSource vwequipoBindingSource;
        public Datos.vwEquipoTableAdapters.vwequipoTableAdapter vwequipoTableAdapter;
        public Zuby.ADGV.AdvancedDataGridView tablaEquipo;
        public System.Windows.Forms.Button btnAgregarEquipo;
        public System.Windows.Forms.Button btnModificarEquipo;
        public System.Windows.Forms.TextBox txtFiltrar;
        public System.Windows.Forms.ComboBox cboBuscar;
        public System.Windows.Forms.Button btnActualizarEquipo;
        public System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deporteDataGridViewTextBoxColumn;
    }
}