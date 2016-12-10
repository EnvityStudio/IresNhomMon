namespace Title.GUI {
    partial class UctQuanLyNhomMon {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControlNhomMon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSoMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhomMon = new System.Windows.Forms.Panel();
            this.textEditTongSoMon = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.lbTenNhom = new System.Windows.Forms.Label();
            this.textEditMaNhom = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelNhomMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTongSoMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhomMon
            // 
            this.gridControlNhomMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhomMon.Location = new System.Drawing.Point(0, 146);
            this.gridControlNhomMon.MainView = this.gridView1;
            this.gridControlNhomMon.Name = "gridControlNhomMon";
            this.gridControlNhomMon.Size = new System.Drawing.Size(1247, 370);
            this.gridControlNhomMon.TabIndex = 0;
            this.gridControlNhomMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhom,
            this.colTenNhom,
            this.colTongSoMon});
            this.gridView1.GridControl = this.gridControlNhomMon;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaNhom
            // 
            this.colMaNhom.FieldName = "MaNhom";
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.Visible = true;
            this.colMaNhom.VisibleIndex = 0;
            this.colMaNhom.Width = 248;
            // 
            // colTenNhom
            // 
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 1;
            this.colTenNhom.Width = 296;
            // 
            // colTongSoMon
            // 
            this.colTongSoMon.FieldName = "TongSoMon";
            this.colTongSoMon.Name = "colTongSoMon";
            this.colTongSoMon.Visible = true;
            this.colTongSoMon.VisibleIndex = 2;
            this.colTongSoMon.Width = 685;
            // 
            // panelNhomMon
            // 
            this.panelNhomMon.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelNhomMon.Controls.Add(this.textEditTongSoMon);
            this.panelNhomMon.Controls.Add(this.label2);
            this.panelNhomMon.Controls.Add(this.textEditTenNhom);
            this.panelNhomMon.Controls.Add(this.lbTenNhom);
            this.panelNhomMon.Controls.Add(this.textEditMaNhom);
            this.panelNhomMon.Controls.Add(this.label1);
            this.panelNhomMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhomMon.Enabled = false;
            this.panelNhomMon.Location = new System.Drawing.Point(0, 0);
            this.panelNhomMon.Name = "panelNhomMon";
            this.panelNhomMon.Size = new System.Drawing.Size(1247, 146);
            this.panelNhomMon.TabIndex = 2;
            // 
            // textEditTongSoMon
            // 
            this.textEditTongSoMon.EditValue = "";
            this.textEditTongSoMon.Enabled = false;
            this.textEditTongSoMon.Location = new System.Drawing.Point(88, 90);
            this.textEditTongSoMon.Name = "textEditTongSoMon";
            this.textEditTongSoMon.Size = new System.Drawing.Size(169, 20);
            this.textEditTongSoMon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Số Món:";
            // 
            // textEditTenNhom
            // 
            this.textEditTenNhom.EditValue = "";
            this.textEditTenNhom.Location = new System.Drawing.Point(88, 51);
            this.textEditTenNhom.Name = "textEditTenNhom";
            this.textEditTenNhom.Size = new System.Drawing.Size(169, 20);
            this.textEditTenNhom.TabIndex = 3;
            // 
            // lbTenNhom
            // 
            this.lbTenNhom.AutoSize = true;
            this.lbTenNhom.Location = new System.Drawing.Point(13, 58);
            this.lbTenNhom.Name = "lbTenNhom";
            this.lbTenNhom.Size = new System.Drawing.Size(63, 13);
            this.lbTenNhom.TabIndex = 2;
            this.lbTenNhom.Text = "Tên Nhóm: ";
            // 
            // textEditMaNhom
            // 
            this.textEditMaNhom.Enabled = false;
            this.textEditMaNhom.Location = new System.Drawing.Point(88, 9);
            this.textEditMaNhom.Name = "textEditMaNhom";
            this.textEditMaNhom.Size = new System.Drawing.Size(169, 20);
            this.textEditMaNhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm: ";
            // 
            // UctQuanLyNhomMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlNhomMon);
            this.Controls.Add(this.panelNhomMon);
            this.Name = "UctQuanLyNhomMon";
            this.Size = new System.Drawing.Size(1247, 516);
            this.Load += new System.EventHandler(this.UctQuanLyNhomMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelNhomMon.ResumeLayout(false);
            this.panelNhomMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTongSoMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNhom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhomMon;
        private System.Windows.Forms.Panel panelNhomMon;
        private DevExpress.XtraEditors.TextEdit textEditTongSoMon;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditTenNhom;
        private System.Windows.Forms.Label lbTenNhom;
        private DevExpress.XtraEditors.TextEdit textEditMaNhom;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSoMon;
    }
}
