namespace Proiect
{
    partial class OperatoriIesire
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
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblIdOperator = new System.Windows.Forms.Label();
            this.txtDOperator = new System.Windows.Forms.TextBox();
            this.txtIdOperator = new System.Windows.Forms.TextBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Proiect.DataSet1();
            this.operatorIesireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operatorIesireTableAdapter = new Proiect.DataSet1TableAdapters.OperatorIesireTableAdapter();
            this.dOpOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIesireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(220, 131);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(100, 28);
            this.btnRenuntare.TabIndex = 17;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(75, 131);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmare.TabIndex = 16;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(59, 99);
            this.lblDenumire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(130, 17);
            this.lblDenumire.TabIndex = 15;
            this.lblDenumire.Text = "Denumire Operator";
            // 
            // lblIdOperator
            // 
            this.lblIdOperator.AutoSize = true;
            this.lblIdOperator.Location = new System.Drawing.Point(99, 66);
            this.lblIdOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdOperator.Name = "lblIdOperator";
            this.lblIdOperator.Size = new System.Drawing.Size(76, 17);
            this.lblIdOperator.TabIndex = 14;
            this.lblIdOperator.Text = "IdOperator";
            // 
            // txtDOperator
            // 
            this.txtDOperator.Location = new System.Drawing.Point(207, 95);
            this.txtDOperator.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOperator.Name = "txtDOperator";
            this.txtDOperator.Size = new System.Drawing.Size(132, 22);
            this.txtDOperator.TabIndex = 13;
            // 
            // txtIdOperator
            // 
            this.txtIdOperator.Location = new System.Drawing.Point(207, 62);
            this.txtIdOperator.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdOperator.Name = "txtIdOperator";
            this.txtIdOperator.Size = new System.Drawing.Size(132, 22);
            this.txtIdOperator.TabIndex = 12;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(276, 25);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(100, 28);
            this.btnStergere.TabIndex = 11;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(144, 25);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(100, 28);
            this.btnModificare.TabIndex = 10;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(16, 25);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(100, 28);
            this.btnActualizare.TabIndex = 9;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dOpOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operatorIesireBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 207);
            this.dataGridView1.TabIndex = 18;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorIesireBindingSource
            // 
            this.operatorIesireBindingSource.DataMember = "OperatorIesire";
            this.operatorIesireBindingSource.DataSource = this.dataSet1;
            // 
            // operatorIesireTableAdapter
            // 
            this.operatorIesireTableAdapter.ClearBeforeFill = true;
            // 
            // dOpOutDataGridViewTextBoxColumn
            // 
            this.dOpOutDataGridViewTextBoxColumn.DataPropertyName = "DOpOut";
            this.dOpOutDataGridViewTextBoxColumn.HeaderText = "DOpOut";
            this.dOpOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOpOutDataGridViewTextBoxColumn.Name = "dOpOutDataGridViewTextBoxColumn";
            this.dOpOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOpOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(189, 172);
            this.lblOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 17);
            this.lblOp.TabIndex = 19;
            // 
            // OperatoriIesire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.lblIdOperator);
            this.Controls.Add(this.txtDOperator);
            this.Controls.Add(this.txtIdOperator);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "OperatoriIesire";
            this.Text = "OperatoriIesire";
            this.Load += new System.EventHandler(this.OperatoriIesire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIesireBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblIdOperator;
        private System.Windows.Forms.TextBox txtDOperator;
        private System.Windows.Forms.TextBox txtIdOperator;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource operatorIesireBindingSource;
        private DataSet1TableAdapters.OperatorIesireTableAdapter operatorIesireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOpOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblOp;
    }
}