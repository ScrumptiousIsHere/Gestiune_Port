namespace Proiect
{
    partial class ReportIntrari
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
            this.Intrari1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Proiect.DataSet1();
            this.Intrari1TableAdapter = new Proiect.DataSet1TableAdapters.Intrari1TableAdapter();
            this.lblInceput = new System.Windows.Forms.Label();
            this.lblSfarsit = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Intrari1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Intrari1BindingSource
            // 
            this.Intrari1BindingSource.DataMember = "Intrari1";
            this.Intrari1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Intrari1TableAdapter
            // 
            this.Intrari1TableAdapter.ClearBeforeFill = true;
            // 
            // lblInceput
            // 
            this.lblInceput.AutoSize = true;
            this.lblInceput.Location = new System.Drawing.Point(104, 24);
            this.lblInceput.Name = "lblInceput";
            this.lblInceput.Size = new System.Drawing.Size(88, 17);
            this.lblInceput.TabIndex = 1;
            this.lblInceput.Text = "Data inceput";
            // 
            // lblSfarsit
            // 
            this.lblSfarsit.AutoSize = true;
            this.lblSfarsit.Location = new System.Drawing.Point(373, 24);
            this.lblSfarsit.Name = "lblSfarsit";
            this.lblSfarsit.Size = new System.Drawing.Size(80, 17);
            this.lblSfarsit.TabIndex = 2;
            this.lblSfarsit.Text = "Data sfarsit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(459, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(657, 24);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(132, 23);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Generare raport";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Intrari1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect.ReportIntrari.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(769, 307);
            this.reportViewer1.TabIndex = 6;
            // 
            // ReportIntrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSfarsit);
            this.Controls.Add(this.lblInceput);
            this.Name = "ReportIntrari";
            this.Text = "ReportIntrari";
            this.Load += new System.EventHandler(this.ReportIntrari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Intrari1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource Intrari1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Intrari1TableAdapter Intrari1TableAdapter;
        private System.Windows.Forms.Label lblInceput;
        private System.Windows.Forms.Label lblSfarsit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}