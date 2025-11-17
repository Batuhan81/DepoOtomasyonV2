namespace DepoOtomasyonV2
{
    partial class UrunListesi
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkategoris_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTahminiMaliyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrenks_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "urunstoks";
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1902, 1033);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAd,
            this.colkategoris_Ad,
            this.colId,
            this.colTahminiMaliyet,
            this.colEkFiyat,
            this.colrenks_Ad,
            this.colDeger,
            this.colExpr,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 3;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colkategoris_Ad, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAd, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colrenks_Ad, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle_1);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData_1);
            // 
            // colAd
            // 
            this.colAd.Caption = "Ürün Adı";
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 2;
            this.colAd.Width = 94;
            // 
            // colkategoris_Ad
            // 
            this.colkategoris_Ad.Caption = "Kategori Adı";
            this.colkategoris_Ad.FieldName = "kategoris_Ad";
            this.colkategoris_Ad.MinWidth = 25;
            this.colkategoris_Ad.Name = "colkategoris_Ad";
            this.colkategoris_Ad.Visible = true;
            this.colkategoris_Ad.VisibleIndex = 1;
            this.colkategoris_Ad.Width = 94;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 103;
            // 
            // colTahminiMaliyet
            // 
            this.colTahminiMaliyet.Caption = "Ürün Fiyatı";
            this.colTahminiMaliyet.FieldName = "TahminiMaliyet";
            this.colTahminiMaliyet.MinWidth = 25;
            this.colTahminiMaliyet.Name = "colTahminiMaliyet";
            this.colTahminiMaliyet.Visible = true;
            this.colTahminiMaliyet.VisibleIndex = 3;
            this.colTahminiMaliyet.Width = 94;
            // 
            // colEkFiyat
            // 
            this.colEkFiyat.FieldName = "EkFiyat";
            this.colEkFiyat.MinWidth = 25;
            this.colEkFiyat.Name = "colEkFiyat";
            this.colEkFiyat.Visible = true;
            this.colEkFiyat.VisibleIndex = 4;
            this.colEkFiyat.Width = 94;
            // 
            // colrenks_Ad
            // 
            this.colrenks_Ad.Caption = "Renk";
            this.colrenks_Ad.FieldName = "renks_Ad";
            this.colrenks_Ad.MinWidth = 25;
            this.colrenks_Ad.Name = "colrenks_Ad";
            this.colrenks_Ad.Visible = true;
            this.colrenks_Ad.VisibleIndex = 3;
            this.colrenks_Ad.Width = 94;
            // 
            // colDeger
            // 
            this.colDeger.Caption = "Numara";
            this.colDeger.FieldName = "Deger";
            this.colDeger.MinWidth = 25;
            this.colDeger.Name = "colDeger";
            this.colDeger.Visible = true;
            this.colDeger.VisibleIndex = 1;
            this.colDeger.Width = 94;
            // 
            // colExpr
            // 
            this.colExpr.FieldName = "StokMiktari";
            this.colExpr.MinWidth = 25;
            this.colExpr.Name = "colExpr";
            this.colExpr.Visible = true;
            this.colExpr.VisibleIndex = 2;
            this.colExpr.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Satış Fiyatı";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundDataType = typeof(decimal);
            this.gridColumn1.UnboundExpression = "IsNull([TahminiMaliyet], 0) + IsNull([EkFiyat], 0)";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 94;
            // 
            // UrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.gridControl1);
            this.Name = "UrunListesi";
            this.Text = "UrunListesi";
            this.Load += new System.EventHandler(this.UrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colkategoris_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTahminiMaliyet;
        private DevExpress.XtraGrid.Columns.GridColumn colEkFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colrenks_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn colDeger;
        private DevExpress.XtraGrid.Columns.GridColumn colExpr;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}