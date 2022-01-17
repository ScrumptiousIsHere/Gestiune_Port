namespace Proiect
{
    partial class Dane
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
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.txtCapacitate = new System.Windows.Forms.TextBox();
            this.txtTipDana = new System.Windows.Forms.TextBox();
            this.txtIdDana = new System.Windows.Forms.TextBox();
            this.lblCapacitate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdDana = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Proiect.DataSet1();
            this.daneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daneTableAdapter = new Proiect.DataSet1TableAdapters.DaneTableAdapter();
            this.idDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dane1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dane1TableAdapter = new Proiect.DataSet1TableAdapters.Dane1TableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dane1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(658, 28);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(100, 28);
            this.btnRenuntare.TabIndex = 10;
            this.btnRenuntare.Text = "Renunta";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(531, 28);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmare.TabIndex = 9;
            this.btnConfirmare.Text = "Confirma";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(253, 28);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(100, 28);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(144, 28);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(100, 28);
            this.btnModificare.TabIndex = 7;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(34, 28);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(100, 28);
            this.btnActualizare.TabIndex = 6;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // txtCapacitate
            // 
            this.txtCapacitate.Location = new System.Drawing.Point(610, 285);
            this.txtCapacitate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacitate.Name = "txtCapacitate";
            this.txtCapacitate.Size = new System.Drawing.Size(132, 22);
            this.txtCapacitate.TabIndex = 18;
            // 
            // txtTipDana
            // 
            this.txtTipDana.Location = new System.Drawing.Point(610, 201);
            this.txtTipDana.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipDana.Name = "txtTipDana";
            this.txtTipDana.Size = new System.Drawing.Size(132, 22);
            this.txtTipDana.TabIndex = 17;
            // 
            // txtIdDana
            // 
            this.txtIdDana.Location = new System.Drawing.Point(610, 122);
            this.txtIdDana.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDana.Name = "txtIdDana";
            this.txtIdDana.ReadOnly = true;
            this.txtIdDana.Size = new System.Drawing.Size(132, 22);
            this.txtIdDana.TabIndex = 16;
            // 
            // lblCapacitate
            // 
            this.lblCapacitate.AutoSize = true;
            this.lblCapacitate.Location = new System.Drawing.Point(514, 288);
            this.lblCapacitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacitate.Name = "lblCapacitate";
            this.lblCapacitate.Size = new System.Drawing.Size(75, 17);
            this.lblCapacitate.TabIndex = 15;
            this.lblCapacitate.Text = "Capacitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "TipDana";
            // 
            // lblIdDana
            // 
            this.lblIdDana.AutoSize = true;
            this.lblIdDana.Location = new System.Drawing.Point(514, 125);
            this.lblIdDana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDana.Name = "lblIdDana";
            this.lblIdDana.Size = new System.Drawing.Size(53, 17);
            this.lblIdDana.TabIndex = 13;
            this.lblIdDana.Text = "IdDana";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDanaDataGridViewTextBoxColumn,
            this.tipDanaDataGridViewTextBoxColumn,
            this.capacitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dane1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 255);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daneBindingSource
            // 
            this.daneBindingSource.DataMember = "Dane";
            this.daneBindingSource.DataSource = this.dataSet1;
            // 
            // daneTableAdapter
            // 
            this.daneTableAdapter.ClearBeforeFill = true;
            // 
            // idDanaDataGridViewTextBoxColumn
            // 
            this.idDanaDataGridViewTextBoxColumn.DataPropertyName = "IdDana";
            this.idDanaDataGridViewTextBoxColumn.HeaderText = "IdDana";
            this.idDanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDanaDataGridViewTextBoxColumn.Name = "idDanaDataGridViewTextBoxColumn";
            this.idDanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipDanaDataGridViewTextBoxColumn
            // 
            this.tipDanaDataGridViewTextBoxColumn.DataPropertyName = "TipDana";
            this.tipDanaDataGridViewTextBoxColumn.HeaderText = "TipDana";
            this.tipDanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipDanaDataGridViewTextBoxColumn.Name = "tipDanaDataGridViewTextBoxColumn";
            this.tipDanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacitateDataGridViewTextBoxColumn
            // 
            this.capacitateDataGridViewTextBoxColumn.DataPropertyName = "Capacitate";
            this.capacitateDataGridViewTextBoxColumn.HeaderText = "Capacitate";
            this.capacitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacitateDataGridViewTextBoxColumn.Name = "capacitateDataGridViewTextBoxColumn";
            this.capacitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dane1BindingSource
            // 
            this.dane1BindingSource.DataMember = "Dane1";
            this.dane1BindingSource.DataSource = this.dataSet1;
            // 
            // dane1TableAdapter
            // 
            this.dane1TableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(637, 74);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(41, 17);
            this.lblOp.TabIndex = 20;
            this.lblOp.Text = "lblOp";
            // 
            // Dane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCapacitate);
            this.Controls.Add(this.txtTipDana);
            this.Controls.Add(this.txtIdDana);
            this.Controls.Add(this.lblCapacitate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdDana);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "Dane";
            this.Text = "Dane";
            this.Load += new System.EventHandler(this.Dane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dane1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.TextBox txtCapacitate;
        private System.Windows.Forms.TextBox txtTipDana;
        private System.Windows.Forms.TextBox txtIdDana;
        private System.Windows.Forms.Label lblCapacitate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdDana;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource daneBindingSource;
        private DataSet1TableAdapters.DaneTableAdapter daneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dane1BindingSource;
        private DataSet1TableAdapters.Dane1TableAdapter dane1TableAdapter;
        private System.Windows.Forms.Label lblOp;
    }
}