﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LecERP.PrintDesign;

namespace LecERP
{
    public partial class Form_Fiches : DevExpress.XtraEditors.XtraForm
    {
        public Form_Fiches()
        {
            InitializeComponent();
        }

        private void Form_Fiches_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            tsAddNew.Enabled = StaticData.IsPermitted(20);
            tsModify.Enabled = StaticData.IsPermitted(21);
            tsDelete.Enabled = StaticData.IsPermitted(22);
            btnCreateInvoice.Enabled = StaticData.IsPermitted(23);
            tsPrintDocument.Enabled = StaticData.IsPermitted(24);
            tsExecutePayment.Enabled = StaticData.IsPermitted(33);
            
        }

        private void Form_Fiches_Shown(object sender, EventArgs e)
        {
            gvData.AssignGridView(15);
            gvData.Columns["WeightTotal"].Visible = StaticData.weightVisible;
            Operation<List<DocumentMaster>> op_DocumentMasters = OperationHandler.GetDocumentMasters();

            if (!op_DocumentMasters.Successful)
            {
                

            }
            lookUpFicheType.Properties.DataSource = op_DocumentMasters.Value;
            if (op_DocumentMasters.Value.Count > 0) lookUpFicheType.ItemIndex = 0;



        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            if (lookUpFicheType.EditValue == null) return;
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.DocTypeId = Convert.ToByte(lookUpFicheType.EditValue);
            manp.IsEditMode = true;
            manp.ShowDialog();
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        void RefreshData()
        {
            if (lookUpFicheType.EditValue == null) return;
            Operation<List<FicheMasterView>> op_Fiches = OperationHandler.GetFiches(Convert.ToByte(lookUpFicheType.EditValue), dateBegin.DateTime, dateEnd.DateTime);
            gcData.DataSource = op_Fiches.Value;
        }

        private void lookUpFicheType_EditValueChanged(object sender, EventArgs e)
        {
            gcData.DataSource = null;
        }

        private void tsModify_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.Id = CurrentId;
            manp.IsEditMode = true;
            manp.ShowDialog();
            RefreshData();
        }

        void openForViewOnly()
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.Id = CurrentId;
            manp.ShowDialog();
            RefreshData();
        }

        private void tsView_Click(object sender, EventArgs e)
        {
            openForViewOnly();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            FicheMasterView fmv = (FicheMasterView)gvData.GetFocusedRow();
            if (fmv.DocTypeId != 1) return;
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.Id = CurrentId;
            manp.IsEditMode = true;
            manp.CreateInvoiceFromOrderFiche = true;
            manp.ShowDialog();
            RefreshData();
        }

        private void tsPrintDocument_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            DocumentPrintHandler.PrintSaleInvoice(CurrentId);
        }

        private void tsExecutePayment_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            FicheMasterView fmv = (FicheMasterView)gvData.GetFocusedRow();
            if (fmv.DocTypeId != 2) return;
            Dialog_DecimalInput decin = new Dialog_DecimalInput();
            decin.Text = "Məbləği daxil edin";
            decin.Value = fmv.Total;
            decin.ShowDialog();
            if (decin.IsOk)
            {
                if (decin.Value <= 0)
                {
                    XtraMessageBox.Show("Səhv daxil edildi");
                    return;
                }
                CashTransaction cashTransaction = new CashTransaction();
                cashTransaction.TransactionType = 3;
                cashTransaction.ExchangeId = fmv.ExchangeId;
                cashTransaction.Note = fmv.Ficheno;
                cashTransaction.CreatedBy = StaticData.CurrentUserId;
                cashTransaction.CreatedDate = DateTime.Now;
               
                cashTransaction.Total = decin.Value;
                cashTransaction.SourceCardId = fmv.CardId;
                cashTransaction.DestCardId = Convert.ToInt32(StaticData.BaseSettings.Where(x => x.ParameterKey == "Default.Cash.CardId.ForPayment").First().ParameterValue);
                Operation<CashTransaction> postedCashTransaction = OperationHandler.PostCashTransaction(cashTransaction);
                if (postedCashTransaction.Successful)
                {
                    XtraMessageBox.Show("Ödəniş qəbul olundu. Kassa Tranzaksiya no : " + postedCashTransaction.Value.Ficheno);
                }
                else
                {
                    XtraMessageBox.Show(postedCashTransaction.Fail);
                }
            }
            RefreshData();
        }

        private void tsExportToExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }

        private void tsBeginProcess_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            FicheMasterView fmv = (FicheMasterView)gvData.GetFocusedRow();
            if (fmv.DocTypeId != 1) return;
            Operation<Fiche> operation = OperationHandler.ChangeFicheStatus(fmv.Id, 2);
            if (operation.Successful)
            {
                XtraMessageBox.Show("Proses Başladı");
            }
            else
            {
                XtraMessageBox.Show("Səhvlik oldu : " + operation.Fail);
            }
            RefreshData();
        }

        private void tsCompleteProcess_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            FicheMasterView fmv = (FicheMasterView)gvData.GetFocusedRow();
            if (fmv.DocTypeId != 1) return;
            Operation<Fiche> operation = OperationHandler.ChangeFicheStatus(fmv.Id, 3);
            if (operation.Successful)
            {
                XtraMessageBox.Show("Proses Tamamlandı");
            }
            else
            {
                XtraMessageBox.Show("Səhvlik oldu : " + operation.Fail);
            }
            RefreshData();
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            openForViewOnly();
        }
    }
}