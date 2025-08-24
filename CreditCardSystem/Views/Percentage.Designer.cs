namespace CreditCardSystem.Views
{
    partial class Percentage
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
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            gridPercentage = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            txtPercentage = new DevExpress.XtraEditors.SpinEdit();
            txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPercentage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPercentage.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRemarks.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnClear);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(gridPercentage);
            layoutControl1.Controls.Add(txtPercentage);
            layoutControl1.Controls.Add(txtRemarks);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(857, 355);
            layoutControl1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(561, 214);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(280, 28);
            btnClear.StyleController = layoutControl1;
            btnClear.TabIndex = 5;
            btnClear.Text = "پاک";
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(561, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(280, 28);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 4;
            btnSave.Text = "ثبت";
            btnSave.Click += btnSave_Click;
            // 
            // gridPercentage
            // 
            gridPercentage.Location = new System.Drawing.Point(16, 16);
            gridPercentage.MainView = gridView1;
            gridPercentage.Name = "gridPercentage";
            gridPercentage.Size = new System.Drawing.Size(523, 323);
            gridPercentage.TabIndex = 2;
            gridPercentage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3 });
            gridView1.GridControl = gridPercentage;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "فیصدي";
            gridColumn1.FieldName = "Value";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "نېټه";
            gridColumn2.FieldName = "CreationDate";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "ملاحظات";
            gridColumn3.FieldName = "Remarks";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // txtPercentage
            // 
            txtPercentage.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            txtPercentage.Location = new System.Drawing.Point(561, 16);
            txtPercentage.Name = "txtPercentage";
            txtPercentage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtPercentage.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            txtPercentage.Properties.MaskSettings.Set("mask", "P");
            txtPercentage.Size = new System.Drawing.Size(213, 34);
            txtPercentage.StyleController = layoutControl1;
            txtPercentage.TabIndex = 0;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new System.Drawing.Point(561, 56);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txtRemarks.Size = new System.Drawing.Size(213, 118);
            txtRemarks.StyleController = layoutControl1;
            txtRemarks.TabIndex = 3;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, splitterItem1, layoutControlItem5, emptySpaceItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(857, 355);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridPercentage;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(529, 329);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtPercentage;
            layoutControlItem2.Location = new System.Drawing.Point(545, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(286, 40);
            layoutControlItem2.Text = "فیصدي";
            layoutControlItem2.TextSize = new System.Drawing.Size(51, 19);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnSave;
            layoutControlItem3.Location = new System.Drawing.Point(545, 164);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(286, 34);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnClear;
            layoutControlItem4.Location = new System.Drawing.Point(545, 198);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(286, 34);
            layoutControlItem4.TextVisible = false;
            // 
            // splitterItem1
            // 
            splitterItem1.Location = new System.Drawing.Point(529, 0);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new System.Drawing.Size(16, 329);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtRemarks;
            layoutControlItem5.Location = new System.Drawing.Point(545, 40);
            layoutControlItem5.MaxSize = new System.Drawing.Size(0, 124);
            layoutControlItem5.MinSize = new System.Drawing.Size(83, 124);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(286, 124);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.Text = "ملاحظات";
            layoutControlItem5.TextSize = new System.Drawing.Size(51, 19);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(545, 232);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(286, 97);
            // 
            // Percentage
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(857, 355);
            Controls.Add(layoutControl1);
            Font = new System.Drawing.Font("Calibri", 12F);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Percentage";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Text = "فیصدي";
            FormClosing += Percentage_FormClosing;
            Load += Percentage_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPercentage.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRemarks.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridPercentage;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.SpinEdit txtPercentage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}