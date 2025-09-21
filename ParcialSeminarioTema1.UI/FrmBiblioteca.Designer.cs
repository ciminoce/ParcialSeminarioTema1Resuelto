namespace ParcialSeminarioTema1.UI
{
    partial class FrmBiblioteca
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            TxtRegistros = new TextBox();
            label1 = new Label();
            TsbNuevo = new ToolStripButton();
            TsbBorrar = new ToolStripButton();
            TsbBorrarGenero = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbFiltrar = new ToolStripButton();
            TsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbCerrar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 62);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtRegistros);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 555);
            splitContainer1.SplitterDistance = 444;
            splitContainer1.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colTitulo, colGenero });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 444);
            dgvDatos.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colTitulo
            // 
            colTitulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitulo.HeaderText = "Título";
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            // 
            // colGenero
            // 
            colGenero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGenero.HeaderText = "Género";
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            // 
            // TxtRegistros
            // 
            TxtRegistros.Location = new Point(98, 38);
            TxtRegistros.Name = "TxtRegistros";
            TxtRegistros.ReadOnly = true;
            TxtRegistros.Size = new Size(85, 23);
            TxtRegistros.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 17;
            label1.Text = "Registros:";
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Properties.Resources.Nuevo;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(46, 59);
            TsbNuevo.Text = "Nuevo";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevo.Click += TsbNuevo_Click;
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = Properties.Resources.Delete;
            TsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(44, 59);
            TsbBorrar.Text = "Borrar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrar.Click += TsbBorrar_Click;
            // 
            // TsbBorrarGenero
            // 
            TsbBorrarGenero.Image = Properties.Resources.delete_property_40px;
            TsbBorrarGenero.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrarGenero.ImageTransparentColor = Color.Magenta;
            TsbBorrarGenero.Name = "TsbBorrarGenero";
            TsbBorrarGenero.Size = new Size(84, 59);
            TsbBorrarGenero.Text = "Borrar Género";
            TsbBorrarGenero.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrarGenero.Click += TsbBorrarGenero_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // TsbFiltrar
            // 
            TsbFiltrar.Image = Properties.Resources.filter_40px;
            TsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrar.ImageTransparentColor = Color.Magenta;
            TsbFiltrar.Name = "TsbFiltrar";
            TsbFiltrar.Size = new Size(44, 59);
            TsbFiltrar.Text = "Filtrar";
            TsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbFiltrar.Click += TsbFiltrar_Click;
            // 
            // TsbActualizar
            // 
            TsbActualizar.Image = Properties.Resources.Update;
            TsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizar.ImageTransparentColor = Color.Magenta;
            TsbActualizar.Name = "TsbActualizar";
            TsbActualizar.Size = new Size(63, 59);
            TsbActualizar.Text = "Actualizar";
            TsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbActualizar.Click += TsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // TsbCerrar
            // 
            TsbCerrar.Image = Properties.Resources.Close;
            TsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbCerrar.ImageTransparentColor = Color.Magenta;
            TsbCerrar.Name = "TsbCerrar";
            TsbCerrar.Size = new Size(44, 59);
            TsbCerrar.Text = "Cerrar";
            TsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbCerrar.Click += TsbCerrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbBorrar, TsbBorrarGenero, toolStripSeparator1, TsbFiltrar, TsbActualizar, toolStripSeparator2, TsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 62);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmBiblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            Load += FrmBiblioteca_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private TextBox TxtRegistros;
        private Label label1;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbBorrar;
        private ToolStripButton TsbBorrarGenero;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbFiltrar;
        private ToolStripButton TsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbCerrar;
        private ToolStrip toolStrip1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colGenero;
    }
}