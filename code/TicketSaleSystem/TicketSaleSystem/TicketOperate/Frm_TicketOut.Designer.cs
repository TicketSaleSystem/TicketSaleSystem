namespace TicketSaleSystem.TicketOperate
{
    partial class Frm_TicketOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FinanceStockOut));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtQSHM = new DevExpress.XtraEditors.TextEdit();
            this.txtZS = new DevExpress.XtraEditors.TextEdit();
            this.txtZZHM = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtQSHM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZZHM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "领/退人员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "起始号码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "张      数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "终止号码";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(637, 33);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 53);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "出   库";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(325, 102);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(118, 53);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "重   置";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtQSHM
            // 
            this.txtQSHM.EditValue = "JA00000001";
            this.txtQSHM.EnterMoveNextControl = true;
            this.txtQSHM.Location = new System.Drawing.Point(84, 66);
            this.txtQSHM.Name = "txtQSHM";
            this.txtQSHM.Properties.Appearance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtQSHM.Properties.Appearance.Options.UseBackColor = true;
            this.txtQSHM.Properties.DisplayFormat.FormatString = "**00000000";
            this.txtQSHM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQSHM.Properties.EditFormat.FormatString = "**00000000";
            this.txtQSHM.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQSHM.Properties.Mask.EditMask = "[A-Z]{2}[0-9]{8}";
            this.txtQSHM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtQSHM.Properties.MaxLength = 10;
            this.txtQSHM.Size = new System.Drawing.Size(124, 20);
            this.txtQSHM.TabIndex = 1;
            this.txtQSHM.EditValueChanged += new System.EventHandler(this.txtQSHM_EditValueChanged);
            // 
            // txtZS
            // 
            this.txtZS.EditValue = 1000;
            this.txtZS.Location = new System.Drawing.Point(291, 69);
            this.txtZS.Name = "txtZS";
            this.txtZS.Properties.Appearance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtZS.Properties.Appearance.Options.UseBackColor = true;
            this.txtZS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtZS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtZS.Properties.MaxLength = 5;
            this.txtZS.Size = new System.Drawing.Size(79, 20);
            this.txtZS.TabIndex = 2;
            this.txtZS.EditValueChanged += new System.EventHandler(this.txtQSHM_EditValueChanged);
            // 
            // txtZZHM
            // 
            this.txtZZHM.EditValue = "JA00001000";
            this.txtZZHM.Enabled = false;
            this.txtZZHM.EnterMoveNextControl = true;
            this.txtZZHM.Location = new System.Drawing.Point(453, 69);
            this.txtZZHM.Name = "txtZZHM";
            this.txtZZHM.Properties.Appearance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtZZHM.Properties.Appearance.Options.UseBackColor = true;
            this.txtZZHM.Size = new System.Drawing.Size(124, 20);
            this.txtZZHM.TabIndex = 3;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(84, 32);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Size = new System.Drawing.Size(124, 20);
            this.lookUpEdit2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(210, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(210, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(372, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "*";
            // 
            // btnHK
            // 
            this.btnHK.Image = ((System.Drawing.Image)(resources.GetObject("btnHK.Image")));
            this.btnHK.Location = new System.Drawing.Point(636, 102);
            this.btnHK.Name = "btnHK";
            this.btnHK.Size = new System.Drawing.Size(118, 53);
            this.btnHK.TabIndex = 7;
            this.btnHK.Text = "回   库";
            this.btnHK.Click += new System.EventHandler(this.btnHK_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(14, 161);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(741, 336);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(14, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 53);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查   询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Frm_TicketOperateOut
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketSaleSystem.Properties.Resources.逐墨;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.txtZZHM);
            this.Controls.Add(this.txtZS);
            this.Controls.Add(this.txtQSHM);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnHK);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Frm_TicketOperateOut";
            this.Size = new System.Drawing.Size(772, 515);
            ((System.ComponentModel.ISupportInitialize)(this.txtQSHM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZZHM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit txtQSHM;
        private DevExpress.XtraEditors.TextEdit txtZS;
        private DevExpress.XtraEditors.TextEdit txtZZHM;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnHK;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}
