using CreditCardSystem.Views;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardSystem
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnParties_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<Parties>().FirstOrDefault() == null)
            {
                Parties form = new();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                Application.OpenForms.OfType<Parties>().FirstOrDefault().Focus();
            }
        }

        private void btnPercentage_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            // Set required Input Box options
            args.Caption = "فیصدي";
            args.Prompt = "فیصدي";
            args.DefaultButtonIndex = 0;
            // Initialize a DateEdit editor with custom settings
            SpinEdit editor = new SpinEdit();
            args.Editor = editor;
            // A default DateEdit value
            args.DefaultResponse = Properties.Settings.Default.Percent;
            // Display an Input Box with the custom editor
            decimal result = XtraInputBox.Show(args) == null ? 0 : (decimal)XtraInputBox.Show(args);
            if (result != 0 )
            {
                Properties.Settings.Default.Percent = result;
                Properties.Settings.Default.Save();
            }
        }

        private void btnBuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (Application.OpenForms.OfType<TransactionActions>().FirstOrDefault() == null)
            {
                TransactionActions buy = new();
                buy.MdiParent = this;
                buy.Show();
            }
            else
            {
                Application.OpenForms.OfType<TransactionActions>().FirstOrDefault().Focus();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (Application.OpenForms.OfType<Ledger>().FirstOrDefault() == null)
            {
                Ledger ledger = new();
                ledger.MdiParent = this;
                ledger.Show();
            }
            else
            {
                Application.OpenForms.OfType<Ledger>().FirstOrDefault().Focus();
            }
        }

        private void btnGotoFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Defaults.DatabaseFolderPath);
        }

        private void btnSalesReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (Application.OpenForms.OfType<SalesReport>().FirstOrDefault() == null)
            {
                SalesReport report = new();
                report.MdiParent = this;
                report.Show();
            }
            else
            {
                Application.OpenForms.OfType<SalesReport>().FirstOrDefault().Focus();
            }
        }
    }
}