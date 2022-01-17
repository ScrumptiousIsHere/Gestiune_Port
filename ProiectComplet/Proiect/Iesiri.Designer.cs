namespace Proiect
{
    partial class Iesiri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idIesireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIesireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOpOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iesiriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNava = new System.Windows.Forms.Label();
            this.lblDana = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDane = new System.Windows.Forms.TextBox();
            this.cmbNave = new System.Windows.Forms.ComboBox();
            this.naveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblOp = new System.Windows.Forms.Label();
            this.iesiriTableAdapter = new Proiect.DataSet1TableAdapters.IesiriTableAdapter();
            this.naveTableAdapter = new Proiect.DataSet1TableAdapters.NaveTableAdapter();
            this.cmbOpOut = new System.Windows.Forms.ComboBox();
            this.operatorIesireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOpOut = new System.Windows.Forms.Label();
            this.operatorIesireTableAdapter = new Proiect.DataSet1TableAdapters.OperatorIesireTableAdapter();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iesiriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIesireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIesireDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.idDanaDataGridViewTextBoxColumn,
            this.dataIesireDataGridViewTextBoxColumn,
            this.idOpOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iesiriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // idIesireDataGridViewTextBoxColumn
            // 
            this.idIesireDataGridViewTextBoxColumn.DataPropertyName = "IdIesire";
            this.idIesireDataGridViewTextBoxColumn.HeaderText = "IdIesire";
            this.idIesireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idIesireDataGridViewTextBoxColumn.Name = "idIesireDataGridViewTextBoxColumn";
            this.idIesireDataGridViewTextBoxColumn.ReadOnly = true;
            this.idIesireDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DNava";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNava";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            // dataIesireDataGridViewTextBoxColumn
            // 
            this.dataIesireDataGridViewTextBoxColumn.DataPropertyName = "DataIesire";
            this.dataIesireDataGridViewTextBoxColumn.HeaderText = "DataIesire";
            this.dataIesireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataIesireDataGridViewTextBoxColumn.Name = "dataIesireDataGridViewTextBoxColumn";
            this.dataIesireDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataIesireDataGridViewTextBoxColumn.Width = 125;
            // 
            // idOpOutDataGridViewTextBoxColumn
            // 
            this.idOpOutDataGridViewTextBoxColumn.DataPropertyName = "IdOpOut";
            this.idOpOutDataGridViewTextBoxColumn.HeaderText = "IdOpOut";
            this.idOpOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOpOutDataGridViewTextBoxColumn.Name = "idOpOutDataGridViewTextBoxColumn";
            this.idOpOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOpOutDataGridViewTextBoxColumn.Visible = false;
            this.idOpOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // iesiriBindingSource
            // 
            this.iesiriBindingSource.DataMember = "Iesiri";
            this.iesiriBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(12, 39);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(88, 39);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(809, 39);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(86, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.BtnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(914, 39);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(86, 23);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Anulare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(777, 300);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblNava
            // 
            this.lblNava.AutoSize = true;
            this.lblNava.Location = new System.Drawing.Point(760, 117);
            this.lblNava.Name = "lblNava";
            this.lblNava.Size = new System.Drawing.Size(41, 17);
            this.lblNava.TabIndex = 7;
            this.lblNava.Text = "Nava";
            // 
            // lblDana
            // 
            this.lblDana.AutoSize = true;
            this.lblDana.Location = new System.Drawing.Point(742, 165);
            this.lblDana.Name = "lblDana";
            this.lblDana.Size = new System.Drawing.Size(59, 17);
            this.lblDana.TabIndex = 8;
            this.lblDana.Text = "ID Dana";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(760, 260);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 17);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(869, 297);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 22);
            this.txtID.TabIndex = 10;
            // 
            // txtDane
            // 
            this.txtDane.Location = new System.Drawing.Point(869, 165);
            this.txtDane.Name = "txtDane";
            this.txtDane.Size = new System.Drawing.Size(121, 22);
            this.txtDane.TabIndex = 11;
            this.txtDane.TextChanged += new System.EventHandler(this.txtDane_TextChanged);
            // 
            // cmbNave
            // 
            this.cmbNave.DataSource = this.naveBindingSource;
            this.cmbNave.DisplayMember = "DNava";
            this.cmbNave.FormattingEnabled = true;
            this.cmbNave.Location = new System.Drawing.Point(869, 117);
            this.cmbNave.Name = "cmbNave";
            this.cmbNave.Size = new System.Drawing.Size(121, 24);
            this.cmbNave.TabIndex = 12;
            this.cmbNave.ValueMember = "IdNava";
            this.cmbNave.SelectedIndexChanged += new System.EventHandler(this.cmbNave_SelectedIndexChanged);
            // 
            // naveBindingSource
            // 
            this.naveBindingSource.DataMember = "Nave";
            this.naveBindingSource.DataSource = this.dataSet1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(869, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(890, 76);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(41, 17);
            this.lblOp.TabIndex = 14;
            this.lblOp.Text = "lblOp";
            // 
            // iesiriTableAdapter
            // 
            this.iesiriTableAdapter.ClearBeforeFill = true;
            // 
            // naveTableAdapter
            // 
            this.naveTableAdapter.ClearBeforeFill = true;
            // 
            // cmbOpOut
            // 
            this.cmbOpOut.DataSource = this.operatorIesireBindingSource;
            this.cmbOpOut.DisplayMember = "DOpOut";
            this.cmbOpOut.FormattingEnabled = true;
            this.cmbOpOut.Location = new System.Drawing.Point(869, 209);
            this.cmbOpOut.Name = "cmbOpOut";
            this.cmbOpOut.Size = new System.Drawing.Size(121, 24);
            this.cmbOpOut.TabIndex = 15;
            this.cmbOpOut.ValueMember = "IdOpOut";
            // 
            // operatorIesireBindingSource
            // 
            this.operatorIesireBindingSource.DataMember = "OperatorIesire";
            this.operatorIesireBindingSource.DataSource = this.dataSet1;
            // 
            // lblOpOut
            // 
            this.lblOpOut.AutoSize = true;
            this.lblOpOut.Location = new System.Drawing.Point(698, 212);
            this.lblOpOut.Name = "lblOpOut";
            this.lblOpOut.Size = new System.Drawing.Size(103, 17);
            this.lblOpOut.TabIndex = 16;
            this.lblOpOut.Text = "Operator iesire";
            // 
            // operatorIesireTableAdapter
            // 
            this.operatorIesireTableAdapter.ClearBeforeFill = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(106, 39);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 39);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Report iesiri";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Iesiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblOpOut);
            this.Controls.Add(this.cmbOpOut);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbNave);
            this.Controls.Add(this.txtDane);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDana);
            this.Controls.Add(this.lblNava);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Iesiri";
            this.Text = "Iesiri";
            this.Load += new System.EventHandler(this.Iesiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iesiriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIesireBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNava;
        private System.Windows.Forms.Label lblDana;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDane;
        private System.Windows.Forms.ComboBox cmbNave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNavaDataGridViewTextBoxColumn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource iesiriBindingSource;
        private DataSet1TableAdapters.IesiriTableAdapter iesiriTableAdapter;
        private System.Windows.Forms.BindingSource naveBindingSource;
        private DataSet1TableAdapters.NaveTableAdapter naveTableAdapter;
        private System.Windows.Forms.ComboBox cmbOpOut;
        private System.Windows.Forms.Label lblOpOut;
        private System.Windows.Forms.BindingSource operatorIesireBindingSource;
        private DataSet1TableAdapters.OperatorIesireTableAdapter operatorIesireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIesireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIesireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOpOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReport;
    }
}