namespace Supermarker_mvp.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPayMode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnProviders = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnProviders);
            this.panel1.Controls.Add(this.BtnProducts);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnPayMode);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::Supermarker_mvp.Properties.Resources.exit;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.Location = new System.Drawing.Point(0, 377);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(200, 73);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            this.BtnPayMode.BackgroundImage = global::Supermarker_mvp.Properties.Resources.buy1;
            this.BtnPayMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPayMode.Location = new System.Drawing.Point(3, 73);
            this.BtnPayMode.Name = "BtnPayMode";
            this.BtnPayMode.Size = new System.Drawing.Size(194, 72);
            this.BtnPayMode.TabIndex = 1;
            this.BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarker_mvp.Properties.Resources.sell;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackgroundImage = global::Supermarker_mvp.Properties.Resources.products;
            this.BtnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProducts.Location = new System.Drawing.Point(3, 151);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(194, 69);
            this.BtnProducts.TabIndex = 3;
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnProviders
            // 
            this.BtnProviders.BackgroundImage = global::Supermarker_mvp.Properties.Resources.providers;
            this.BtnProviders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProviders.Location = new System.Drawing.Point(3, 226);
            this.BtnProviders.Name = "BtnProviders";
            this.BtnProviders.Size = new System.Drawing.Size(194, 68);
            this.BtnProviders.TabIndex = 4;
            this.BtnProviders.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Supermarker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProducts;
        private Button BtnProviders;
    }
}