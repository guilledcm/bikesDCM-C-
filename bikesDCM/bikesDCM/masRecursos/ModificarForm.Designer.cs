namespace bikesDCM.masRecursos
{
    partial class ModificarForm
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
            lblMarca = new Label();
            lblTipo = new Label();
            lblCilindrada = new Label();
            lblPrecio = new Label();
            btnModificar = new Button();
            comboBoxMarca = new ComboBox();
            comboBoxTipo = new ComboBox();
            textBoxCilindrada = new TextBox();
            textBoxPrecio = new TextBox();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(24, 19);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(131, 19);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo";
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.Location = new Point(219, 19);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(61, 15);
            lblCilindrada.TabIndex = 2;
            lblCilindrada.Text = "Cilindrada";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(341, 19);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(447, 37);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Items.AddRange(new object[] { "husqvarna", "ducati", "honda" });
            comboBoxMarca.Location = new Point(12, 55);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(73, 23);
            comboBoxMarca.TabIndex = 5;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "supermotard", "naked", "enduro", "motocross" });
            comboBoxTipo.Location = new Point(112, 55);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(73, 23);
            comboBoxTipo.TabIndex = 6;
            // 
            // textBoxCilindrada
            // 
            textBoxCilindrada.Location = new Point(219, 55);
            textBoxCilindrada.Name = "textBoxCilindrada";
            textBoxCilindrada.Size = new Size(77, 23);
            textBoxCilindrada.TabIndex = 7;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(330, 55);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(77, 23);
            textBoxPrecio.TabIndex = 8;
            // 
            // ModificarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(534, 90);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxCilindrada);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxMarca);
            Controls.Add(btnModificar);
            Controls.Add(lblPrecio);
            Controls.Add(lblCilindrada);
            Controls.Add(lblTipo);
            Controls.Add(lblMarca);
            Name = "ModificarForm";
            Text = "ModificarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblTipo;
        private Label lblCilindrada;
        private Label lblPrecio;
        private Button btnModificar;
        private ComboBox comboBoxMarca;
        private ComboBox comboBoxTipo;
        private TextBox textBoxCilindrada;
        private TextBox textBoxPrecio;
    }
}