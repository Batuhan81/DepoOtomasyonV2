namespace DepoOtomasyonV2
{
    partial class CalisanForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkullanicirols_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotograf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.maskedTel = new System.Windows.Forms.MaskedTextBox();
            this.labelDepartman = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.linkMail = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAdSoyad = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.MinSize = 48;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1902, 1033);
            this.splitContainerControl1.SplitterPosition = 1564;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "kullanicis";
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1564, 1033);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAd,
            this.colSoyad,
            this.colkullanicirols_Ad,
            this.colTelefon,
            this.colFotograf,
            this.colMail,
            this.colKayitTarihi,
            this.colId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colkullanicirols_Ad, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 0;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 1;
            this.colSoyad.Width = 94;
            // 
            // colkullanicirols_Ad
            // 
            this.colkullanicirols_Ad.Caption = "Departman";
            this.colkullanicirols_Ad.FieldName = "kullanicirols_Ad";
            this.colkullanicirols_Ad.MinWidth = 25;
            this.colkullanicirols_Ad.Name = "colkullanicirols_Ad";
            this.colkullanicirols_Ad.Visible = true;
            this.colkullanicirols_Ad.VisibleIndex = 2;
            this.colkullanicirols_Ad.Width = 94;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.MinWidth = 25;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Width = 94;
            // 
            // colFotograf
            // 
            this.colFotograf.FieldName = "Fotograf";
            this.colFotograf.MinWidth = 25;
            this.colFotograf.Name = "colFotograf";
            this.colFotograf.Width = 94;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.MinWidth = 25;
            this.colMail.Name = "colMail";
            this.colMail.Width = 94;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.MinWidth = 25;
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Width = 94;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainer1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(326, 1033);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.maskedTel);
            this.splitContainer1.Panel2.Controls.Add(this.labelDepartman);
            this.splitContainer1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel2.Controls.Add(this.linkMail);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.labelAdSoyad);
            this.splitContainer1.Size = new System.Drawing.Size(322, 1029);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(322, 317);
            this.pictureEdit1.TabIndex = 0;
            // 
            // maskedTel
            // 
            this.maskedTel.Location = new System.Drawing.Point(103, 261);
            this.maskedTel.Mask = "(999) 000-0000";
            this.maskedTel.Name = "maskedTel";
            this.maskedTel.Size = new System.Drawing.Size(124, 23);
            this.maskedTel.TabIndex = 7;
            // 
            // labelDepartman
            // 
            this.labelDepartman.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDepartman.Appearance.Options.UseFont = true;
            this.labelDepartman.Location = new System.Drawing.Point(118, 147);
            this.labelDepartman.Name = "labelDepartman";
            this.labelDepartman.Size = new System.Drawing.Size(95, 21);
            this.labelDepartman.TabIndex = 6;
            this.labelDepartman.Text = "Departman";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(300, 46);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Başlangıç Tarihi";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::DepoOtomasyonV2.Properties.Resources.windows_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(58, 372);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(215, 70);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Loglara Göz At";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // linkMail
            // 
            this.linkMail.Location = new System.Drawing.Point(101, 320);
            this.linkMail.Name = "linkMail";
            this.linkMail.Size = new System.Drawing.Size(129, 16);
            this.linkMail.TabIndex = 3;
            this.linkMail.Text = "hyperlinkLabelControl1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdSoyad.Appearance.Options.UseFont = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(92, 204);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(147, 21);
            this.labelAdSoyad.TabIndex = 0;
            this.labelAdSoyad.Text = "Calisan Ad Soyad";
            // 
            // CalisanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "CalisanForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalisanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelAdSoyad;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkMail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelDepartman;
        private System.Windows.Forms.MaskedTextBox maskedTel;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colkullanicirols_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colFotograf;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}