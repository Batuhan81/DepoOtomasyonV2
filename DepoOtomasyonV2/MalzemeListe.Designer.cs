namespace DepoOtomasyonV2
{
    partial class MalzemeListe
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeListe));
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkategoris_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalzemeFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOlusturulmaTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinimumStok1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktiflik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategoriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkategoris_Ad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = global::DepoOtomasyonV2.Properties.Resources.fill_32x32;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1787, 696);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1785, 666);
            this.xtraTabPage1.Text = "Malzeme Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "malzemestoks";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1785, 666);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_deposunum_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Id";
            table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"244\" />";
            table1.Name = "malzemes";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Ad";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Birim";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "StokMiktari";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"124\" />";
            table2.Name = "malzemestoks";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "malzemestoks";
            relationColumnInfo1.NestedKeyColumn = "Id";
            relationColumnInfo1.ParentKeyColumn = "MalzemeId";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table1;
            join1.Parent = table2;
            relationColumnInfo2.NestedKeyColumn = "Id";
            relationColumnInfo2.ParentKeyColumn = "KategoriId";
            join2.KeyColumns.Add(relationColumnInfo2);
            table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"144\" />";
            table3.Name = "kategoris";
            join2.Nested = table3;
            join2.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            sorting1.Direction = System.ComponentModel.ListSortDirection.Descending;
            columnExpression5.ColumnName = "Id";
            columnExpression5.Table = table1;
            sorting1.Expression = columnExpression5;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table3);
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colAd,
            this.colBirimFiyat1,
            this.colkategoris_Ad,
            this.colStokMiktari});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colkategoris_Ad, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 25;
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            this.colId1.Width = 94;
            // 
            // colAd
            // 
            this.colAd.Caption = "Malzeme Adı";
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            this.colAd.Width = 94;
            // 
            // colBirimFiyat1
            // 
            this.colBirimFiyat1.Caption = "Birim Fiyatı";
            this.colBirimFiyat1.FieldName = "BirimFiyat";
            this.colBirimFiyat1.MinWidth = 25;
            this.colBirimFiyat1.Name = "colBirimFiyat1";
            this.colBirimFiyat1.Visible = true;
            this.colBirimFiyat1.VisibleIndex = 2;
            this.colBirimFiyat1.Width = 94;
            // 
            // colkategoris_Ad
            // 
            this.colkategoris_Ad.Caption = "Kategori Adı";
            this.colkategoris_Ad.FieldName = "kategoris_Ad";
            this.colkategoris_Ad.MinWidth = 25;
            this.colkategoris_Ad.Name = "colkategoris_Ad";
            this.colkategoris_Ad.Visible = true;
            this.colkategoris_Ad.VisibleIndex = 3;
            this.colkategoris_Ad.Width = 94;
            // 
            // colStokMiktari
            // 
            this.colStokMiktari.Caption = "Stok Miktarı";
            this.colStokMiktari.FieldName = "StokMiktari";
            this.colStokMiktari.MinWidth = 25;
            this.colStokMiktari.Name = "colStokMiktari";
            this.colStokMiktari.Visible = true;
            this.colStokMiktari.VisibleIndex = 3;
            this.colStokMiktari.Width = 94;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.splitContainerControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1785, 666);
            this.xtraTabPage2.Text = "Malzeme Yönetimi";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1785, 666);
            this.splitContainerControl1.SplitterPosition = 1408;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "malzemes";
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1408, 666);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAd1,
            this.colBirim,
            this.colBirimFiyat,
            this.colMalzemeFoto,
            this.colOlusturulmaTarih,
            this.colMinimumStok1,
            this.colAktiflik,
            this.colKategoriId,
            this.colkategoris_Ad1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
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
            // colAd1
            // 
            this.colAd1.FieldName = "Ad";
            this.colAd1.MinWidth = 25;
            this.colAd1.Name = "colAd1";
            this.colAd1.Visible = true;
            this.colAd1.VisibleIndex = 1;
            this.colAd1.Width = 94;
            // 
            // colBirim
            // 
            this.colBirim.FieldName = "Birim";
            this.colBirim.MinWidth = 25;
            this.colBirim.Name = "colBirim";
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 2;
            this.colBirim.Width = 94;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.MinWidth = 25;
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 3;
            this.colBirimFiyat.Width = 94;
            // 
            // colMalzemeFoto
            // 
            this.colMalzemeFoto.FieldName = "MalzemeFoto";
            this.colMalzemeFoto.MinWidth = 25;
            this.colMalzemeFoto.Name = "colMalzemeFoto";
            this.colMalzemeFoto.Visible = true;
            this.colMalzemeFoto.VisibleIndex = 4;
            this.colMalzemeFoto.Width = 94;
            // 
            // colOlusturulmaTarih
            // 
            this.colOlusturulmaTarih.FieldName = "OlusturulmaTarih";
            this.colOlusturulmaTarih.MinWidth = 25;
            this.colOlusturulmaTarih.Name = "colOlusturulmaTarih";
            this.colOlusturulmaTarih.Visible = true;
            this.colOlusturulmaTarih.VisibleIndex = 5;
            this.colOlusturulmaTarih.Width = 94;
            // 
            // colMinimumStok1
            // 
            this.colMinimumStok1.FieldName = "MinimumStok";
            this.colMinimumStok1.MinWidth = 25;
            this.colMinimumStok1.Name = "colMinimumStok1";
            this.colMinimumStok1.Visible = true;
            this.colMinimumStok1.VisibleIndex = 6;
            this.colMinimumStok1.Width = 94;
            // 
            // colAktiflik
            // 
            this.colAktiflik.FieldName = "Aktiflik";
            this.colAktiflik.MinWidth = 25;
            this.colAktiflik.Name = "colAktiflik";
            this.colAktiflik.Visible = true;
            this.colAktiflik.VisibleIndex = 7;
            this.colAktiflik.Width = 94;
            // 
            // colKategoriId
            // 
            this.colKategoriId.FieldName = "KategoriId";
            this.colKategoriId.MinWidth = 25;
            this.colKategoriId.Name = "colKategoriId";
            this.colKategoriId.Visible = true;
            this.colKategoriId.VisibleIndex = 8;
            this.colKategoriId.Width = 94;
            // 
            // colkategoris_Ad1
            // 
            this.colkategoris_Ad1.FieldName = "kategoris_Ad";
            this.colkategoris_Ad1.MinWidth = 25;
            this.colkategoris_Ad1.Name = "colkategoris_Ad1";
            this.colkategoris_Ad1.Visible = true;
            this.colkategoris_Ad1.VisibleIndex = 9;
            this.colkategoris_Ad1.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 666);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Malzeme Bilgileri";
            // 
            // MalzemeListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 696);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "MalzemeListe";
            this.Text = "Malzeme Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAd1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colMalzemeFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colOlusturulmaTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colMinimumStok1;
        private DevExpress.XtraGrid.Columns.GridColumn colAktiflik;
        private DevExpress.XtraGrid.Columns.GridColumn colKategoriId;
        private DevExpress.XtraGrid.Columns.GridColumn colkategoris_Ad1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat1;
        private DevExpress.XtraGrid.Columns.GridColumn colkategoris_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn colStokMiktari;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}

