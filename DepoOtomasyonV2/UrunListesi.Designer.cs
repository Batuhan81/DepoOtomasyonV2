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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table13 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table14 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table15 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table16 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table17 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression3 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join11 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo11 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join12 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo12 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join13 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo13 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join14 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo14 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join15 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo15 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table18 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Sorting sorting3 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1902, 1033);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_deposunum_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression19.ColumnName = "Ad";
            table13.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"224\" />";
            table13.Name = "uruns";
            columnExpression19.Table = table13;
            column19.Expression = columnExpression19;
            column20.Alias = "kategoris_Ad";
            columnExpression20.ColumnName = "Ad";
            table14.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"144\" />";
            table14.Name = "kategoris";
            columnExpression20.Table = table14;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "Id";
            table15.MetaSerializable = "<Meta X=\"190\" Y=\"30\" Width=\"125\" Height=\"264\" />";
            table15.Name = "urunvaryasyons";
            columnExpression21.Table = table15;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "TahminiMaliyet";
            columnExpression22.Table = table13;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "EkFiyat";
            columnExpression23.Table = table15;
            column23.Expression = columnExpression23;
            column24.Alias = "renks_Ad";
            columnExpression24.ColumnName = "Ad";
            table16.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"104\" />";
            table16.Name = "renks";
            columnExpression24.Table = table16;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "Deger";
            table17.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"104\" />";
            table17.Name = "numaras";
            columnExpression25.Table = table17;
            column25.Expression = columnExpression25;
            column26.Alias = "StokMiktari";
            customExpression3.Expression = "ISNULL([urunstoks.StokMiktari],0)";
            column26.Expression = customExpression3;
            columnExpression26.ColumnName = "MinimumStok";
            columnExpression26.Table = table15;
            column27.Expression = columnExpression26;
            selectQuery3.Columns.Add(column19);
            selectQuery3.Columns.Add(column20);
            selectQuery3.Columns.Add(column21);
            selectQuery3.Columns.Add(column22);
            selectQuery3.Columns.Add(column23);
            selectQuery3.Columns.Add(column24);
            selectQuery3.Columns.Add(column25);
            selectQuery3.Columns.Add(column26);
            selectQuery3.Columns.Add(column27);
            selectQuery3.Name = "urunstoks";
            relationColumnInfo11.NestedKeyColumn = "Id";
            relationColumnInfo11.ParentKeyColumn = "UrunId";
            join11.KeyColumns.Add(relationColumnInfo11);
            join11.Nested = table13;
            join11.Parent = table15;
            relationColumnInfo12.NestedKeyColumn = "Id";
            relationColumnInfo12.ParentKeyColumn = "KategoriId";
            join12.KeyColumns.Add(relationColumnInfo12);
            join12.Nested = table14;
            join12.Parent = table13;
            relationColumnInfo13.NestedKeyColumn = "Id";
            relationColumnInfo13.ParentKeyColumn = "NumaraId";
            join13.KeyColumns.Add(relationColumnInfo13);
            join13.Nested = table17;
            join13.Parent = table15;
            relationColumnInfo14.NestedKeyColumn = "Id";
            relationColumnInfo14.ParentKeyColumn = "RenkId";
            join14.KeyColumns.Add(relationColumnInfo14);
            join14.Nested = table16;
            join14.Parent = table15;
            relationColumnInfo15.NestedKeyColumn = "UrunVaryasyonId";
            relationColumnInfo15.ParentKeyColumn = "Id";
            join15.KeyColumns.Add(relationColumnInfo15);
            table18.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"144\" />";
            table18.Name = "urunstoks";
            join15.Nested = table18;
            join15.Parent = table15;
            join15.SqlJoinType = ((DevExpress.DataAccess.Sql.SqlJoinType)(DevExpress.DataAccess.Sql.SqlJoinType.LeftOuter));
            selectQuery3.Relations.Add(join11);
            selectQuery3.Relations.Add(join12);
            selectQuery3.Relations.Add(join13);
            selectQuery3.Relations.Add(join14);
            selectQuery3.Relations.Add(join15);
            columnExpression27.ColumnName = "Deger";
            columnExpression27.Table = table17;
            sorting3.Expression = columnExpression27;
            selectQuery3.Sorting.Add(sorting3);
            selectQuery3.Tables.Add(table18);
            selectQuery3.Tables.Add(table15);
            selectQuery3.Tables.Add(table13);
            selectQuery3.Tables.Add(table14);
            selectQuery3.Tables.Add(table17);
            selectQuery3.Tables.Add(table16);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
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