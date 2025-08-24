using CreditCardSystem.Views;
using DevExpress.XtraBars;
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
            Parties form = new();
            form.MdiParent = this;
            form.Show();
        }

        private void btnPercentage_ItemClick(object sender, ItemClickEventArgs e)
        {
            Percentage percentage = new();
            percentage.MdiParent = this;
            percentage.Show();
        }

        private void btnBuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            TransactionActions buy = new();
            buy.MdiParent = this;
            buy.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ledger ledger = new();
            ledger.MdiParent = this;
            ledger.Show();
        }

        private void btnGotoFolder_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Defaults.DatabaseFolderPath);
        }

        private void btnSalesReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SalesReport report = new();
            report.MdiParent = this;
            report.Show();
        }
    }
}