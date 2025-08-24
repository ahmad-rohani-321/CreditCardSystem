using DevExpress.XtraDiagram.Bars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardSystem.Views
{
    public partial class Ledger : DevExpress.XtraEditors.XtraForm
    {
        private readonly Controllers.Ledger _ledger;
        private readonly Controllers.Parties _parties;
        public Ledger()
        {
            InitializeComponent();
            _ledger = new();
            _parties = new();
        }
        #region Visual studio generated code
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                gridLedger.DataSource = _ledger.GetGeneralLedger(
                    (int)txtAccount.EditValue,
                    txtStartDate.DateTime,
                    txtEndDate.DateTime);
            }
        }

        private void Ledger_Load(object sender, EventArgs e)
        {
            txtAccount.Properties.DataSource  = _parties.GetActiveParties();
            txtEndDate.DateTime = DateTime.Now;
            txtStartDate.DateTime = DateTime.Now.AddDays(-10);
        }

        private void Ledger_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ledger.Dispose();
        }
        #endregion

        #region Hand written code

        private bool Valid()
        {
            bool result = true;
            // Pashto error messages
            const string accountError = "اکونټ انتخاب نه سو";
            const string startDateError = "د پیل نیټه انتخاب نه سو";
            const string endDateError = "د پای نیټه انتخاب نه سو";
            const string dateOrderError = "د پیل نیټه باید د پای نیټې نه مخکې وي";

            // Clear previous error

            // Check account
            if (txtAccount.EditValue == null && (string)txtAccount.EditValue == "")
            {
                txtAccount.ErrorText = accountError;
                result = false;
            }
            else
            {
                txtAccount.ErrorText = string.Empty; // Clear error if account is valid
            }

            // Check start date
            if (txtStartDate.EditValue == null)
            {
                txtStartDate.ErrorText = startDateError;
                result = false;
            }

            // Check end date
            else if (txtEndDate.EditValue == null)
            {
                txtEndDate.ErrorText = endDateError;
                result = false;
            }

            else if (txtStartDate.DateTime > txtEndDate.DateTime)
            {
                txtStartDate.ErrorText = dateOrderError;
                result = false;
            }
            else
            {
                txtEndDate.ErrorText = string.Empty; // Clear error if end date is valid
                txtStartDate.ErrorText = string.Empty; // Clear error if dates are valid
            }

            return result;
        }
        private void ClearForm()
        {
            txtAccount.EditValue = null;
            txtStartDate.DateTime = DateTime.Now.AddDays(-10);
            txtEndDate.DateTime = DateTime.Now;
        }
        #endregion


    }
}