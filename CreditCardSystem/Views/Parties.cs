using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CreditCardSystem.Views
{
    public partial class Parties : XtraForm
    {
        #region fields
        private readonly Controllers.Parties _parties;
        private int _id = 0;
        private readonly DataTable _numbers;
        #endregion

        #region Constructor
        public Parties()
        {
            InitializeComponent();
            _parties = new();
            _numbers = new();
            _numbers.Columns.Add("number", typeof(string));
            gridNumbers.DataSource = _numbers;
            txtType.Properties.Items.AddRange(Defaults.DefaultPartyTypes);
            txtType.SelectedIndex = 0;
        }
        #endregion

        #region events
        private void btnPrint_Click(object sender, EventArgs e)
        {

            Reports.Parties party = new Reports.Parties();
            party.DataSource = _parties.GetParties();
            party.CreateDocument();
            ReportPrintTool printTool = new ReportPrintTool(party);
            printTool.ShowPreviewDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                if (_id == 0)
                {
                    // do new
                    List<string> number = DataTableToList();
                    bool added = _parties.AddParty(
                        new() { CreationDate = DateTime.Now, Name = txtName.Text, PartyType = txtType.Text, Remarks = txtRemarks.Text, PhoneNumbers = number, Balance = txtFirstBalance.Value });
                    if (added)
                        Defaults.MessageBox();
                    else
                        Defaults.ErrorMessageBox();
                }
                else
                {
                    // do update
                    List<string> number = DataTableToList();
                    bool updated = _parties.UpdateParty(
                        new() { Id = _id, Name = txtName.Text, PartyType = txtType.Text, Remarks = txtRemarks.Text, PhoneNumbers = number });
                    if (updated)
                        Defaults.MessageBox();
                    else
                        Defaults.ErrorMessageBox();
                }
                ClearForm();
                RefreshData();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Parties_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                _id = (int)gridView1.GetFocusedRowCellValue("Id");
                Model.Party getInfo = _parties.GetPartyById(_id);
                if (getInfo.IsEditable)
                {
                    txtName.Text = getInfo.Name;
                    txtRemarks.Text = getInfo.Remarks;
                    txtType.Text = getInfo.PartyType;
                    txtFirstBalance.Enabled = false;
                    ListToDataTable(getInfo.PhoneNumbers);
                }
                else
                    Defaults.ErrorMessageBox("شخص د تغیر وړ نه دی!");
            }
        }
        private void btnActivation_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                Model.Party party = (Model.Party)gridView1.GetFocusedRow();
                if (party.IsEditable && Defaults.YesNoMessageBox("غواړئ د شخص فعالیت تغیر کړئ؟") == DialogResult.Yes)
                {
                    if (_parties.ChangeActivation(party.Id))
                        Defaults.MessageBox();
                    else
                        Defaults.ErrorMessageBox();

                    RefreshData();
                }
                else if (!party.IsEditable)
                {
                    Defaults.MessageBox("شخص د تغیر وړ نه دی!");
                }
            }
        }

        private void Parties_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parties.Dispose();
        }
        #endregion

        #region Hand written code
        private List<string> DataTableToList()
        {
            List<string> number = new();
            foreach (DataRow row in _numbers.Rows)
            {
                number.Add(row[0].ToString());
            }
            return number;
        }
        private void ListToDataTable(List<string> list)
        {
            _numbers.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                _numbers.Rows.Add(list[i]);
            }
        }
        private new bool Validated()
        {

            bool result = true;
            if (txtName.Text.Equals(string.Empty))
            {
                txtName.ErrorText = "لطفاً نوم ولیکئ";
                result = false;
            }
            else
                txtName.ErrorText = string.Empty;

            if (txtType.SelectedIndex < 0)
            {
                txtType.ErrorText = "لطفاً ډول ولیکئ";
                result = false;
            }
            else
                txtType.ErrorText = string.Empty;


            return result;
        }

        private void ClearForm()
        {
            txtName.Text = string.Empty;
            txtName.ErrorText = string.Empty;
            txtType.SelectedIndex = 0;
            txtType.ErrorText = string.Empty;
            txtFirstBalance.Value = 0;
            txtFirstBalance.ErrorText = string.Empty;
            txtFirstBalance.Enabled = true;
            txtRemarks.Text = string.Empty;
            Text = "شخص";
            _numbers.Rows.Clear();
        }


        private void RefreshData()
        {
            girdPeople.DataSource = _parties.GetParties();
            girdPeople.Refresh();
        }
        #endregion

    }
}