﻿namespace bikesDCM
{
    partial class CarritoForm
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
            flowLayoutPanelCarrito = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelCarrito
            // 
            flowLayoutPanelCarrito.AutoScroll = true;
            flowLayoutPanelCarrito.Dock = DockStyle.Fill;
            flowLayoutPanelCarrito.Location = new Point(0, 0);
            flowLayoutPanelCarrito.Name = "flowLayoutPanelCarrito";
            flowLayoutPanelCarrito.Size = new Size(234, 315);
            flowLayoutPanelCarrito.TabIndex = 0;
            // 
            // CarritoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(234, 315);
            Controls.Add(flowLayoutPanelCarrito);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarritoForm";
            Text = "Carrito";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelCarrito;
    }
}