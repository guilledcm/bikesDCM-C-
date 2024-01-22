namespace bikesDCM
{
    partial class InsertarForm
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
            comboBoxMarca = new ComboBox();
            comboBoxTipo = new ComboBox();
            textBoxCilindrada = new TextBox();
            textBoxPrecio = new TextBox();
            btnGo = new Button();
            lblMarca = new Label();
            lblTipo = new Label();
            lblCilindrada = new Label();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Items.AddRange(new object[] { "husqvarna", "ducati", "honda" });
            comboBoxMarca.Location = new Point(12, 57);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(121, 23);
            comboBoxMarca.TabIndex = 0;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "supermotard", "naked", "enduro", "motocross" });
            comboBoxTipo.Location = new Point(175, 57);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 1;
            // 
            // textBoxCilindrada
            // 
            textBoxCilindrada.Location = new Point(341, 57);
            textBoxCilindrada.Name = "textBoxCilindrada";
            textBoxCilindrada.Size = new Size(100, 23);
            textBoxCilindrada.TabIndex = 2;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(488, 57);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(100, 23);
            textBoxPrecio.TabIndex = 3;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(625, 57);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(42, 23);
            btnGo.TabIndex = 4;
            btnGo.Text = "GO!";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.LightGray;
            lblMarca.Location = new Point(49, 29);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.LightGray;
            lblTipo.Location = new Point(219, 29);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.BackColor = Color.LightGray;
            lblCilindrada.Location = new Point(360, 29);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(61, 15);
            lblCilindrada.TabIndex = 7;
            lblCilindrada.Text = "Cilindrada";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.LightGray;
            lblPrecio.Location = new Point(517, 29);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // InsertarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(714, 92);
            Controls.Add(lblPrecio);
            Controls.Add(lblCilindrada);
            Controls.Add(lblTipo);
            Controls.Add(lblMarca);
            Controls.Add(btnGo);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxCilindrada);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxMarca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMarca;
        private ComboBox comboBoxTipo;
        private TextBox textBoxCilindrada;
        private TextBox textBoxPrecio;
        private Button btnGo;
        private Label lblMarca;
        private Label lblTipo;
        private Label lblCilindrada;
        private Label lblPrecio;
    }
}