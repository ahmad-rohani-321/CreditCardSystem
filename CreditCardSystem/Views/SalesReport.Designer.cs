namespace CreditCardSystem.Views
{
    partial class SalesReport
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
            gridLedger = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            txtStartDate = new DevExpress.XtraEditors.DateEdit();
            txtEndDate = new DevExpress.XtraEditors.DateEdit();
            btnSearch = new DevExpress.XtraEditors.SimpleButton();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            txtAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLedger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEndDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAccount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gridLedger);
            layoutControl1.Controls.Add(txtStartDate);
            layoutControl1.Controls.Add(txtEndDate);
            layoutControl1.Controls.Add(btnSearch);
            layoutControl1.Controls.Add(btnClear);
            layoutControl1.Controls.Add(txtAccount);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1245, 657);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridLedger
            // 
            gridLedger.Location = new System.Drawing.Point(16, 16);
            gridLedger.MainView = gridView1;
            gridLedger.Name = "gridLedger";
            gridLedger.Size = new System.Drawing.Size(867, 625);
            gridLedger.TabIndex = 2;
            gridLedger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn5, gridColumn6, gridColumn7, gridColumn8, gridColumn9, gridColumn4, gridColumn10, gridColumn11 });
            gridView1.GridControl = gridLedger;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "شمېره";
            gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "ډول";
            gridColumn2.FieldName = "TransactionType";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "حساب";
            gridColumn3.FieldName = "FromParty.Name";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "نېټه";
            gridColumn5.FieldName = "CreationDate";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "رسیدګي";
            gridColumn6.FieldName = "Credit";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "بردګي";
            gridColumn7.FieldName = "Debit";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "بیلانس";
            gridColumn8.FieldName = "Balance";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn9
            // 
            gridColumn9.Caption = "ملاحظات";
            gridColumn9.FieldName = "Remarks";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 9;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "موبایل شمېره";
            gridColumn4.FieldName = "PhoneNumber";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            gridColumn10.Caption = "فیصدي";
            gridColumn10.FieldName = "Percentage.Value";
            gridColumn10.Name = "gridColumn10";
            gridColumn10.Visible = true;
            gridColumn10.VisibleIndex = 7;
            // 
            // gridColumn11
            // 
            gridColumn11.Caption = "ګټه";
            gridColumn11.FieldName = "gridColumn11";
            gridColumn11.Name = "gridColumn11";
            gridColumn11.UnboundDataType = typeof(decimal);
            gridColumn11.UnboundExpression = "[Percentage.Value] * [Balance]";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 8;
            // 
            // txtStartDate
            // 
            txtStartDate.EditValue = null;
            txtStartDate.Location = new System.Drawing.Point(905, 56);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtStartDate.Size = new System.Drawing.Size(256, 34);
            txtStartDate.StyleController = layoutControl1;
            txtStartDate.TabIndex = 4;
            // 
            // txtEndDate
            // 
            txtEndDate.EditValue = null;
            txtEndDate.Location = new System.Drawing.Point(905, 96);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEndDate.Size = new System.Drawing.Size(256, 34);
            txtEndDate.StyleController = layoutControl1;
            txtEndDate.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(1070, 136);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(159, 28);
            btnSearch.StyleController = layoutControl1;
            btnSearch.TabIndex = 6;
            btnSearch.Text = "پلټنه";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(905, 136);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(159, 28);
            btnClear.StyleController = layoutControl1;
            btnClear.TabIndex = 7;
            btnClear.Text = "پاک";
            btnClear.Click += btnClear_Click;
            // 
            // txtAccount
            // 
            txtAccount.Location = new System.Drawing.Point(905, 16);
            txtAccount.Name = "txtAccount";
            txtAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtAccount.Properties.DisplayMember = "Name";
            txtAccount.Properties.NullText = "";
            txtAccount.Properties.PopupView = searchLookUpEdit1View;
            txtAccount.Properties.ValueMember = "Id";
            txtAccount.Size = new System.Drawing.Size(256, 34);
            txtAccount.StyleController = layoutControl1;
            txtAccount.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn12, gridColumn14 });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn12
            // 
            gridColumn12.Caption = "نوم";
            gridColumn12.FieldName = "Name";
            gridColumn12.Name = "gridColumn12";
            gridColumn12.Visible = true;
            gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn14
            // 
            gridColumn14.Caption = "ډول";
            gridColumn14.FieldName = "PartyType";
            gridColumn14.Name = "gridColumn14";
            gridColumn14.Visible = true;
            gridColumn14.VisibleIndex = 1;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, splitterItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1245, 657);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridLedger;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(873, 631);
            layoutControlItem1.TextVisible = false;
            // 
            // splitterItem1
            // 
            splitterItem1.Location = new System.Drawing.Point(873, 0);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new System.Drawing.Size(16, 631);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtAccount;
            layoutControlItem3.Location = new System.Drawing.Point(889, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(330, 40);
            layoutControlItem3.Text = "اکاونټ";
            layoutControlItem3.TextSize = new System.Drawing.Size(52, 19);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtStartDate;
            layoutControlItem4.Location = new System.Drawing.Point(889, 40);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(330, 40);
            layoutControlItem4.Text = "شروع نېټه";
            layoutControlItem4.TextSize = new System.Drawing.Size(52, 19);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtEndDate;
            layoutControlItem5.Location = new System.Drawing.Point(889, 80);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(330, 40);
            layoutControlItem5.Text = "ختم نېټه";
            layoutControlItem5.TextSize = new System.Drawing.Size(52, 19);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnSearch;
            layoutControlItem6.Location = new System.Drawing.Point(1054, 120);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(165, 511);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = btnClear;
            layoutControlItem7.Location = new System.Drawing.Point(889, 120);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(165, 511);
            layoutControlItem7.TextVisible = false;
            // 
            // SalesReport
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1245, 657);
            Controls.Add(layoutControl1);
            Font = new System.Drawing.Font("Calibri", 12F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "SalesReport";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "کهاته";
            FormClosing += Ledger_FormClosing;
            Load += Ledger_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLedger).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEndDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAccount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private DevExpress.XtraEditors.DateEdit txtEndDate;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SearchLookUpEdit txtAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}