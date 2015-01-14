namespace TicketSaleSystem.TicketOperate
{
    partial class Frm_Sale
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
            this.gc_PreSaleList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label10 = new System.Windows.Forms.Label();
            this.l_jyh = new System.Windows.Forms.Label();
            this.btn_Sale = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ssk = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_skhj = new System.Windows.Forms.Label();
            this.l_zl = new System.Windows.Forms.Label();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_qstm = new System.Windows.Forms.Label();
            this.l_zztm = new System.Windows.Forms.Label();
            this.l_xj = new System.Windows.Forms.Label();
            this.l_verify = new System.Windows.Forms.Label();
            this.l_dj = new System.Windows.Forms.Label();
            this.lue_mplx = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_rs = new DevExpress.XtraEditors.TextEdit();
            this.txt_zs = new DevExpress.XtraEditors.TextEdit();
            this.txt_mptm = new DevExpress.XtraEditors.TextEdit();
            this.btn_PreSale = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SearchStatus = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lue_kyd = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_ttmc = new DevExpress.XtraEditors.TextEdit();
            this.txt_zjhm = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ReWrite = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.de_Trade = new DevExpress.XtraEditors.DateEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.gc_TradeList = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_SearchHistory = new DevExpress.XtraEditors.SimpleButton();
            this.lue_zjlx = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PreSaleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ssk.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_mplx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mptm.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_kyd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ttmc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zjhm.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Trade.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Trade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TradeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_zjlx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_PreSaleList
            // 
            this.gc_PreSaleList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_PreSaleList.Location = new System.Drawing.Point(3, 43);
            this.gc_PreSaleList.MainView = this.gridView1;
            this.gc_PreSaleList.Name = "gc_PreSaleList";
            this.gc_PreSaleList.Size = new System.Drawing.Size(449, 145);
            this.gc_PreSaleList.TabIndex = 10;
            this.gc_PreSaleList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gc_PreSaleList;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(13, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "交 易 号 :";
            // 
            // l_jyh
            // 
            this.l_jyh.AutoSize = true;
            this.l_jyh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.l_jyh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_jyh.Location = new System.Drawing.Point(100, 11);
            this.l_jyh.Name = "l_jyh";
            this.l_jyh.Size = new System.Drawing.Size(191, 19);
            this.l_jyh.TabIndex = 0;
            this.l_jyh.Text = "A20150106233956123";
            // 
            // btn_Sale
            // 
            this.btn_Sale.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Sale.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.btn_Sale.Appearance.Options.UseFont = true;
            this.btn_Sale.Appearance.Options.UseForeColor = true;
            this.btn_Sale.Location = new System.Drawing.Point(51, 209);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(75, 38);
            this.btn_Sale.TabIndex = 11;
            this.btn_Sale.Text = "售  票";
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "收款合计：";
            // 
            // txt_ssk
            // 
            this.txt_ssk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_ssk.Location = new System.Drawing.Point(222, 189);
            this.txt_ssk.Name = "txt_ssk";
            this.txt_ssk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txt_ssk.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txt_ssk.Properties.Appearance.Options.UseFont = true;
            this.txt_ssk.Properties.Appearance.Options.UseForeColor = true;
            this.txt_ssk.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_ssk.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_ssk.Properties.MaxLength = 6;
            this.txt_ssk.Properties.NullText = "0.00";
            this.txt_ssk.Size = new System.Drawing.Size(93, 24);
            this.txt_ssk.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "实收款：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(348, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "找零：";
            // 
            // l_skhj
            // 
            this.l_skhj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_skhj.AutoSize = true;
            this.l_skhj.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.l_skhj.ForeColor = System.Drawing.Color.Red;
            this.l_skhj.Location = new System.Drawing.Point(87, 189);
            this.l_skhj.Name = "l_skhj";
            this.l_skhj.Size = new System.Drawing.Size(39, 17);
            this.l_skhj.TabIndex = 15;
            this.l_skhj.Text = "0.00";
            // 
            // l_zl
            // 
            this.l_zl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_zl.AutoSize = true;
            this.l_zl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.l_zl.ForeColor = System.Drawing.Color.Red;
            this.l_zl.Location = new System.Drawing.Point(398, 189);
            this.l_zl.Name = "l_zl";
            this.l_zl.Size = new System.Drawing.Size(39, 17);
            this.l_zl.TabIndex = 15;
            this.l_zl.Text = "0.00";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.btn_Clear.Appearance.Options.UseFont = true;
            this.btn_Clear.Appearance.Options.UseForeColor = true;
            this.btn_Clear.Location = new System.Drawing.Point(337, 209);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 38);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "清  空";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.l_qstm);
            this.panel1.Controls.Add(this.l_zztm);
            this.panel1.Controls.Add(this.l_xj);
            this.panel1.Controls.Add(this.l_verify);
            this.panel1.Controls.Add(this.l_dj);
            this.panel1.Controls.Add(this.lue_mplx);
            this.panel1.Controls.Add(this.txt_rs);
            this.panel1.Controls.Add(this.txt_zs);
            this.panel1.Controls.Add(this.txt_mptm);
            this.panel1.Controls.Add(this.btn_PreSale);
            this.panel1.Controls.Add(this.btn_SearchStatus);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(9, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 135);
            this.panel1.TabIndex = 16;
            // 
            // l_qstm
            // 
            this.l_qstm.AutoSize = true;
            this.l_qstm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.l_qstm.ForeColor = System.Drawing.Color.Blue;
            this.l_qstm.Location = new System.Drawing.Point(277, 85);
            this.l_qstm.Name = "l_qstm";
            this.l_qstm.Size = new System.Drawing.Size(97, 17);
            this.l_qstm.TabIndex = 5;
            this.l_qstm.Text = "JA00000001";
            // 
            // l_zztm
            // 
            this.l_zztm.AutoSize = true;
            this.l_zztm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.l_zztm.ForeColor = System.Drawing.Color.Blue;
            this.l_zztm.Location = new System.Drawing.Point(277, 110);
            this.l_zztm.Name = "l_zztm";
            this.l_zztm.Size = new System.Drawing.Size(97, 17);
            this.l_zztm.TabIndex = 5;
            this.l_zztm.Text = "JA00000001";
            // 
            // l_xj
            // 
            this.l_xj.AutoSize = true;
            this.l_xj.Location = new System.Drawing.Point(74, 110);
            this.l_xj.Name = "l_xj";
            this.l_xj.Size = new System.Drawing.Size(115, 14);
            this.l_xj.TabIndex = 5;
            this.l_xj.Text = "                           ";
            // 
            // l_verify
            // 
            this.l_verify.AutoSize = true;
            this.l_verify.BackColor = System.Drawing.Color.Maroon;
            this.l_verify.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.l_verify.ForeColor = System.Drawing.Color.White;
            this.l_verify.Location = new System.Drawing.Point(199, 8);
            this.l_verify.Name = "l_verify";
            this.l_verify.Size = new System.Drawing.Size(97, 17);
            this.l_verify.TabIndex = 4;
            this.l_verify.Text = "JA00000001";
            // 
            // l_dj
            // 
            this.l_dj.AutoSize = true;
            this.l_dj.Location = new System.Drawing.Point(74, 85);
            this.l_dj.Name = "l_dj";
            this.l_dj.Size = new System.Drawing.Size(115, 14);
            this.l_dj.TabIndex = 4;
            this.l_dj.Text = "                           ";
            // 
            // lue_mplx
            // 
            this.lue_mplx.Enabled = false;
            this.lue_mplx.Location = new System.Drawing.Point(74, 57);
            this.lue_mplx.Name = "lue_mplx";
            this.lue_mplx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_mplx.Size = new System.Drawing.Size(222, 20);
            this.lue_mplx.TabIndex = 3;
            // 
            // txt_rs
            // 
            this.txt_rs.Location = new System.Drawing.Point(224, 31);
            this.txt_rs.Name = "txt_rs";
            this.txt_rs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_rs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_rs.Properties.MaxLength = 5;
            this.txt_rs.Properties.ReadOnly = true;
            this.txt_rs.Size = new System.Drawing.Size(72, 20);
            this.txt_rs.TabIndex = 2;
            // 
            // txt_zs
            // 
            this.txt_zs.Location = new System.Drawing.Point(74, 31);
            this.txt_zs.Name = "txt_zs";
            this.txt_zs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_zs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_zs.Properties.MaxLength = 5;
            this.txt_zs.Size = new System.Drawing.Size(73, 20);
            this.txt_zs.TabIndex = 2;
            this.txt_zs.EditValueChanged += new System.EventHandler(this.txt_zs_EditValueChanged);
            // 
            // txt_mptm
            // 
            this.txt_mptm.EditValue = "JA00000001";
            this.txt_mptm.Location = new System.Drawing.Point(74, 5);
            this.txt_mptm.Name = "txt_mptm";
            this.txt_mptm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txt_mptm.Properties.Appearance.Options.UseFont = true;
            this.txt_mptm.Size = new System.Drawing.Size(119, 22);
            this.txt_mptm.TabIndex = 2;
            // 
            // btn_PreSale
            // 
            this.btn_PreSale.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_PreSale.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_PreSale.Appearance.Options.UseFont = true;
            this.btn_PreSale.Appearance.Options.UseForeColor = true;
            this.btn_PreSale.Location = new System.Drawing.Point(362, 48);
            this.btn_PreSale.Name = "btn_PreSale";
            this.btn_PreSale.Size = new System.Drawing.Size(75, 29);
            this.btn_PreSale.TabIndex = 1;
            this.btn_PreSale.Text = "停止预售";
            this.btn_PreSale.Click += new System.EventHandler(this.btn_PreSale_Click);
            // 
            // btn_SearchStatus
            // 
            this.btn_SearchStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SearchStatus.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.btn_SearchStatus.Appearance.Options.UseFont = true;
            this.btn_SearchStatus.Appearance.Options.UseForeColor = true;
            this.btn_SearchStatus.Location = new System.Drawing.Point(362, 3);
            this.btn_SearchStatus.Name = "btn_SearchStatus";
            this.btn_SearchStatus.Size = new System.Drawing.Size(75, 29);
            this.btn_SearchStatus.TabIndex = 1;
            this.btn_SearchStatus.Text = "状态查询";
            this.btn_SearchStatus.Click += new System.EventHandler(this.btn_SearchStatus_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(204, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "终止条码 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "门票类型 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(204, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "起始条码 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(153, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "人      数 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "小      计 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "张      数 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "单      价 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "门票条码 :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lue_zjlx);
            this.panel2.Controls.Add(this.lue_kyd);
            this.panel2.Controls.Add(this.txt_ttmc);
            this.panel2.Controls.Add(this.txt_zjhm);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(9, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 82);
            this.panel2.TabIndex = 16;
            // 
            // lue_kyd
            // 
            this.lue_kyd.Location = new System.Drawing.Point(74, 56);
            this.lue_kyd.Name = "lue_kyd";
            this.lue_kyd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_kyd.Size = new System.Drawing.Size(119, 20);
            this.lue_kyd.TabIndex = 3;
            // 
            // txt_ttmc
            // 
            this.txt_ttmc.Location = new System.Drawing.Point(74, 31);
            this.txt_ttmc.Name = "txt_ttmc";
            this.txt_ttmc.Size = new System.Drawing.Size(363, 20);
            this.txt_ttmc.TabIndex = 2;
            // 
            // txt_zjhm
            // 
            this.txt_zjhm.Location = new System.Drawing.Point(275, 6);
            this.txt_zjhm.Name = "txt_zjhm";
            this.txt_zjhm.Size = new System.Drawing.Size(162, 20);
            this.txt_zjhm.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "客 源  地 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(204, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "证件号码 :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "团体名称 :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(3, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 14);
            this.label21.TabIndex = 0;
            this.label21.Text = "证件类型 :";
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Appearance.Options.UseForeColor = true;
            this.btn_Add.Location = new System.Drawing.Point(51, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 38);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "添  加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_ReWrite
            // 
            this.btn_ReWrite.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ReWrite.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.btn_ReWrite.Appearance.Options.UseFont = true;
            this.btn_ReWrite.Appearance.Options.UseForeColor = true;
            this.btn_ReWrite.Location = new System.Drawing.Point(337, 3);
            this.btn_ReWrite.Name = "btn_ReWrite";
            this.btn_ReWrite.Size = new System.Drawing.Size(75, 38);
            this.btn_ReWrite.TabIndex = 1;
            this.btn_ReWrite.Text = "重  填";
            this.btn_ReWrite.Click += new System.EventHandler(this.btn_ReWrite_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_ssk);
            this.panel3.Controls.Add(this.gc_PreSaleList);
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Controls.Add(this.btn_Sale);
            this.panel3.Controls.Add(this.l_zl);
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.l_skhj);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_ReWrite);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(9, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 250);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.de_Trade);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.gc_TradeList);
            this.panel4.Controls.Add(this.btn_SearchHistory);
            this.panel4.Location = new System.Drawing.Point(464, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 465);
            this.panel4.TabIndex = 18;
            // 
            // de_Trade
            // 
            this.de_Trade.EditValue = new System.DateTime(2015, 1, 7, 0, 45, 3, 0);
            this.de_Trade.Location = new System.Drawing.Point(79, 7);
            this.de_Trade.Name = "de_Trade";
            this.de_Trade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Trade.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Trade.Size = new System.Drawing.Size(127, 20);
            this.de_Trade.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(7, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 14);
            this.label20.TabIndex = 0;
            this.label20.Text = "交易日期 :";
            // 
            // gc_TradeList
            // 
            this.gc_TradeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_TradeList.Location = new System.Drawing.Point(4, 31);
            this.gc_TradeList.MainView = this.gridView2;
            this.gc_TradeList.Name = "gc_TradeList";
            this.gc_TradeList.Size = new System.Drawing.Size(283, 430);
            this.gc_TradeList.TabIndex = 10;
            this.gc_TradeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gc_TradeList;
            this.gridView2.IndicatorWidth = 40;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsMenu.EnableColumnMenu = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // btn_SearchHistory
            // 
            this.btn_SearchHistory.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SearchHistory.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.btn_SearchHistory.Appearance.Options.UseFont = true;
            this.btn_SearchHistory.Appearance.Options.UseForeColor = true;
            this.btn_SearchHistory.Location = new System.Drawing.Point(212, 6);
            this.btn_SearchHistory.Name = "btn_SearchHistory";
            this.btn_SearchHistory.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchHistory.TabIndex = 1;
            this.btn_SearchHistory.Text = "查  询";
            this.btn_SearchHistory.Click += new System.EventHandler(this.btn_SearchHistory_Click);
            // 
            // lue_zjlx
            // 
            this.lue_zjlx.Location = new System.Drawing.Point(74, 6);
            this.lue_zjlx.Name = "lue_zjlx";
            this.lue_zjlx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_zjlx.Size = new System.Drawing.Size(119, 20);
            this.lue_zjlx.TabIndex = 4;
            // 
            // Frm_Sale
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketSaleSystem.Properties.Resources.逐墨;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_jyh);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Frm_Sale";
            this.Size = new System.Drawing.Size(772, 515);
            ((System.ComponentModel.ISupportInitialize)(this.gc_PreSaleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ssk.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_mplx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mptm.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_kyd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ttmc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zjhm.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Trade.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Trade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TradeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_zjlx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_PreSaleList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l_jyh;
        private DevExpress.XtraEditors.SimpleButton btn_Sale;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_ssk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_skhj;
        private System.Windows.Forms.Label l_zl;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_PreSale;
        private DevExpress.XtraEditors.SimpleButton btn_SearchStatus;
        private DevExpress.XtraEditors.TextEdit txt_rs;
        private DevExpress.XtraEditors.TextEdit txt_zs;
        private DevExpress.XtraEditors.TextEdit txt_mptm;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txt_ttmc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_ReWrite;
        private DevExpress.XtraEditors.TextEdit txt_zjhm;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.LookUpEdit lue_mplx;
        private DevExpress.XtraEditors.LookUpEdit lue_kyd;
        private System.Windows.Forms.Label l_zztm;
        private System.Windows.Forms.Label l_xj;
        private System.Windows.Forms.Label l_verify;
        private System.Windows.Forms.Label l_dj;
        private System.Windows.Forms.Label l_qstm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraGrid.GridControl gc_TradeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit de_Trade;
        private DevExpress.XtraEditors.SimpleButton btn_SearchHistory;
        private DevExpress.XtraEditors.LookUpEdit lue_zjlx;
    }
}
