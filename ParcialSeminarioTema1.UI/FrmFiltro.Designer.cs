namespace ParcialSeminarioTema1.UI
{
    partial class FrmFiltro
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
            BtnCancelar = new Button();
            BtnOk = new Button();
            TxtGenero = new TextBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.Cancelar;
            BtnCancelar.Location = new Point(373, 146);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 55);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnOk
            // 
            BtnOk.Image = Properties.Resources.Aceptar;
            BtnOk.Location = new Point(38, 146);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 55);
            BtnOk.TabIndex = 5;
            BtnOk.Text = "OK";
            BtnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // TxtGenero
            // 
            TxtGenero.Location = new Point(95, 54);
            TxtGenero.MaxLength = 255;
            TxtGenero.Name = "TxtGenero";
            TxtGenero.Size = new Size(353, 23);
            TxtGenero.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 6;
            label2.Text = "Género:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 229);
            Controls.Add(TxtGenero);
            Controls.Add(label2);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOk);
            MaximumSize = new Size(509, 268);
            MinimumSize = new Size(509, 268);
            Name = "FrmFiltro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFiltro";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnOk;
        private TextBox TxtGenero;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}