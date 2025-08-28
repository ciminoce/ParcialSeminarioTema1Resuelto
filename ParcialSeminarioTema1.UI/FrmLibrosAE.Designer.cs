namespace ParcialSeminarioTema1.UI
{
    partial class FrmLibrosAE
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            TxtCodigo = new TextBox();
            label2 = new Label();
            TxtTitulo = new TextBox();
            label3 = new Label();
            TxtSinopsis = new TextBox();
            label4 = new Label();
            CboGeneros = new ComboBox();
            BtnOk = new Button();
            BtnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 51);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(118, 48);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.ReadOnly = true;
            TxtCodigo.Size = new Size(133, 23);
            TxtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 90);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Título:";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(118, 87);
            TxtTitulo.MaxLength = 255;
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(450, 23);
            TxtTitulo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 131);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "Sinopsis:";
            // 
            // TxtSinopsis
            // 
            TxtSinopsis.Location = new Point(118, 128);
            TxtSinopsis.MaxLength = 400;
            TxtSinopsis.Multiline = true;
            TxtSinopsis.Name = "TxtSinopsis";
            TxtSinopsis.Size = new Size(450, 96);
            TxtSinopsis.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 256);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 0;
            label4.Text = "Género:";
            // 
            // CboGeneros
            // 
            CboGeneros.DropDownStyle = ComboBoxStyle.DropDownList;
            CboGeneros.FormattingEnabled = true;
            CboGeneros.Location = new Point(121, 252);
            CboGeneros.Name = "CboGeneros";
            CboGeneros.Size = new Size(196, 23);
            CboGeneros.TabIndex = 2;
            // 
            // BtnOk
            // 
            BtnOk.Image = Properties.Resources.Aceptar;
            BtnOk.Location = new Point(72, 304);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 55);
            BtnOk.TabIndex = 3;
            BtnOk.Text = "OK";
            BtnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.Cancelar;
            BtnCancelar.Location = new Point(493, 304);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 55);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmLibrosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 386);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOk);
            Controls.Add(CboGeneros);
            Controls.Add(TxtSinopsis);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtTitulo);
            Controls.Add(label2);
            Controls.Add(TxtCodigo);
            Controls.Add(label1);
            MaximumSize = new Size(646, 425);
            MinimumSize = new Size(646, 425);
            Name = "FrmLibrosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibrosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox TxtSinopsis;
        private Label label4;
        private Label label3;
        private TextBox TxtTitulo;
        private Label label2;
        private TextBox TxtCodigo;
        private Label label1;
        private Button BtnCancelar;
        private Button BtnOk;
        private ComboBox CboGeneros;
    }
}