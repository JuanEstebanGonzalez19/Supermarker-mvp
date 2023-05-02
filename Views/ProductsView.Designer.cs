namespace Supermarker_mvp.Views
{
    partial class ProductsView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgProducts = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageProductsDetail = new System.Windows.Forms.TabPage();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtProductsObservation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProductsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProductsId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).BeginInit();
            this.tabPageProductsDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarker_mvp.Properties.Resources.products;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageProductsDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 350);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnClose);
            this.tabPage1.Controls.Add(this.BtnDelete);
            this.tabPage1.Controls.Add(this.BtnEdit);
            this.tabPage1.Controls.Add(this.BtnNew);
            this.tabPage1.Controls.Add(this.DgProducts);
            this.tabPage1.Controls.Add(this.BtnSearch);
            this.tabPage1.Controls.Add(this.TxtSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = global::Supermarker_mvp.Properties.Resources.cerrar;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Location = new System.Drawing.Point(668, 217);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(59, 53);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::Supermarker_mvp.Properties.Resources.delete;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Location = new System.Drawing.Point(668, 158);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(59, 53);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackgroundImage = global::Supermarker_mvp.Properties.Resources.edit;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Location = new System.Drawing.Point(668, 99);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(59, 53);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.BackgroundImage = global::Supermarker_mvp.Properties.Resources._new;
            this.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNew.Location = new System.Drawing.Point(668, 40);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(59, 53);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            this.DgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProducts.Location = new System.Drawing.Point(42, 69);
            this.DgProducts.Name = "DgProducts";
            this.DgProducts.RowTemplate.Height = 25;
            this.DgProducts.Size = new System.Drawing.Size(511, 228);
            this.DgProducts.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::Supermarker_mvp.Properties.Resources.search;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearch.Location = new System.Drawing.Point(361, 15);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(55, 48);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(42, 40);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(313, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Products";
            // 
            // tabPageProductsDetail
            // 
            this.tabPageProductsDetail.Controls.Add(this.BtnCancel);
            this.tabPageProductsDetail.Controls.Add(this.BtnSave);
            this.tabPageProductsDetail.Controls.Add(this.TxtProductsObservation);
            this.tabPageProductsDetail.Controls.Add(this.label5);
            this.tabPageProductsDetail.Controls.Add(this.TxtProductsName);
            this.tabPageProductsDetail.Controls.Add(this.label4);
            this.tabPageProductsDetail.Controls.Add(this.TxtProductsId);
            this.tabPageProductsDetail.Controls.Add(this.label3);
            this.tabPageProductsDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPageProductsDetail.Name = "tabPageProductsDetail";
            this.tabPageProductsDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductsDetail.Size = new System.Drawing.Size(792, 322);
            this.tabPageProductsDetail.TabIndex = 1;
            this.tabPageProductsDetail.Text = "Products Detail";
            this.tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackgroundImage = global::Supermarker_mvp.Properties.Resources.cancel;
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCancel.Location = new System.Drawing.Point(490, 194);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(63, 49);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::Supermarker_mvp.Properties.Resources.save1;
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSave.Location = new System.Drawing.Point(490, 98);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(63, 49);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductsObservation
            // 
            this.TxtProductsObservation.Location = new System.Drawing.Point(46, 160);
            this.TxtProductsObservation.Multiline = true;
            this.TxtProductsObservation.Name = "TxtProductsObservation";
            this.TxtProductsObservation.Size = new System.Drawing.Size(360, 123);
            this.TxtProductsObservation.TabIndex = 5;
            this.TxtProductsObservation.Text = "Products Observation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Products Observation";
            // 
            // TxtProductsName
            // 
            this.TxtProductsName.Location = new System.Drawing.Point(46, 98);
            this.TxtProductsName.Name = "TxtProductsName";
            this.TxtProductsName.Size = new System.Drawing.Size(249, 23);
            this.TxtProductsName.TabIndex = 3;
            this.TxtProductsName.Text = "Products Name";
            this.TxtProductsName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Products Name";
            // 
            // TxtProductsId
            // 
            this.TxtProductsId.Location = new System.Drawing.Point(46, 36);
            this.TxtProductsId.Name = "TxtProductsId";
            this.TxtProductsId.Size = new System.Drawing.Size(172, 23);
            this.TxtProductsId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Products Id";
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsView";
            this.Text = "Products Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).EndInit();
            this.tabPageProductsDetail.ResumeLayout(false);
            this.tabPageProductsDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageProductsDetail;
        private Label label3;
        private TextBox TxtProductsName;
        private Label label4;
        private TextBox TxtProductsId;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductsObservation;
        private Label label5;
    }
}