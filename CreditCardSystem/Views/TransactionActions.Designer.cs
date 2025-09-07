namespace CreditCardSystem.Views
{
    partial class TransactionActions
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
            components = new System.ComponentModel.Container();
            calendar = new DevExpress.XtraEditors.Controls.CalendarControl();
            txtValue = new DevExpress.XtraEditors.SpinEdit();
            txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            txtTransactionTypes = new DevExpress.XtraEditors.ComboBoxEdit();
            layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(components);
            TransactionActionslayoutControl2ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            txtPhoneNumbers = new DevExpress.XtraEditors.ComboBoxEdit();
            lblToBalance = new DevExpress.XtraEditors.LabelControl();
            lblFromBalance = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txtFromAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            txtToAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            txtCashType = new DevExpress.XtraEditors.ComboBoxEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)calendar.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtValue.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRemarks.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTransactionTypes.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransactionActionslayoutControl2ConvertedLayout).BeginInit();
            TransactionActionslayoutControl2ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumbers.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFromAccount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtToAccount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCashType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            SuspendLayout();
            // 
            // calendar
            // 
            calendar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            calendar.AutoSize = false;
            calendar.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            calendar.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calendar.Location = new System.Drawing.Point(11, 5);
            calendar.Name = "calendar";
            calendar.ShowClearButton = true;
            calendar.ShowWeekNumbers = true;
            calendar.Size = new System.Drawing.Size(514, 414);
            calendar.TabIndex = 2;
            // 
            // txtValue
            // 
            txtValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtValue.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            txtValue.Location = new System.Drawing.Point(531, 234);
            txtValue.Name = "txtValue";
            txtValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtValue.Size = new System.Drawing.Size(318, 34);
            txtValue.TabIndex = 5;
            txtValue.EditValueChanged += txtValue_EditValueChanged;
            // 
            // txtRemarks
            // 
            txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtRemarks.Location = new System.Drawing.Point(531, 318);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txtRemarks.Size = new System.Drawing.Size(318, 113);
            txtRemarks.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(695, 437);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(154, 28);
            btnSave.TabIndex = 7;
            btnSave.Text = "ثبت";
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClear.Location = new System.Drawing.Point(531, 437);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(158, 28);
            btnClear.TabIndex = 8;
            btnClear.Text = "پاک";
            btnClear.Click += btnClear_Click;
            // 
            // txtTransactionTypes
            // 
            txtTransactionTypes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtTransactionTypes.Location = new System.Drawing.Point(531, 8);
            txtTransactionTypes.Name = "txtTransactionTypes";
            txtTransactionTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtTransactionTypes.Properties.PopupSizeable = true;
            txtTransactionTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtTransactionTypes.Size = new System.Drawing.Size(318, 34);
            txtTransactionTypes.TabIndex = 0;
            txtTransactionTypes.SelectedIndexChanged += txtTransactionTypes_SelectedIndexChanged;
            // 
            // TransactionActionslayoutControl2ConvertedLayout
            // 
            TransactionActionslayoutControl2ConvertedLayout.Controls.Add(groupControl1);
            TransactionActionslayoutControl2ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            TransactionActionslayoutControl2ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            TransactionActionslayoutControl2ConvertedLayout.Name = "TransactionActionslayoutControl2ConvertedLayout";
            TransactionActionslayoutControl2ConvertedLayout.OptionsView.RightToLeftMirroringApplied = true;
            TransactionActionslayoutControl2ConvertedLayout.Root = layoutControlGroup1;
            TransactionActionslayoutControl2ConvertedLayout.Size = new System.Drawing.Size(977, 544);
            TransactionActionslayoutControl2ConvertedLayout.TabIndex = 1;
            // 
            // groupControl1
            // 
            groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(txtPhoneNumbers);
            groupControl1.Controls.Add(lblToBalance);
            groupControl1.Controls.Add(lblFromBalance);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(calendar);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(txtValue);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(txtRemarks);
            groupControl1.Controls.Add(btnSave);
            groupControl1.Controls.Add(btnClear);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(txtTransactionTypes);
            groupControl1.Controls.Add(txtFromAccount);
            groupControl1.Controls.Add(txtToAccount);
            groupControl1.Controls.Add(txtCashType);
            groupControl1.Location = new System.Drawing.Point(16, 16);
            groupControl1.Name = "groupControl1";
            groupControl1.ShowCaption = false;
            groupControl1.Size = new System.Drawing.Size(945, 512);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "Root";
            // 
            // labelControl7
            // 
            labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl7.Location = new System.Drawing.Point(855, 173);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(84, 19);
            labelControl7.TabIndex = 13;
            labelControl7.Text = "د موبایل شمېرې";
            // 
            // txtPhoneNumbers
            // 
            txtPhoneNumbers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtPhoneNumbers.Location = new System.Drawing.Point(531, 166);
            txtPhoneNumbers.Name = "txtPhoneNumbers";
            txtPhoneNumbers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPhoneNumbers.Size = new System.Drawing.Size(318, 34);
            txtPhoneNumbers.TabIndex = 12;
            // 
            // lblToBalance
            // 
            lblToBalance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblToBalance.Location = new System.Drawing.Point(531, 207);
            lblToBalance.Name = "lblToBalance";
            lblToBalance.Size = new System.Drawing.Size(0, 19);
            lblToBalance.TabIndex = 10;
            // 
            // lblFromBalance
            // 
            lblFromBalance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFromBalance.Location = new System.Drawing.Point(531, 92);
            lblFromBalance.Name = "lblFromBalance";
            lblFromBalance.Size = new System.Drawing.Size(0, 19);
            lblFromBalance.TabIndex = 10;
            // 
            // labelControl1
            // 
            labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl1.Location = new System.Drawing.Point(855, 56);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(84, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "له حساب څخه";
            // 
            // labelControl2
            // 
            labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl2.Location = new System.Drawing.Point(855, 132);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(53, 19);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "حساب ته";
            // 
            // labelControl3
            // 
            labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl3.Location = new System.Drawing.Point(855, 240);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(23, 19);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "مبلغ";
            // 
            // labelControl6
            // 
            labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl6.Location = new System.Drawing.Point(855, 283);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(56, 19);
            labelControl6.TabIndex = 6;
            labelControl6.Text = "د نقد ډول";
            // 
            // labelControl4
            // 
            labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl4.Location = new System.Drawing.Point(855, 326);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(51, 19);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "ملاحظات";
            // 
            // labelControl5
            // 
            labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelControl5.Location = new System.Drawing.Point(855, 15);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(57, 19);
            labelControl5.TabIndex = 9;
            labelControl5.Text = "عملیې ډول";
            // 
            // txtFromAccount
            // 
            txtFromAccount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtFromAccount.Location = new System.Drawing.Point(531, 50);
            txtFromAccount.Name = "txtFromAccount";
            txtFromAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtFromAccount.Properties.DisplayMember = "Name";
            txtFromAccount.Properties.PopupView = searchLookUpEdit1View;
            txtFromAccount.Size = new System.Drawing.Size(318, 34);
            txtFromAccount.TabIndex = 3;
            txtFromAccount.EditValueChanged += txtFrom_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn3 });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            gridColumn3.Caption = "ډول";
            gridColumn3.FieldName = "PartyType";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            // 
            // txtToAccount
            // 
            txtToAccount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtToAccount.Location = new System.Drawing.Point(531, 126);
            txtToAccount.Name = "txtToAccount";
            txtToAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtToAccount.Properties.DisplayMember = "Name";
            txtToAccount.Properties.PopupView = gridView1;
            txtToAccount.Size = new System.Drawing.Size(318, 34);
            txtToAccount.TabIndex = 4;
            txtToAccount.EditValueChanged += txtSystem_EditValueChanged;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn4, gridColumn6 });
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "نوم";
            gridColumn4.FieldName = "Name";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "ډول";
            gridColumn6.FieldName = "PartyType";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 1;
            // 
            // txtCashType
            // 
            txtCashType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            txtCashType.EditValue = "رسیدګي";
            txtCashType.Enabled = false;
            txtCashType.Location = new System.Drawing.Point(531, 276);
            txtCashType.Name = "txtCashType";
            txtCashType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtCashType.Properties.DropDownRows = 2;
            txtCashType.Properties.Items.AddRange(new object[] { "رسیدګي", "بردګي" });
            txtCashType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            txtCashType.Size = new System.Drawing.Size(318, 34);
            txtCashType.TabIndex = 11;
            txtCashType.SelectedIndexChanged += txtCashType_SelectedIndexChanged;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem9 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(977, 544);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = groupControl1;
            layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new System.Drawing.Size(951, 518);
            layoutControlItem9.TextVisible = false;
            // 
            // TransactionActions
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(977, 544);
            Controls.Add(TransactionActionslayoutControl2ConvertedLayout);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "TransactionActions";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "عملیه";
            FormClosing += TransactionActions_FormClosing;
            Load += TransactionActions_Load;
            ((System.ComponentModel.ISupportInitialize)calendar.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtValue.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRemarks.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTransactionTypes.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransactionActionslayoutControl2ConvertedLayout).EndInit();
            TransactionActionslayoutControl2ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNumbers.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFromAccount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtToAccount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCashType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.Controls.CalendarControl calendar;
        private DevExpress.XtraEditors.SpinEdit txtValue;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.ComboBoxEdit txtTransactionTypes;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControl TransactionActionslayoutControl2ConvertedLayout;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LabelControl lblFromBalance;
        private DevExpress.XtraEditors.LabelControl lblToBalance;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit txtToAccount;
        private DevExpress.XtraEditors.SearchLookUpEdit txtFromAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.ComboBoxEdit txtCashType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit txtPhoneNumbers;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}