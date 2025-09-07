namespace CreditCardSystem.Views
{
    partial class Parties
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            gridNumbers = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtName = new DevExpress.XtraEditors.TextEdit();
            girdPeople = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            txtType = new DevExpress.XtraEditors.ComboBoxEdit();
            txtFirstBalance = new DevExpress.XtraEditors.SpinEdit();
            txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            btnActivation = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)girdPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstBalance.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRemarks.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnPrint);
            layoutControl1.Controls.Add(gridNumbers);
            layoutControl1.Controls.Add(btnClear);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(txtName);
            layoutControl1.Controls.Add(girdPeople);
            layoutControl1.Controls.Add(txtType);
            layoutControl1.Controls.Add(txtFirstBalance);
            layoutControl1.Controls.Add(txtRemarks);
            layoutControl1.Controls.Add(btnActivation);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1101, 550);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            btnPrint.Location = new System.Drawing.Point(742, 516);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(347, 22);
            btnPrint.StyleController = layoutControl1;
            btnPrint.TabIndex = 11;
            btnPrint.Text = "چاپ";
            btnPrint.Click += btnPrint_Click;
            // 
            // gridNumbers
            // 
            gridNumbers.Location = new System.Drawing.Point(742, 209);
            gridNumbers.MainView = gridView2;
            gridNumbers.Name = "gridNumbers";
            gridNumbers.Size = new System.Drawing.Size(347, 277);
            gridNumbers.TabIndex = 10;
            gridNumbers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn7 });
            gridView2.GridControl = gridNumbers;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            gridView2.OptionsNavigation.AutoFocusNewRow = true;
            gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "موبایل شمېره";
            gridColumn7.FieldName = "number";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(878, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(99, 22);
            btnClear.StyleController = layoutControl1;
            btnClear.TabIndex = 7;
            btnClear.Text = "پاک";
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(981, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(108, 22);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 6;
            btnSave.Text = "ثبت";
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(742, 12);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(268, 20);
            txtName.StyleController = layoutControl1;
            txtName.TabIndex = 0;
            txtName.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // girdPeople
            // 
            girdPeople.Location = new System.Drawing.Point(12, 12);
            girdPeople.MainView = gridView1;
            girdPeople.Name = "girdPeople";
            girdPeople.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            girdPeople.Size = new System.Drawing.Size(716, 526);
            girdPeople.TabIndex = 9;
            girdPeople.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn8 });
            gridView1.GridControl = girdPeople;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "نوم";
            gridColumn1.FieldName = "Name";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "د کار ډول";
            gridColumn3.FieldName = "PartyType";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "نېټه";
            gridColumn4.FieldName = "CreationDate";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "شمېره";
            gridColumn5.FieldName = "Id";
            gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "فعال/غیر فعال";
            gridColumn6.FieldName = "IsActive";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "بیلانس";
            gridColumn8.FieldName = "Balance";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new System.Drawing.Point(742, 36);
            txtType.Name = "txtType";
            txtType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtType.Size = new System.Drawing.Size(268, 20);
            txtType.StyleController = layoutControl1;
            txtType.TabIndex = 2;
            // 
            // txtFirstBalance
            // 
            txtFirstBalance.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            txtFirstBalance.Location = new System.Drawing.Point(742, 60);
            txtFirstBalance.Name = "txtFirstBalance";
            txtFirstBalance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtFirstBalance.Size = new System.Drawing.Size(268, 20);
            txtFirstBalance.StyleController = layoutControl1;
            txtFirstBalance.TabIndex = 4;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new System.Drawing.Point(742, 84);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txtRemarks.Size = new System.Drawing.Size(268, 121);
            txtRemarks.StyleController = layoutControl1;
            txtRemarks.TabIndex = 5;
            // 
            // btnActivation
            // 
            btnActivation.Location = new System.Drawing.Point(742, 490);
            btnActivation.Name = "btnActivation";
            btnActivation.Size = new System.Drawing.Size(132, 22);
            btnActivation.StyleController = layoutControl1;
            btnActivation.TabIndex = 8;
            btnActivation.Text = "فعالیت تغیر";
            btnActivation.Click += btnActivation_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, splitterItem1, layoutControlItem4, layoutControlItem6, layoutControlItem7, layoutControlItem8, layoutControlItem5, layoutControlItem9, layoutControlItem10, layoutControlItem3 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1101, 550);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = girdPeople;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(720, 530);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtName;
            layoutControlItem2.CustomizationFormText = "نوم";
            layoutControlItem2.Location = new System.Drawing.Point(730, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(351, 24);
            layoutControlItem2.Text = "نوم";
            layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // splitterItem1
            // 
            splitterItem1.Location = new System.Drawing.Point(720, 0);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new System.Drawing.Size(10, 530);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtType;
            layoutControlItem4.Location = new System.Drawing.Point(730, 24);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(351, 24);
            layoutControlItem4.Text = "ډول";
            layoutControlItem4.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnClear;
            layoutControlItem6.Location = new System.Drawing.Point(866, 478);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(103, 26);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = txtFirstBalance;
            layoutControlItem7.Location = new System.Drawing.Point(730, 48);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(351, 24);
            layoutControlItem7.Text = "د شروع بلانس";
            layoutControlItem7.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = txtRemarks;
            layoutControlItem8.Location = new System.Drawing.Point(730, 72);
            layoutControlItem8.MaxSize = new System.Drawing.Size(351, 125);
            layoutControlItem8.MinSize = new System.Drawing.Size(351, 125);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new System.Drawing.Size(351, 125);
            layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem8.Text = "ملاحظات";
            layoutControlItem8.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnSave;
            layoutControlItem5.Location = new System.Drawing.Point(969, 478);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(112, 26);
            layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = gridNumbers;
            layoutControlItem9.Location = new System.Drawing.Point(730, 197);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new System.Drawing.Size(351, 281);
            layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = btnActivation;
            layoutControlItem10.Location = new System.Drawing.Point(730, 478);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new System.Drawing.Size(136, 26);
            layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnPrint;
            layoutControlItem3.Location = new System.Drawing.Point(730, 504);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(351, 26);
            layoutControlItem3.TextVisible = false;
            // 
            // Parties
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1101, 550);
            Controls.Add(layoutControl1);
            Name = "Parties";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "اشخاص";
            FormClosing += Parties_FormClosing;
            Load += Parties_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)girdPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstBalance.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRemarks.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraGrid.GridControl girdPeople;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ComboBoxEdit txtType;
        private DevExpress.XtraEditors.SpinEdit txtFirstBalance;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnActivation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraGrid.GridControl gridNumbers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}