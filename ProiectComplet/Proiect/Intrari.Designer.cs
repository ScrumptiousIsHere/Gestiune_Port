namespace Proiect
{
    partial class Intrari
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
            this.lblOp = new System.Windows.Forms.Label();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.cmbDNava = new System.Windows.Forms.ComboBox();
            this.naveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.txtIdDana = new System.Windows.Forms.TextBox();
            this.txtIdIntrare = new System.Windows.Forms.TextBox();
            this.lblDNava = new System.Windows.Forms.Label();
            this.lblIdDana = new System.Windows.Forms.Label();
            this.lblIdIntrare = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idIntrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIntrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOpInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrariTableAdapter = new Proiect.DataSet1TableAdapters.IntrariTableAdapter();
            this.naveTableAdapter = new Proiect.DataSet1TableAdapters.NaveTableAdapter();
            this.cmbOpIn = new System.Windows.Forms.ComboBox();
            this.operatorIntrareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOpIn = new System.Windows.Forms.Label();
            this.operatorIntrareTableAdapter = new Proiect.DataSet1TableAdapters.OperatorIntrareTableAdapter();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.naveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIntrareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(486, 217);
            this.lblOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 17);
            this.lblOp.TabIndex = 20;
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(891, 101);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(100, 28);
            this.btnRenuntare.TabIndex = 19;
            this.btnRenuntare.Text = "Renunta";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(770, 101);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmare.TabIndex = 18;
            this.btnConfirmare.Text = "Confirma";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(34, 41);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(100, 28);
            this.btnActualizare.TabIndex = 16;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // cmbDNava
            // 
            this.cmbDNava.DataSource = this.naveBindingSource;
            this.cmbDNava.DisplayMember = "DNava";
            this.cmbDNava.FormattingEnabled = true;
            this.cmbDNava.Location = new System.Drawing.Point(838, 246);
            this.cmbDNava.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDNava.Name = "cmbDNava";
            this.cmbDNava.Size = new System.Drawing.Size(132, 24);
            this.cmbDNava.TabIndex = 28;
            this.cmbDNava.ValueMember = "IdNava";
            // 
            // naveBindingSource
            // 
            this.naveBindingSource.DataMember = "Nave";
            this.naveBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdDana
            // 
            this.txtIdDana.Location = new System.Drawing.Point(838, 203);
            this.txtIdDana.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDana.Name = "txtIdDana";
            this.txtIdDana.Size = new System.Drawing.Size(132, 22);
            this.txtIdDana.TabIndex = 26;
            this.txtIdDana.Leave += new System.EventHandler(this.txtIdDana_Leave);
            // 
            // txtIdIntrare
            // 
            this.txtIdIntrare.Enabled = false;
            this.txtIdIntrare.Location = new System.Drawing.Point(838, 154);
            this.txtIdIntrare.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdIntrare.Name = "txtIdIntrare";
            this.txtIdIntrare.Size = new System.Drawing.Size(132, 22);
            this.txtIdIntrare.TabIndex = 25;
            // 
            // lblDNava
            // 
            this.lblDNava.AutoSize = true;
            this.lblDNava.Location = new System.Drawing.Point(716, 246);
            this.lblDNava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNava.Name = "lblDNava";
            this.lblDNava.Size = new System.Drawing.Size(102, 17);
            this.lblDNava.TabIndex = 23;
            this.lblDNava.Text = "DenumireNava";
            // 
            // lblIdDana
            // 
            this.lblIdDana.AutoSize = true;
            this.lblIdDana.Location = new System.Drawing.Point(767, 203);
            this.lblIdDana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDana.Name = "lblIdDana";
            this.lblIdDana.Size = new System.Drawing.Size(53, 17);
            this.lblIdDana.TabIndex = 22;
            this.lblIdDana.Text = "IdDana";
            // 
            // lblIdIntrare
            // 
            this.lblIdIntrare.AutoSize = true;
            this.lblIdIntrare.Location = new System.Drawing.Point(758, 154);
            this.lblIdIntrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdIntrare.Name = "lblIdIntrare";
            this.lblIdIntrare.Size = new System.Drawing.Size(60, 17);
            this.lblIdIntrare.TabIndex = 21;
            this.lblIdIntrare.Text = "IdIntrare";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIntrareDataGridViewTextBoxColumn,
            this.idDanaDataGridViewTextBoxColumn,
            this.dataIntrareDataGridViewTextBoxColumn,
            this.idOpInDataGridViewTextBoxColumn,
            this.dNavaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.intrariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 301);
            this.dataGridView1.TabIndex = 29;
            // 
            // idIntrareDataGridViewTextBoxColumn
            // 
            this.idIntrareDataGridViewTextBoxColumn.DataPropertyName = "IdIntrare";
            this.idIntrareDataGridViewTextBoxColumn.HeaderText = "IdIntrare";
            this.idIntrareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idIntrareDataGridViewTextBoxColumn.Name = "idIntrareDataGridViewTextBoxColumn";
            this.idIntrareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idIntrareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDanaDataGridViewTextBoxColumn
            // 
            this.idDanaDataGridViewTextBoxColumn.DataPropertyName = "IdDana";
            this.idDanaDataGridViewTextBoxColumn.HeaderText = "IdDana";
            this.idDanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDanaDataGridViewTextBoxColumn.Name = "idDanaDataGridViewTextBoxColumn";
            this.idDanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataIntrareDataGridViewTextBoxColumn
            // 
            this.dataIntrareDataGridViewTextBoxColumn.DataPropertyName = "DataIntrare";
            this.dataIntrareDataGridViewTextBoxColumn.HeaderText = "DataIntrare";
            this.dataIntrareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataIntrareDataGridViewTextBoxColumn.Name = "dataIntrareDataGridViewTextBoxColumn";
            this.dataIntrareDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataIntrareDataGridViewTextBoxColumn.Width = 125;
            // 
            // idOpInDataGridViewTextBoxColumn
            // 
            this.idOpInDataGridViewTextBoxColumn.DataPropertyName = "IdOpIn";
            this.idOpInDataGridViewTextBoxColumn.HeaderText = "IdOpIn";
            this.idOpInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOpInDataGridViewTextBoxColumn.Name = "idOpInDataGridViewTextBoxColumn";
            this.idOpInDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOpInDataGridViewTextBoxColumn.Visible = false;
            this.idOpInDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNavaDataGridViewTextBoxColumn
            // 
            this.dNavaDataGridViewTextBoxColumn.DataPropertyName = "DNava";
            this.dNavaDataGridViewTextBoxColumn.HeaderText = "DNava";
            this.dNavaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNavaDataGridViewTextBoxColumn.Name = "dNavaDataGridViewTextBoxColumn";
            this.dNavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dNavaDataGridViewTextBoxColumn.Width = 125;
            // 
            // intrariBindingSource
            // 
            this.intrariBindingSource.DataMember = "Intrari";
            this.intrariBindingSource.DataSource = this.dataSet1;
            // 
            // intrariTableAdapter
            // 
            this.intrariTableAdapter.ClearBeforeFill = true;
            // 
            // naveTableAdapter
            // 
            this.naveTableAdapter.ClearBeforeFill = true;
            // 
            // cmbOpIn
            // 
            this.cmbOpIn.DataSource = this.operatorIntrareBindingSource;
            this.cmbOpIn.DisplayMember = "DOpIn";
            this.cmbOpIn.FormattingEnabled = true;
            this.cmbOpIn.Location = new System.Drawing.Point(837, 301);
            this.cmbOpIn.Name = "cmbOpIn";
            this.cmbOpIn.Size = new System.Drawing.Size(132, 24);
            this.cmbOpIn.TabIndex = 30;
            this.cmbOpIn.ValueMember = "IdOpIn";
            // 
            // operatorIntrareBindingSource
            // 
            this.operatorIntrareBindingSource.DataMember = "OperatorIntrare";
            this.operatorIntrareBindingSource.DataSource = this.dataSet1;
            // 
            // lblOpIn
            // 
            this.lblOpIn.AutoSize = true;
            this.lblOpIn.Location = new System.Drawing.Point(716, 301);
            this.lblOpIn.Name = "lblOpIn";
            this.lblOpIn.Size = new System.Drawing.Size(110, 17);
            this.lblOpIn.TabIndex = 31;
            this.lblOpIn.Text = "Operator Intrare";
            // 
            // operatorIntrareTableAdapter
            // 
            this.operatorIntrareTableAdapter.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(141, 41);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 28);
            this.btnReport.TabIndex = 32;
            this.btnReport.Text = "Raport intrari";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Intrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblOpIn);
            this.Controls.Add(this.cmbOpIn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbDNava);
            this.Controls.Add(this.txtIdDana);
            this.Controls.Add(this.txtIdIntrare);
            this.Controls.Add(this.lblDNava);
            this.Controls.Add(this.lblIdDana);
            this.Controls.Add(this.lblIdIntrare);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "Intrari";
            this.Text = "Intrare";
            this.Load += new System.EventHandler(this.Intrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.naveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIntrareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.ComboBox cmbDNava;
        private System.Windows.Forms.TextBox txtIdDana;
        private System.Windows.Forms.TextBox txtIdIntrare;
        private System.Windows.Forms.Label lblDNava;
        private System.Windows.Forms.Label lblIdDana;
        private System.Windows.Forms.Label lblIdIntrare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource intrariBindingSource;
        private DataSet1TableAdapters.IntrariTableAdapter intrariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIntrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIntrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOpInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource naveBindingSource;
        private DataSet1TableAdapters.NaveTableAdapter naveTableAdapter;
        private System.Windows.Forms.ComboBox cmbOpIn;
        private System.Windows.Forms.Label lblOpIn;
        private System.Windows.Forms.BindingSource operatorIntrareBindingSource;
        private DataSet1TableAdapters.OperatorIntrareTableAdapter operatorIntrareTableAdapter;
        private System.Windows.Forms.Button btnReport;
    }
}