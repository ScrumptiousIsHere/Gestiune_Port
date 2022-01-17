namespace Proiect
{
    partial class Nave
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
            this.dataSet1 = new Proiect.DataSet1();
            this.naveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naveTableAdapter = new Proiect.DataSet1TableAdapters.NaveTableAdapter();
            this.dNavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipNavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblCapacitate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtCapacitate = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNavaDataGridViewTextBoxColumn,
            this.tipNavaDataGridViewTextBoxColumn,
            this.capacitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.naveBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naveBindingSource
            // 
            this.naveBindingSource.DataMember = "Nave";
            this.naveBindingSource.DataSource = this.dataSet1;
            // 
            // naveTableAdapter
            // 
            this.naveTableAdapter.ClearBeforeFill = true;
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
            // tipNavaDataGridViewTextBoxColumn
            // 
            this.tipNavaDataGridViewTextBoxColumn.DataPropertyName = "TipNava";
            this.tipNavaDataGridViewTextBoxColumn.HeaderText = "TipNava";
            this.tipNavaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipNavaDataGridViewTextBoxColumn.Name = "tipNavaDataGridViewTextBoxColumn";
            this.tipNavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipNavaDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacitateDataGridViewTextBoxColumn
            // 
            this.capacitateDataGridViewTextBoxColumn.DataPropertyName = "Capacitate";
            this.capacitateDataGridViewTextBoxColumn.HeaderText = "Capacitate";
            this.capacitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacitateDataGridViewTextBoxColumn.Name = "capacitateDataGridViewTextBoxColumn";
            this.capacitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(25, 47);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(78, 55);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adaugare nava";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(140, 47);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(82, 55);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare nava";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(269, 47);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(78, 55);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Stergere nava";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(403, 47);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(78, 55);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report nave";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(644, 47);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(90, 23);
            this.btnConfirmare.TabIndex = 5;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(765, 47);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(80, 23);
            this.btnRenuntare.TabIndex = 6;
            this.btnRenuntare.Text = "Anulare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(728, 85);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(41, 17);
            this.lblOp.TabIndex = 7;
            this.lblOp.Text = "lblOp";
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(623, 147);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(69, 17);
            this.lblDenumire.TabIndex = 8;
            this.lblDenumire.Text = "Denumire";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(623, 193);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(28, 17);
            this.lblTip.TabIndex = 9;
            this.lblTip.Text = "Tip";
            // 
            // lblCapacitate
            // 
            this.lblCapacitate.AutoSize = true;
            this.lblCapacitate.Location = new System.Drawing.Point(623, 232);
            this.lblCapacitate.Name = "lblCapacitate";
            this.lblCapacitate.Size = new System.Drawing.Size(75, 17);
            this.lblCapacitate.TabIndex = 10;
            this.lblCapacitate.Text = "Capacitate";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(623, 274);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(731, 141);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 22);
            this.txtDenumire.TabIndex = 12;
            this.txtDenumire.TextChanged += new System.EventHandler(this.txtDenumire_TextChanged);
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(731, 188);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 22);
            this.txtTip.TabIndex = 13;
            // 
            // txtCapacitate
            // 
            this.txtCapacitate.Location = new System.Drawing.Point(731, 227);
            this.txtCapacitate.Name = "txtCapacitate";
            this.txtCapacitate.Size = new System.Drawing.Size(100, 22);
            this.txtCapacitate.TabIndex = 14;
            this.txtCapacitate.TextChanged += new System.EventHandler(this.txtCapacitate_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(731, 274);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 15;
            // 
            // Nave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCapacitate);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCapacitate);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Nave";
            this.Text = "Nave";
            this.Load += new System.EventHandler(this.Nave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource naveBindingSource;
        private DataSet1TableAdapters.NaveTableAdapter naveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipNavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblCapacitate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.TextBox txtCapacitate;
        private System.Windows.Forms.TextBox txtID;
    }
}