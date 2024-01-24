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
            pictureBoxBanderaGif = new PictureBox();
            panelMain = new Panel();
            panelMainBot = new Panel();
            btnGrafico = new Button();
            btnInsert = new Button();
            btnBuscar = new Button();
            textBoxCilindrada = new TextBox();
            lblCilindrada = new Label();
            lblTipo = new Label();
            lblMarca = new Label();
            panelBusqueda = new Panel();
            comboBoxMarca = new ComboBox();
            comboBoxTipo = new ComboBox();
            panelMainBikes = new FlowLayoutPanel();
            panelBot = new Panel();
            lblCopyrigth = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanderaGif).BeginInit();
            panelMain.SuspendLayout();
            panelMainBot.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DimGray;
            panelTop.Controls.Add(imgCarrito);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Controls.Add(pictureBoxBanderaGif);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(997, 74);
            panelTop.TabIndex = 0;
            // 
            // imgCarrito
            // 
            imgCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            imgCarrito.Image = (Image)resources.GetObject("imgCarrito.Image");
            imgCarrito.Location = new Point(926, 12);
            imgCarrito.Name = "imgCarrito";
            imgCarrito.Size = new Size(42, 46);
            imgCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCarrito.TabIndex = 1;
            imgCarrito.TabStop = false;
            imgCarrito.Click += imgCarrito_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(241, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(489, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MotoShop";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBanderaGif
            // 
            pictureBoxBanderaGif.Dock = DockStyle.Fill;
            pictureBoxBanderaGif.Location = new Point(0, 0);
            pictureBoxBanderaGif.Name = "pictureBoxBanderaGif";
            pictureBoxBanderaGif.Size = new Size(997, 74);
            pictureBoxBanderaGif.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBanderaGif.TabIndex = 2;
            pictureBoxBanderaGif.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Controls.Add(panelMainBot);
            panelMain.Controls.Add(btnBuscar);
            panelMain.Controls.Add(textBoxCilindrada);
            panelMain.Controls.Add(lblCilindrada);
            panelMain.Controls.Add(lblTipo);
            panelMain.Controls.Add(lblMarca);
            panelMain.Controls.Add(panelBusqueda);
            panelMain.Controls.Add(panelMainBikes);
            panelMain.Location = new Point(0, 74);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(997, 557);
            panelMain.TabIndex = 2;
            // 
            // panelMainBot
            // 
            panelMainBot.Controls.Add(btnGrafico);
            panelMainBot.Controls.Add(btnInsert);
            panelMainBot.Dock = DockStyle.Bottom;
            panelMainBot.Location = new Point(0, 499);
            panelMainBot.Name = "panelMainBot";
            panelMainBot.Size = new Size(997, 58);
            panelMainBot.TabIndex = 10;
            // 
            // btnGrafico
            // 
            btnGrafico.Location = new Point(655, 18);
            btnGrafico.Name = "btnGrafico";
            btnGrafico.Size = new Size(100, 23);
            btnGrafico.TabIndex = 1;
            btnGrafico.Text = "Grafico";
            btnGrafico.UseVisualStyleBackColor = true;
            btnGrafico.Click += btnGrafico_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(210, 18);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.AutoSize = true;
            btnBuscar.BackColor = Color.Silver;
            btnBuscar.Location = new Point(854, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBoxCilindrada
            // 
            textBoxCilindrada.Location = new Point(655, 20);
            textBoxCilindrada.Name = "textBoxCilindrada";
            textBoxCilindrada.Size = new Size(100, 23);
            textBoxCilindrada.TabIndex = 8;
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCilindrada.Location = new Point(525, 20);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(107, 23);
            lblCilindrada.TabIndex = 7;
            lblCilindrada.Text = "Cilindrada";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(279, 24);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(52, 23);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(12, 21);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(66, 23);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca";
            // 
            // panelBusqueda
            // 
            panelBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBusqueda.AutoSize = true;
            panelBusqueda.Controls.Add(comboBoxMarca);
            panelBusqueda.Controls.Add(comboBoxTipo);
            panelBusqueda.Location = new Point(0, -10);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(997, 106);
            panelBusqueda.TabIndex = 2;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.Items.AddRange(new object[] { "", "ducati", "husqvarna", "honda" });
            comboBoxMarca.Location = new Point(104, 35);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(121, 23);
            comboBoxMarca.TabIndex = 1;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.Items.AddRange(new object[] { "", "supermotard", "naked", "carretera", "motocross", "enduro" });
            comboBoxTipo.Location = new Point(362, 35);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 0;
            // 
            // panelMainBikes
            // 
            panelMainBikes.AutoScroll = true;
            panelMainBikes.BackColor = Color.Transparent;
            panelMainBikes.BackgroundImage = Properties.Resources.fondoRace;
            panelMainBikes.Location = new Point(0, 53);
            panelMainBikes.Name = "panelMainBikes";
            panelMainBikes.Size = new Size(997, 449);
            panelMainBikes.TabIndex = 1;
            // 
            // panelBot
            // 
            panelBot.BackColor = Color.DimGray;
            panelBot.Controls.Add(lblCopyrigth);
            panelBot.Dock = DockStyle.Bottom;
            panelBot.Location = new Point(0, 631);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(997, 38);
            panelBot.TabIndex = 1;
            // 
            // lblCopyrigth
            // 
            lblCopyrigth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCopyrigth.Location = new Point(279, 3);
            lblCopyrigth.Name = "lblCopyrigth";
            lblCopyrigth.Size = new Size(420, 24);
            lblCopyrigth.TabIndex = 0;
            lblCopyrigth.Text = "guilleDCM copyright © todos los derechos reservados";
            lblCopyrigth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(997, 669);
            Controls.Add(panelMain);
            Controls.Add(panelBot);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Catalogo";
            Load += Catalogo_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanderaGif).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelMainBot.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
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
        public Label lblTipo;
        public Label lblMarca;
        public Button btnBuscar;
        public TextBox textBoxCilindrada;
        public Label lblCilindrada;
        public Panel panelBot;
        private Label lblCopyrigth;
        private Panel panelMainBot;
        private Button btnInsert;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxMarca;
        private PictureBox pictureBoxBanderaGif;
        private Button btnGrafico;
    }
}
