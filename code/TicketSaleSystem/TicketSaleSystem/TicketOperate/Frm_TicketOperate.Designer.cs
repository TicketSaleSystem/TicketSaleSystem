namespace TicketSaleSystem.TicketOperate
{
    partial class Frm_TicketOperate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TicketOperate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtQSHM = new DevExpress.XtraEditors.TextEdit();
            this.txtZS = new DevExpress.XtraEditors.TextEdit();
            this.txtZZHM = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTP = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtQSHM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZZHM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "供票人员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "起始号码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "张      数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "终止号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "门票项目";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(179, 366);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 53);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "确   定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(329, 366);
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
            this.txtQSHM.Location = new System.Drawing.Point(272, 116);
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
            this.txtQSHM.Size = new System.Drawing.Size(318, 20);
            this.txtQSHM.TabIndex = 1;
            this.txtQSHM.EditValueChanged += new System.EventHandler(this.txtQSHM_EditValueChanged);
            // 
            // txtZS
            // 
            this.txtZS.EditValue = 1000;
            this.txtZS.Location = new System.Drawing.Point(272, 171);
            this.txtZS.Name = "txtZS";
            this.txtZS.Properties.Appearance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtZS.Properties.Appearance.Options.UseBackColor = true;
            this.txtZS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtZS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtZS.Properties.MaxLength = 6;
            this.txtZS.Size = new System.Drawing.Size(318, 20);
            this.txtZS.TabIndex = 2;
            this.txtZS.EditValueChanged += new System.EventHandler(this.txtQSHM_EditValueChanged);
            // 
            // txtZZHM
            // 
            this.txtZZHM.EditValue = "JA00001000";
            this.txtZZHM.Enabled = false;
            this.txtZZHM.EnterMoveNextControl = true;
            this.txtZZHM.Location = new System.Drawing.Point(272, 228);
            this.txtZZHM.Name = "txtZZHM";
            this.txtZZHM.Properties.Appearance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtZZHM.Properties.Appearance.Options.UseBackColor = true;
            this.txtZZHM.Size = new System.Drawing.Size(318, 20);
            this.txtZZHM.TabIndex = 3;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "";
            this.lookUpEdit1.Location = new System.Drawing.Point(272, 282);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(318, 20);
            this.lookUpEdit1.TabIndex = 4;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(272, 67);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Size = new System.Drawing.Size(318, 20);
            this.lookUpEdit2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(597, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(597, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(597, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(596, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "*";
            // 
            // btnTP
            // 
            this.btnTP.Image = ((System.Drawing.Image)(resources.GetObject("btnTP.Image")));
            this.btnTP.Location = new System.Drawing.Point(472, 366);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(118, 53);
            this.btnTP.TabIndex = 7;
            this.btnTP.Text = "退   票";
            this.btnTP.Click += new System.EventHandler(this.btnTP_Click);
            // 
            // Frm_TicketOperate
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketSaleSystem.Properties.Resources.逐墨;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.txtZZHM);
            this.Controls.Add(this.txtZS);
            this.Controls.Add(this.txtQSHM);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnTP);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Frm_TicketOperate";
            this.Size = new System.Drawing.Size(772, 515);
            ((System.ComponentModel.ISupportInitialize)(this.txtQSHM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZZHM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit txtQSHM;
        private DevExpress.XtraEditors.TextEdit txtZS;
        private DevExpress.XtraEditors.TextEdit txtZZHM;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnTP;
    }
}
