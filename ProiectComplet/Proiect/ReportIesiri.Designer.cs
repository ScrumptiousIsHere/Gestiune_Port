namespace Proiect
{
    partial class ReportIesiri
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new Proiect.DataSet1();
            this.Iesiri1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Iesiri1TableAdapter = new Proiect.DataSet1TableAdapters.Iesiri1TableAdapter();
            this.btnReport = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSfarsit = new System.Windows.Forms.Label();
            this.lblInceput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iesiri1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Iesiri1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect.ReportIesiri.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(61, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(901, 356);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Iesiri1BindingSource
            // 
            this.Iesiri1BindingSource.DataMember = "Iesiri1";
            this.Iesiri1BindingSource.DataSource = this.DataSet1;
            // 
            // Iesiri1TableAdapter
            // 
            this.Iesiri1TableAdapter.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(671, 39);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(132, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Generare raport";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(473, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblSfarsit
            // 
            this.lblSfarsit.AutoSize = true;
            this.lblSfarsit.Location = new System.Drawing.Point(387, 39);
            this.lblSfarsit.Name = "lblSfarsit";
            this.lblSfarsit.Size = new System.Drawing.Size(80, 17);
            this.lblSfarsit.TabIndex = 7;
            this.lblSfarsit.Text = "Data sfarsit";
            // 
            // lblInceput
            // 
            this.lblInceput.AutoSize = true;
            this.lblInceput.Location = new System.Drawing.Point(118, 39);
            this.lblInceput.Name = "lblInceput";
            this.lblInceput.Size = new System.Drawing.Size(88, 17);
            this.lblInceput.TabIndex = 6;
            this.lblInceput.Text = "Data inceput";
            // 
            // ReportIesiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSfarsit);
            this.Controls.Add(this.lblInceput);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportIesiri";
            this.Text = "ReportIesiri";
            this.Load += new System.EventHandler(this.ReportIesiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iesiri1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Iesiri1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Iesiri1TableAdapter Iesiri1TableAdapter;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSfarsit;
        private System.Windows.Forms.Label lblInceput;
    }
}