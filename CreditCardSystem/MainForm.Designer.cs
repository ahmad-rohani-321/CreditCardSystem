namespace CreditCardSystem
{
    partial class MainForm
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
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            btnParties = new DevExpress.XtraBars.BarButtonItem();
            btnPercentage = new DevExpress.XtraBars.BarButtonItem();
            btnBuy = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            btnGotoFolder = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(components);
            btnSalesReport = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem9, btnParties, btnPercentage, btnBuy, barButtonItem1, btnGotoFolder, btnSalesReport });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 21;
            ribbon.Name = "ribbon";
            ribbon.OptionsPageCategories.ShowCaptions = false;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.Size = new System.Drawing.Size(1154, 133);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Toolbar.ShowCustomizeItem = false;
            ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barButtonItem9
            // 
            barButtonItem9.Caption = "سیسټم";
            barButtonItem9.Id = 10;
            barButtonItem9.Name = "barButtonItem9";
            barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // btnParties
            // 
            btnParties.Caption = "اشخاص";
            btnParties.Id = 11;
            btnParties.Name = "btnParties";
            btnParties.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            btnParties.ItemClick += btnParties_ItemClick;
            // 
            // btnPercentage
            // 
            btnPercentage.Caption = "فیصدي";
            btnPercentage.Id = 13;
            btnPercentage.Name = "btnPercentage";
            btnPercentage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            btnPercentage.ItemClick += btnPercentage_ItemClick;
            // 
            // btnBuy
            // 
            btnBuy.Caption = "عملیه";
            btnBuy.Id = 15;
            btnBuy.Name = "btnBuy";
            btnBuy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            btnBuy.ItemClick += btnBuy_ItemClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "کهاته";
            barButtonItem1.Id = 18;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // btnGotoFolder
            // 
            btnGotoFolder.Caption = "ډاټابېس";
            btnGotoFolder.Id = 19;
            btnGotoFolder.Name = "btnGotoFolder";
            btnGotoFolder.ItemClick += btnGotoFolder_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnParties);
            ribbonPageGroup1.ItemLinks.Add(btnPercentage);
            ribbonPageGroup1.ItemLinks.Add(btnBuy);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(btnSalesReport);
            ribbonPageGroup1.ItemLinks.Add(btnGotoFolder);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 584);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1154, 43);
            // 
            // documentManager1
            // 
            documentManager1.MdiParent = this;
            documentManager1.MenuManager = ribbon;
            documentManager1.View = tabbedView1;
            documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1 });
            // 
            // defaultLookAndFeel1
            // 
            defaultLookAndFeel1.LookAndFeel.SkinName = "WXI";
            // 
            // btnSalesReport
            // 
            btnSalesReport.Caption = "فروش راپور";
            btnSalesReport.Id = 20;
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.ItemClick += btnSalesReport_ItemClick;
            // 
            // MainForm
            // 
            AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            Appearance.Options.UseFont = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1154, 627);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IconOptions.Image = Properties.Resources.MainIcon;
            IsMdiContainer = true;
            MinimumSize = new System.Drawing.Size(923, 546);
            Name = "MainForm";
            Ribbon = ribbon;
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "عمومي صفحه";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnParties;
        private DevExpress.XtraBars.BarButtonItem btnPercentage;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnBuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnGotoFolder;
        private DevExpress.XtraBars.BarButtonItem btnSalesReport;
    }
}