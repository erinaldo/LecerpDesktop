﻿namespace LecERP
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.xtraTDMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.navbarMain = new DevExpress.XtraNavBar.NavBarControl();
            this.nvProcesses = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvFiches = new DevExpress.XtraNavBar.NavBarItem();
            this.nvCashTransaction = new DevExpress.XtraNavBar.NavBarItem();
            this.nvWarehouseProcesses = new DevExpress.XtraNavBar.NavBarItem();
            this.nvDeclarations = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvItems = new DevExpress.XtraNavBar.NavBarItem();
            this.nvCards = new DevExpress.XtraNavBar.NavBarItem();
            this.nvPrices = new DevExpress.XtraNavBar.NavBarItem();
            this.nvCurrencyByDate = new DevExpress.XtraNavBar.NavBarItem();
            this.nvReports = new DevExpress.XtraNavBar.NavBarGroup();
            this.nv_CardDebtReport = new DevExpress.XtraNavBar.NavBarItem();
            this.nv_ItemReport = new DevExpress.XtraNavBar.NavBarItem();
            this.nvFicheReportLineView = new DevExpress.XtraNavBar.NavBarItem();
            this.nvAdministration = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvUsers = new DevExpress.XtraNavBar.NavBarItem();
            this.nvSettings = new DevExpress.XtraNavBar.NavBarItem();
            this.nvWorkStateView = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTDMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarMain)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTDMain
            // 
            this.xtraTDMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTDMain.MdiParent = this;
            // 
            // navbarMain
            // 
            this.navbarMain.ActiveGroup = this.nvProcesses;
            this.navbarMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbarMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvDeclarations,
            this.nvProcesses,
            this.nvReports,
            this.nvAdministration});
            this.navbarMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nvItems,
            this.nvCards,
            this.nvPrices,
            this.nvFiches,
            this.nvUsers,
            this.nvCashTransaction,
            this.nv_CardDebtReport,
            this.nvSettings,
            this.nv_ItemReport,
            this.nvCurrencyByDate,
            this.nvWarehouseProcesses,
            this.nvFicheReportLineView,
            this.nvWorkStateView});
            this.navbarMain.Location = new System.Drawing.Point(0, 0);
            this.navbarMain.Name = "navbarMain";
            this.navbarMain.OptionsNavPane.ExpandedWidth = 173;
            this.navbarMain.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navbarMain.Size = new System.Drawing.Size(173, 735);
            this.navbarMain.TabIndex = 1;
            this.navbarMain.Text = "navBarControl1";
            // 
            // nvProcesses
            // 
            this.nvProcesses.Caption = "Proseslər";
            this.nvProcesses.Expanded = true;
            this.nvProcesses.ImageOptions.SmallImage = global::LecERP.Properties.Resources.properties_16x16;
            this.nvProcesses.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvFiches),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCashTransaction),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvWarehouseProcesses)});
            this.nvProcesses.Name = "nvProcesses";
            // 
            // nvFiches
            // 
            this.nvFiches.Caption = "Qaimələr";
            this.nvFiches.ImageOptions.SmallImage = global::LecERP.Properties.Resources.invoiceee2424;
            this.nvFiches.Name = "nvFiches";
            this.nvFiches.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvFiches_LinkClicked);
            // 
            // nvCashTransaction
            // 
            this.nvCashTransaction.Caption = "Kassa Əməliyyatları";
            this.nvCashTransaction.ImageOptions.SmallImage = global::LecERP.Properties.Resources.safe_icon_png_2424;
            this.nvCashTransaction.Name = "nvCashTransaction";
            this.nvCashTransaction.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvCashTransaction_LinkClicked);
            // 
            // nvWarehouseProcesses
            // 
            this.nvWarehouseProcesses.Caption = "Anbar Əməliyyatları";
            this.nvWarehouseProcesses.ImageOptions.SmallImage = global::LecERP.Properties.Resources.rsz_whproc_24;
            this.nvWarehouseProcesses.Name = "nvWarehouseProcesses";
            this.nvWarehouseProcesses.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvWarehouseProcesses_LinkClicked);
            // 
            // nvDeclarations
            // 
            this.nvDeclarations.Caption = "Tanımlar";
            this.nvDeclarations.ImageOptions.LargeImage = global::LecERP.Properties.Resources.withtextwrapping_topcenter_16x16;
            this.nvDeclarations.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvItems),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCards),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvPrices),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCurrencyByDate)});
            this.nvDeclarations.Name = "nvDeclarations";
            // 
            // nvItems
            // 
            this.nvItems.Caption = "Məhsullar";
            this.nvItems.ImageOptions.SmallImage = global::LecERP.Properties.Resources.boproductgroup_32x32;
            this.nvItems.Name = "nvItems";
            this.nvItems.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvItems_LinkClicked);
            // 
            // nvCards
            // 
            this.nvCards.Caption = "Hesablar";
            this.nvCards.ImageOptions.SmallImage = global::LecERP.Properties.Resources.bocontact2_32x32;
            this.nvCards.Name = "nvCards";
            this.nvCards.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvCards_LinkClicked);
            // 
            // nvPrices
            // 
            this.nvPrices.Caption = "Qiymətlər";
            this.nvPrices.ImageOptions.SmallImage = global::LecERP.Properties.Resources.bosale_32x321;
            this.nvPrices.Name = "nvPrices";
            this.nvPrices.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvPrices_LinkClicked);
            // 
            // nvCurrencyByDate
            // 
            this.nvCurrencyByDate.Caption = "Günlük Məzənnə";
            this.nvCurrencyByDate.ImageOptions.SmallImage = global::LecERP.Properties.Resources.exbydate2424;
            this.nvCurrencyByDate.Name = "nvCurrencyByDate";
            this.nvCurrencyByDate.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvCurrencyByDate_LinkClicked);
            // 
            // nvReports
            // 
            this.nvReports.Caption = "Raportlar";
            this.nvReports.ImageOptions.SmallImage = global::LecERP.Properties.Resources.boreport2_16x16;
            this.nvReports.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nv_CardDebtReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nv_ItemReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvFicheReportLineView)});
            this.nvReports.Name = "nvReports";
            // 
            // nv_CardDebtReport
            // 
            this.nv_CardDebtReport.Caption = "Hesab Qalıqları";
            this.nv_CardDebtReport.ImageOptions.SmallImage = global::LecERP.Properties.Resources.solidlightbluedatabar_32x32;
            this.nv_CardDebtReport.Name = "nv_CardDebtReport";
            this.nv_CardDebtReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nv_CardDebtReport_LinkClicked);
            // 
            // nv_ItemReport
            // 
            this.nv_ItemReport.Caption = "Məhsul Qalıqları";
            this.nv_ItemReport.ImageOptions.SmallImage = global::LecERP.Properties.Resources.paste_32x32;
            this.nv_ItemReport.Name = "nv_ItemReport";
            this.nv_ItemReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nv_ItemReport_LinkClicked);
            // 
            // nvFicheReportLineView
            // 
            this.nvFicheReportLineView.Caption = "Faktura-Sətir Hesabatı";
            this.nvFicheReportLineView.ImageOptions.LargeImage = global::LecERP.Properties.Resources.clusteredbar3d_32x32;
            this.nvFicheReportLineView.ImageOptions.SmallImage = global::LecERP.Properties.Resources.clusteredbar3d_32x32;
            this.nvFicheReportLineView.Name = "nvFicheReportLineView";
            this.nvFicheReportLineView.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvFicheReportLineView_LinkClicked);
            // 
            // nvAdministration
            // 
            this.nvAdministration.Caption = "Administrasiya";
            this.nvAdministration.ImageOptions.SmallImage = global::LecERP.Properties.Resources.bouser_16x16;
            this.nvAdministration.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvUsers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvSettings),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvWorkStateView)});
            this.nvAdministration.Name = "nvAdministration";
            // 
            // nvUsers
            // 
            this.nvUsers.Caption = "İstifadəçilər";
            this.nvUsers.ImageOptions.SmallImage = global::LecERP.Properties.Resources.bouser_32x32;
            this.nvUsers.Name = "nvUsers";
            this.nvUsers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvUsers_LinkClicked);
            // 
            // nvSettings
            // 
            this.nvSettings.Caption = "Parametrlər";
            this.nvSettings.ImageOptions.SmallImage = global::LecERP.Properties.Resources.technology_32x32;
            this.nvSettings.Name = "nvSettings";
            this.nvSettings.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvSettings_LinkClicked);
            // 
            // nvWorkStateView
            // 
            this.nvWorkStateView.Caption = "Ştat";
            this.nvWorkStateView.ImageOptions.LargeImage = global::LecERP.Properties.Resources.expandfieldpivottable_32x32;
            this.nvWorkStateView.ImageOptions.SmallImage = global::LecERP.Properties.Resources.expandfieldpivottable_32x32;
            this.nvWorkStateView.Name = "nvWorkStateView";
            this.nvWorkStateView.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvWorkStateView_LinkClicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 735);
            this.Controls.Add(this.navbarMain);
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.Text = "LecERP";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTDMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTDMain;
        private DevExpress.XtraNavBar.NavBarControl navbarMain;
        private DevExpress.XtraNavBar.NavBarGroup nvDeclarations;
        private DevExpress.XtraNavBar.NavBarItem nvItems;
        private DevExpress.XtraNavBar.NavBarItem nvCards;
        private DevExpress.XtraNavBar.NavBarGroup nvProcesses;
        private DevExpress.XtraNavBar.NavBarItem nvPrices;
        private DevExpress.XtraNavBar.NavBarItem nvFiches;
        private DevExpress.XtraNavBar.NavBarGroup nvAdministration;
        private DevExpress.XtraNavBar.NavBarItem nvUsers;
        private DevExpress.XtraNavBar.NavBarItem nvCashTransaction;
        private DevExpress.XtraNavBar.NavBarGroup nvReports;
        private DevExpress.XtraNavBar.NavBarItem nv_CardDebtReport;
        private DevExpress.XtraNavBar.NavBarItem nvSettings;
        private DevExpress.XtraNavBar.NavBarItem nv_ItemReport;
        private DevExpress.XtraNavBar.NavBarItem nvCurrencyByDate;
        private DevExpress.XtraNavBar.NavBarItem nvWarehouseProcesses;
        private DevExpress.XtraNavBar.NavBarItem nvFicheReportLineView;
        private DevExpress.XtraNavBar.NavBarItem nvWorkStateView;
    }
}

