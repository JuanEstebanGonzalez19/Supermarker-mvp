namespace Supermarker_mvp.Views
{
    partial class ProvidersView
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProvidersList = new System.Windows.Forms.TabPage();
            this.tabPageProvidersDetail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgProviders = new System.Windows.Forms.DataGridView();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProvidersId = new System.Windows.Forms.TextBox();
            this.TxtProvidersName = new System.Windows.Forms.TextBox();
            this.TxtProvidersObservation = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageProvidersList.SuspendLayout();
            this.tabPageProvidersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProviders)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Providers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarker_mvp.Properties.Resources.providers;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProvidersList);
            this.tabControl1.Controls.Add(this.tabPageProvidersDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 350);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageProvidersList
            // 
            this.tabPageProvidersList.Controls.Add(this.BtnClose);
            this.tabPageProvidersList.Controls.Add(this.BtnDelete);
            this.tabPageProvidersList.Controls.Add(this.BtnEdit);
            this.tabPageProvidersList.Controls.Add(this.BtnNew);
            this.tabPageProvidersList.Controls.Add(this.DgProviders);
            this.tabPageProvidersList.Controls.Add(this.BtnSearch);
            this.tabPageProvidersList.Controls.Add(this.TxtSearch);
            this.tabPageProvidersList.Controls.Add(this.label2);
            this.tabPageProvidersList.Location = new System.Drawing.Point(4, 24);
            this.tabPageProvidersList.Name = "tabPageProvidersList";
            this.tabPageProvidersList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvidersList.Size = new System.Drawing.Size(792, 322);
            this.tabPageProvidersList.TabIndex = 0;
            this.tabPageProvidersList.Text = "Providers List";
            this.tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // tabPageProvidersDetail
            // 
            this.tabPageProvidersDetail.Controls.Add(this.BtnCancel);
            this.tabPageProvidersDetail.Controls.Add(this.BtnSave);
            this.tabPageProvidersDetail.Controls.Add(this.TxtProvidersObservation);
            this.tabPageProvidersDetail.Controls.Add(this.TxtProvidersName);
            this.tabPageProvidersDetail.Controls.Add(this.TxtProvidersId);
            this.tabPageProvidersDetail.Controls.Add(this.label5);
            this.tabPageProvidersDetail.Controls.Add(this.label4);
            this.tabPageProvidersDetail.Controls.Add(this.label3);
            this.tabPageProvidersDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            this.tabPageProvidersDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvidersDetail.Size = new System.Drawing.Size(792, 322);
            this.tabPageProvidersDetail.TabIndex = 1;
            this.tabPageProvidersDetail.Text = "Providers Detail";
            this.tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Providers";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(35, 46);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to Search";
            this.TxtSearch.Size = new System.Drawing.Size(270, 23);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::Supermarker_mvp.Properties.Resources.search;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearch.Location = new System.Drawing.Point(311, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(68, 48);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            this.DgProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProviders.Location = new System.Drawing.Point(35, 75);
            this.DgProviders.Name = "DgProviders";
            this.DgProviders.RowTemplate.Height = 25;
            this.DgProviders.Size = new System.Drawing.Size(423, 226);
            this.DgProviders.TabIndex = 4;
            // 
            // BtnNew
            // 
            this.BtnNew.BackgroundImage = global::Supermarker_mvp.Properties.Resources._new;
            this.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNew.Location = new System.Drawing.Point(621, 32);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 48);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackgroundImage = global::Supermarker_mvp.Properties.Resources.edit;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Location = new System.Drawing.Point(621, 99);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 48);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::Supermarker_mvp.Properties.Resources.delete;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Location = new System.Drawing.Point(621, 162);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 48);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = global::Supermarker_mvp.Properties.Resources.cerrar;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Location = new System.Drawing.Point(621, 227);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 48);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Providers Observation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Providers Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Providers Id";
            // 
            // TxtProvidersId
            // 
            this.TxtProvidersId.Location = new System.Drawing.Point(45, 45);
            this.TxtProvidersId.Name = "TxtProvidersId";
            this.TxtProvidersId.ReadOnly = true;
            this.TxtProvidersId.Size = new System.Drawing.Size(172, 23);
            this.TxtProvidersId.TabIndex = 8;
            this.TxtProvidersId.Text = "0";
            this.TxtProvidersId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtProvidersName
            // 
            this.TxtProvidersName.Location = new System.Drawing.Point(45, 107);
            this.TxtProvidersName.Name = "TxtProvidersName";
            this.TxtProvidersName.Size = new System.Drawing.Size(249, 23);
            this.TxtProvidersName.TabIndex = 9;
            this.TxtProvidersName.Text = "Providers Name";
            // 
            // TxtProvidersObservation
            // 
            this.TxtProvidersObservation.Location = new System.Drawing.Point(45, 169);
            this.TxtProvidersObservation.Multiline = true;
            this.TxtProvidersObservation.Name = "TxtProvidersObservation";
            this.TxtProvidersObservation.Size = new System.Drawing.Size(360, 123);
            this.TxtProvidersObservation.TabIndex = 10;
            this.TxtProvidersObservation.Text = "Providers Observation";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::Supermarker_mvp.Properties.Resources.save;
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSave.Location = new System.Drawing.Point(582, 86);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 55);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackgroundImage = global::Supermarker_mvp.Properties.Resources.cancel;
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCancel.Location = new System.Drawing.Point(582, 190);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 55);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ProvidersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ProvidersView";
            this.Text = "Providers Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageProvidersList.ResumeLayout(false);
            this.tabPageProvidersList.PerformLayout();
            this.tabPageProvidersDetail.ResumeLayout(false);
            this.tabPageProvidersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProviders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProviders;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProvidersId;
        private TextBox TxtProvidersName;
        private TextBox TxtProvidersObservation;
        private Button BtnCancel;
        private Button BtnSave;
    }
}