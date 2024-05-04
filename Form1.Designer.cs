namespace pryEtapa4Ambordt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerar = new Button();
            btnListar = new Button();
            pctImagen = new PictureBox();
            lblTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)pctImagen).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(56, 48);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(56, 245);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // pctImagen
            // 
            pctImagen.Location = new Point(180, 48);
            pctImagen.Name = "pctImagen";
            pctImagen.Size = new Size(313, 174);
            pctImagen.TabIndex = 2;
            pctImagen.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.BackColor = SystemColors.ControlDark;
            lblTipo.Location = new Point(180, 245);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(100, 23);
            lblTipo.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 301);
            Controls.Add(lblTipo);
            Controls.Add(pctImagen);
            Controls.Add(btnListar);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerar;
        private Button btnListar;
        private PictureBox pctImagen;
        private Label lblTipo;
    }
}
