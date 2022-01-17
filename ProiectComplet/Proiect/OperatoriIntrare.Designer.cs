namespace Proiect
{
    partial class OperatoriIntrare
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
            this.lblOp = new System.Windows.Forms.Label();
            this.lblIdOperator = new System.Windows.Forms.Label();
            this.txtIdOperator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOperator = new System.Windows.Forms.TextBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Proiect.DataSet1();
            this.operatorIntrareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operatorIntrareTableAdapter = new Proiect.DataSet1TableAdapters.OperatorIntrareTableAdapter();
            this.dOpInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIntrareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(225, 146);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(100, 28);
            this.btnRenuntare.TabIndex = 20;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(54, 146);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmare.TabIndex = 19;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(157, 123);
            this.lblOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 17);
            this.lblOp.TabIndex = 18;
            // 
            // lblIdOperator
            // 
            this.lblIdOperator.AutoSize = true;
            this.lblIdOperator.Location = new System.Drawing.Point(80, 66);
            this.lblIdOperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdOperator.Name = "lblIdOperator";
            this.lblIdOperator.Size = new System.Drawing.Size(76, 17);
            this.lblIdOperator.TabIndex = 17;
            this.lblIdOperator.Text = "IdOperator";
            // 
            // txtIdOperator
            // 
            this.txtIdOperator.Location = new System.Drawing.Point(192, 62);
            this.txtIdOperator.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdOperator.Name = "txtIdOperator";
            this.txtIdOperator.Size = new System.Drawing.Size(132, 22);
            this.txtIdOperator.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Denumire operator";
            // 
            // txtDOperator
            // 
            this.txtDOperator.Location = new System.Drawing.Point(192, 94);
            this.txtDOperator.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOperator.Name = "txtDOperator";
            this.txtDOperator.Size = new System.Drawing.Size(132, 22);
            this.txtDOperator.TabIndex = 14;
            this.txtDOperator.Leave += new System.EventHandler(this.txtDOperator_Leave);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(269, 23);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(100, 28);
            this.btnStergere.TabIndex = 13;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(142, 23);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(100, 28);
            this.btnModificare.TabIndex = 12;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(13, 23);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(100, 28);
            this.btnActualizare.TabIndex = 11;
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
            this.dOpInDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operatorIntrareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(219, 193);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorIntrareBindingSource
            // 
            this.operatorIntrareBindingSource.DataMember = "OperatorIntrare";
            this.operatorIntrareBindingSource.DataSource = this.dataSet1;
            // 
            // operatorIntrareTableAdapter
            // 
            this.operatorIntrareTableAdapter.ClearBeforeFill = true;
            // 
            // dOpInDataGridViewTextBoxColumn
            // 
            this.dOpInDataGridViewTextBoxColumn.DataPropertyName = "DOpIn";
            this.dOpInDataGridViewTextBoxColumn.HeaderText = "DOpIn";
            this.dOpInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOpInDataGridViewTextBoxColumn.Name = "dOpInDataGridViewTextBoxColumn";
            this.dOpInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOpInDataGridViewTextBoxColumn.Width = 125;
            // 
            // OperatoriIntrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblIdOperator);
            this.Controls.Add(this.txtIdOperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDOperator);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "OperatoriIntrare";
            this.Text = "OperatoriIntrare";
            this.Load += new System.EventHandler(this.OperatoriIntrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorIntrareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblIdOperator;
        private System.Windows.Forms.TextBox txtIdOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDOperator;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource operatorIntrareBindingSource;
        private DataSet1TableAdapters.OperatorIntrareTableAdapter operatorIntrareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOpInDataGridViewTextBoxColumn;
    }
}