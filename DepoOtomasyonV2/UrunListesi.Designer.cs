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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.CustomExpression customExpression1 = new DevExpress.DataAccess.Sql.CustomExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join5 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo5 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
            columnExpression1.ColumnName = "Ad";
            table1.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"224\" />";
            table1.Name = "uruns";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            column2.Alias = "kategoris_Ad";
            columnExpression2.ColumnName = "Ad";
            table2.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"144\" />";
            table2.Name = "kategoris";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Id";
            table3.MetaSerializable = "<Meta X=\"190\" Y=\"30\" Width=\"125\" Height=\"264\" />";
            table3.Name = "urunvaryasyons";
            columnExpression3.Table = table3;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "TahminiMaliyet";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "EkFiyat";
            columnExpression5.Table = table3;
            column5.Expression = columnExpression5;
            column6.Alias = "renks_Ad";
            columnExpression6.ColumnName = "Ad";
            table4.MetaSerializable = "<Meta X=\"805\" Y=\"30\" Width=\"125\" Height=\"104\" />";
            table4.Name = "renks";
            columnExpression6.Table = table4;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Deger";
            table5.MetaSerializable = "<Meta X=\"650\" Y=\"30\" Width=\"125\" Height=\"104\" />";
            table5.Name = "numaras";
            columnExpression7.Table = table5;
            column7.Expression = columnExpression7;
            column8.Alias = "StokMiktari";
            customExpression1.Expression = "ISNULL([urunstoks.StokMiktari],0)";
            column8.Expression = customExpression1;
            columnExpression8.ColumnName = "MinimumStok";
            columnExpression8.Table = table3;
            column9.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Name = "urunstoks";
            relationColumnInfo1.NestedKeyColumn = "Id";
            relationColumnInfo1.ParentKeyColumn = "UrunId";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table1;
            join1.Parent = table3;
            relationColumnInfo2.NestedKeyColumn = "Id";
            relationColumnInfo2.ParentKeyColumn = "KategoriId";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table2;
            join2.Parent = table1;
            relationColumnInfo3.NestedKeyColumn = "Id";
            relationColumnInfo3.ParentKeyColumn = "NumaraId";
            join3.KeyColumns.Add(relationColumnInfo3);
            join3.Nested = table5;
            join3.Parent = table3;
            relationColumnInfo4.NestedKeyColumn = "Id";
            relationColumnInfo4.ParentKeyColumn = "RenkId";
            join4.KeyColumns.Add(relationColumnInfo4);
            join4.Nested = table4;
            join4.Parent = table3;
            relationColumnInfo5.NestedKeyColumn = "UrunVaryasyonId";
            relationColumnInfo5.ParentKeyColumn = "Id";
            join5.KeyColumns.Add(relationColumnInfo5);
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"144\" />";
            table6.Name = "urunstoks";
            join5.Nested = table6;
            join5.Parent = table3;
            join5.SqlJoinType = ((DevExpress.DataAccess.Sql.SqlJoinType)(DevExpress.DataAccess.Sql.SqlJoinType.LeftOuter));
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Relations.Add(join3);
            selectQuery1.Relations.Add(join4);
            selectQuery1.Relations.Add(join5);
            columnExpression9.ColumnName = "Deger";
            columnExpression9.Table = table5;
            sorting1.Expression = columnExpression9;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table6);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table5);
            selectQuery1.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
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
            this.colAd.VisibleIndex = 0;
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
            this.colId.Width = 94;
            // 
            // colTahminiMaliyet
            // 
            this.colTahminiMaliyet.Caption = "Ürün Fiyatı";
            this.colTahminiMaliyet.FieldName = "TahminiMaliyet";
            this.colTahminiMaliyet.MinWidth = 25;
            this.colTahminiMaliyet.Name = "colTahminiMaliyet";
            this.colTahminiMaliyet.Visible = true;
            this.colTahminiMaliyet.VisibleIndex = 1;
            this.colTahminiMaliyet.Width = 94;
            // 
            // colEkFiyat
            // 
            this.colEkFiyat.FieldName = "EkFiyat";
            this.colEkFiyat.MinWidth = 25;
            this.colEkFiyat.Name = "colEkFiyat";
            this.colEkFiyat.Visible = true;
            this.colEkFiyat.VisibleIndex = 2;
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
            this.colDeger.VisibleIndex = 3;
            this.colDeger.Width = 94;
            // 
            // colExpr
            // 
            this.colExpr.FieldName = "StokMiktari";
            this.colExpr.MinWidth = 25;
            this.colExpr.Name = "colExpr";
            this.colExpr.Visible = true;
            this.colExpr.VisibleIndex = 4;
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