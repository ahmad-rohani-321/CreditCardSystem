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

namespace CreditCardSystem.Views
{
    public partial class Percentage : XtraForm
    {
        private readonly Controllers.Percent _percent;
        private int _id;
        public Percentage()
        {
            InitializeComponent();
            _percent = new();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPercentage.Value <= 0)
            {
                txtPercentage.ErrorText = "لطفاً فیصدي ولیکئ";
            }
            else if (txtPercentage.Value > 100)
            {
                txtPercentage.ErrorText = "فیصدي د 100 نه زیاته نسي کیدی";
            }
            else
            {
                txtPercentage.ErrorText = string.Empty;
                if (_id == 0)
                {
                    // do add
                    bool added = _percent.AddPercentage(txtPercentage.Value, txtRemarks.Text);
                    if (added)
                        Defaults.MessageBox();
                    else
                        Defaults.ErrorMessageBox();
                }
                else
                {
                    // do update
                    bool update = _percent.UpdatePercentage(_id, txtPercentage.Value, txtRemarks.Text);
                    if (update)
                        Defaults.MessageBox();
                    else
                        Defaults.ErrorMessageBox();
                }
                ClearForm();
                Refresh();
            }
        }
        private void ClearForm()
        {
            txtPercentage.Value = 0;
            txtPercentage.ErrorText = string.Empty;
            txtRemarks.Text = string.Empty;
        }

        private new void Refresh()
        {
            gridPercentage.DataSource = _percent.GetPercentages();
            gridPercentage.Refresh();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Percentage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _percent.Dispose();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                _id = (int)gridView1.GetFocusedRowCellValue("Id");
                var getInfo = _percent.GetSingle(_id);
                if (getInfo != null)
                {
                    txtPercentage.Value = getInfo.Value;
                    txtRemarks.Text = getInfo.Remarks;
                }
            }
        }

        private void Percentage_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}