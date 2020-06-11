namespace WindowsFormsApp1
{
    partial class frmLTH
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.ccbtk = new System.Windows.Forms.ComboBox();
            this.CT_LICHTHUCHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataLTH = new WindowsFormsApp1.DataLTH();
            this.CT_LICHTHUCHANHTableAdapter = new WindowsFormsApp1.DataLTHTableAdapters.CT_LICHTHUCHANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CT_LICHTHUCHANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLTH)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CT_LICHTHUCHANHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportTH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(896, 368);
            this.reportViewer1.TabIndex = 0;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(139, 11);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // ccbtk
            // 
            this.ccbtk.FormattingEnabled = true;
            this.ccbtk.Location = new System.Drawing.Point(12, 13);
            this.ccbtk.Name = "ccbtk";
            this.ccbtk.Size = new System.Drawing.Size(121, 21);
            this.ccbtk.TabIndex = 2;
            this.ccbtk.SelectedIndexChanged += new System.EventHandler(this.ccbtk_SelectedIndexChanged);
            // 
            // CT_LICHTHUCHANHBindingSource
            // 
            this.CT_LICHTHUCHANHBindingSource.DataMember = "CT_LICHTHUCHANH";
            this.CT_LICHTHUCHANHBindingSource.DataSource = this.DataLTH;
            // 
            // DataLTH
            // 
            this.DataLTH.DataSetName = "DataLTH";
            this.DataLTH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CT_LICHTHUCHANHTableAdapter
            // 
            this.CT_LICHTHUCHANHTableAdapter.ClearBeforeFill = true;
            // 
            // frmLTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.ccbtk);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmLTH";
            this.Text = "frmLTH";
            this.Load += new System.EventHandler(this.frmLTH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CT_LICHTHUCHANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataLTH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataLTH DataLTH;
        private System.Windows.Forms.BindingSource CT_LICHTHUCHANHBindingSource;
        private DataLTHTableAdapters.CT_LICHTHUCHANHTableAdapter CT_LICHTHUCHANHTableAdapter;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox ccbtk;
    }
}