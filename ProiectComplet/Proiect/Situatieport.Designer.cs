namespace Proiect
{
    partial class Situatieport
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
            this.lblCalculSituatie = new System.Windows.Forms.Label();
            this.lblDane = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatiuneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculSituatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.calculSituatieTableAdapter = new Proiect.DataSet1TableAdapters.CalculSituatieTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDanaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locuriOcupateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locuriDaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locuriDaneTableAdapter = new Proiect.DataSet1TableAdapters.LocuriDaneTableAdapter();
            this.daneTableAdapter = new Proiect.DataSet1TableAdapters.DaneTableAdapter();
            this.txtIdDana = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculSituatieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locuriDaneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalculSituatie
            // 
            this.lblCalculSituatie.AutoSize = true;
            this.lblCalculSituatie.Location = new System.Drawing.Point(13, 24);
            this.lblCalculSituatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculSituatie.Name = "lblCalculSituatie";
            this.lblCalculSituatie.Size = new System.Drawing.Size(89, 17);
            this.lblCalculSituatie.TabIndex = 4;
            this.lblCalculSituatie.Text = "SituatieDane";
            // 
            // lblDane
            // 
            this.lblDane.AutoSize = true;
            this.lblDane.Location = new System.Drawing.Point(888, 24);
            this.lblDane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDane.Name = "lblDane";
            this.lblDane.Size = new System.Drawing.Size(42, 17);
            this.lblDane.TabIndex = 5;
            this.lblDane.Text = "Dane";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.dNavaDataGridViewTextBoxColumn,
            this.dOperatieDataGridViewTextBoxColumn,
            this.idDanaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.operatiuneDataGridViewTextBoxColumn,
            this.dOpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculSituatieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 322);
            this.dataGridView1.TabIndex = 6;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            this.idOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperatieDataGridViewTextBoxColumn.Visible = false;
            this.idOperatieDataGridViewTextBoxColumn.Width = 125;
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
            // dOperatieDataGridViewTextBoxColumn
            // 
            this.dOperatieDataGridViewTextBoxColumn.DataPropertyName = "DOperatie";
            this.dOperatieDataGridViewTextBoxColumn.HeaderText = "DOperatie";
            this.dOperatieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOperatieDataGridViewTextBoxColumn.Name = "dOperatieDataGridViewTextBoxColumn";
            this.dOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOperatieDataGridViewTextBoxColumn.Width = 125;
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
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // operatiuneDataGridViewTextBoxColumn
            // 
            this.operatiuneDataGridViewTextBoxColumn.DataPropertyName = "Operatiune";
            this.operatiuneDataGridViewTextBoxColumn.HeaderText = "Operatiune";
            this.operatiuneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operatiuneDataGridViewTextBoxColumn.Name = "operatiuneDataGridViewTextBoxColumn";
            this.operatiuneDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatiuneDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOpDataGridViewTextBoxColumn
            // 
            this.dOpDataGridViewTextBoxColumn.DataPropertyName = "DOp";
            this.dOpDataGridViewTextBoxColumn.HeaderText = "DOp";
            this.dOpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOpDataGridViewTextBoxColumn.Name = "dOpDataGridViewTextBoxColumn";
            this.dOpDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOpDataGridViewTextBoxColumn.Width = 125;
            // 
            // calculSituatieBindingSource
            // 
            this.calculSituatieBindingSource.DataMember = "CalculSituatie";
            this.calculSituatieBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculSituatieTableAdapter
            // 
            this.calculSituatieTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDanaDataGridViewTextBoxColumn1,
            this.locuriOcupateDataGridViewTextBoxColumn,
            this.tipDanaDataGridViewTextBoxColumn,
            this.capacitateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.locuriDaneBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(891, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(583, 322);
            this.dataGridView2.TabIndex = 7;
            // 
            // idDanaDataGridViewTextBoxColumn1
            // 
            this.idDanaDataGridViewTextBoxColumn1.DataPropertyName = "IdDana";
            this.idDanaDataGridViewTextBoxColumn1.HeaderText = "IdDana";
            this.idDanaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDanaDataGridViewTextBoxColumn1.Name = "idDanaDataGridViewTextBoxColumn1";
            this.idDanaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDanaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // locuriOcupateDataGridViewTextBoxColumn
            // 
            this.locuriOcupateDataGridViewTextBoxColumn.DataPropertyName = "LocuriOcupate";
            this.locuriOcupateDataGridViewTextBoxColumn.HeaderText = "LocuriOcupate";
            this.locuriOcupateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locuriOcupateDataGridViewTextBoxColumn.Name = "locuriOcupateDataGridViewTextBoxColumn";
            this.locuriOcupateDataGridViewTextBoxColumn.ReadOnly = true;
            this.locuriOcupateDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipDanaDataGridViewTextBoxColumn
            // 
            this.tipDanaDataGridViewTextBoxColumn.DataPropertyName = "TipDana";
            this.tipDanaDataGridViewTextBoxColumn.HeaderText = "TipDana";
            this.tipDanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipDanaDataGridViewTextBoxColumn.Name = "tipDanaDataGridViewTextBoxColumn";
            this.tipDanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipDanaDataGridViewTextBoxColumn.Width = 125;
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
            // locuriDaneBindingSource
            // 
            this.locuriDaneBindingSource.DataMember = "LocuriDane";
            this.locuriDaneBindingSource.DataSource = this.dataSet1;
            this.locuriDaneBindingSource.PositionChanged += new System.EventHandler(this.locuriDaneBindingSource_PositionChanged);
            // 
            // locuriDaneTableAdapter
            // 
            this.locuriDaneTableAdapter.ClearBeforeFill = true;
            // 
            // daneTableAdapter
            // 
            this.daneTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdDana
            // 
            this.txtIdDana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locuriDaneBindingSource, "IdDana", true));
            this.txtIdDana.Location = new System.Drawing.Point(650, 13);
            this.txtIdDana.Name = "txtIdDana";
            this.txtIdDana.ReadOnly = true;
            this.txtIdDana.Size = new System.Drawing.Size(100, 22);
            this.txtIdDana.TabIndex = 8;
            // 
            // Situatieport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 450);
            this.Controls.Add(this.txtIdDana);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDane);
            this.Controls.Add(this.lblCalculSituatie);
            this.Name = "Situatieport";
            this.Text = "Situatie Port";
            this.Load += new System.EventHandler(this.Situatieport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculSituatieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locuriDaneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculSituatie;
        private System.Windows.Forms.Label lblDane;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource calculSituatieBindingSource;
        private DataSet1TableAdapters.CalculSituatieTableAdapter calculSituatieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatiuneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource locuriDaneBindingSource;
        private DataSet1TableAdapters.LocuriDaneTableAdapter locuriDaneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDanaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locuriOcupateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitateDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.DaneTableAdapter daneTableAdapter;
        private System.Windows.Forms.TextBox txtIdDana;
    }
}