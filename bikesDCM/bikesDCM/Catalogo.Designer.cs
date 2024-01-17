namespace bikesDCM
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            panelTop = new Panel();
            imgCarrito = new PictureBox();
            lblTitulo = new Label();
            panelMain = new Panel();
            btnBuscar = new Button();
            textBoxCilindrada = new TextBox();
            lblCilindrada = new Label();
            textBoxTipo = new TextBox();
            lblTipo = new Label();
            textBoxMarca = new TextBox();
            lblMarca = new Label();
            panelBusqueda = new Panel();
            panelMainBikes = new FlowLayoutPanel();
            panelBot = new Panel();
            lblCopyrigth = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCarrito).BeginInit();
            panelMain.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DimGray;
            panelTop.Controls.Add(imgCarrito);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(871, 74);
            panelTop.TabIndex = 0;
            // 
            // imgCarrito
            // 
            imgCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            imgCarrito.Image = (Image)resources.GetObject("imgCarrito.Image");
            imgCarrito.Location = new Point(800, 12);
            imgCarrito.Name = "imgCarrito";
            imgCarrito.Size = new Size(40, 40);
            imgCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCarrito.TabIndex = 1;
            imgCarrito.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(241, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(363, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MOTOSHOP";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Controls.Add(btnBuscar);
            panelMain.Controls.Add(textBoxCilindrada);
            panelMain.Controls.Add(lblCilindrada);
            panelMain.Controls.Add(textBoxTipo);
            panelMain.Controls.Add(lblTipo);
            panelMain.Controls.Add(textBoxMarca);
            panelMain.Controls.Add(lblMarca);
            panelMain.Controls.Add(panelBusqueda);
            panelMain.Controls.Add(panelMainBikes);
            panelMain.Location = new Point(0, 74);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(871, 461);
            panelMain.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.AutoSize = true;
            btnBuscar.BackColor = Color.Silver;
            btnBuscar.Location = new Point(748, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxCilindrada
            // 
            textBoxCilindrada.Location = new Point(596, 20);
            textBoxCilindrada.Name = "textBoxCilindrada";
            textBoxCilindrada.Size = new Size(100, 23);
            textBoxCilindrada.TabIndex = 8;
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCilindrada.Location = new Point(483, 20);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(107, 23);
            lblCilindrada.TabIndex = 7;
            lblCilindrada.Text = "Cilindrada";
            // 
            // textBoxTipo
            // 
            textBoxTipo.Location = new Point(337, 20);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(100, 23);
            textBoxTipo.TabIndex = 6;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(279, 20);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(52, 23);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(119, 20);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(100, 23);
            textBoxMarca.TabIndex = 4;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(47, 20);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(66, 23);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBusqueda.AutoSize = true;
            panelBusqueda.Location = new Point(0, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(871, 0);
            panelBusqueda.TabIndex = 2;
            // 
            // panelMainBikes
            // 
            panelMainBikes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelMainBikes.Location = new Point(0, 64);
            panelMainBikes.Name = "panelMainBikes";
            panelMainBikes.Size = new Size(871, 397);
            panelMainBikes.TabIndex = 1;
            // 
            // panelBot
            // 
            panelBot.BackColor = Color.DimGray;
            panelBot.Controls.Add(lblCopyrigth);
            panelBot.Dock = DockStyle.Bottom;
            panelBot.Location = new Point(0, 535);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(871, 38);
            panelBot.TabIndex = 1;
            // 
            // lblCopyrigth
            // 
            lblCopyrigth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCopyrigth.Location = new Point(279, 3);
            lblCopyrigth.Name = "lblCopyrigth";
            lblCopyrigth.Size = new Size(294, 24);
            lblCopyrigth.TabIndex = 0;
            lblCopyrigth.Text = "guilleDCM copyright © todos los derechos reservados";
            lblCopyrigth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(871, 573);
            Controls.Add(panelMain);
            Controls.Add(panelBot);
            Controls.Add(panelTop);
            Name = "Catalogo";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCarrito).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelBot.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panelTop;
        public Label lblTitulo;
        public Panel panelMain;
        public PictureBox imgCarrito;
        public FlowLayoutPanel panelMainBikes;
        public Panel panelBusqueda;
        public TextBox textBoxTipo;
        public Label lblTipo;
        public TextBox textBoxMarca;
        public Label lblMarca;
        public Button btnBuscar;
        public TextBox textBoxCilindrada;
        public Label lblCilindrada;
        public Panel panelBot;
        private Label lblCopyrigth;
    }
}
