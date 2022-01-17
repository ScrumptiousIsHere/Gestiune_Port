namespace Proiect
{
    partial class Meniu
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
            this.btnIesiri = new System.Windows.Forms.Button();
            this.btnNave = new System.Windows.Forms.Button();
            this.btnDane = new System.Windows.Forms.Button();
            this.btnIntrari = new System.Windows.Forms.Button();
            this.btnSituatie = new System.Windows.Forms.Button();
            this.btnOpOut = new System.Windows.Forms.Button();
            this.btnOpIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIesiri
            // 
            this.btnIesiri.Location = new System.Drawing.Point(22, 229);
            this.btnIesiri.Margin = new System.Windows.Forms.Padding(4);
            this.btnIesiri.Name = "btnIesiri";
            this.btnIesiri.Size = new System.Drawing.Size(251, 28);
            this.btnIesiri.TabIndex = 17;
            this.btnIesiri.Text = "Vizualizare/Actualizare iesiri din port";
            this.btnIesiri.UseVisualStyleBackColor = true;
            this.btnIesiri.Click += new System.EventHandler(this.btnIesiri_Click);
            // 
            // btnNave
            // 
            this.btnNave.Location = new System.Drawing.Point(22, 265);
            this.btnNave.Margin = new System.Windows.Forms.Padding(4);
            this.btnNave.Name = "btnNave";
            this.btnNave.Size = new System.Drawing.Size(212, 28);
            this.btnNave.TabIndex = 16;
            this.btnNave.Text = "Vizualizare/Actualizare Nave";
            this.btnNave.UseVisualStyleBackColor = true;
            this.btnNave.Click += new System.EventHandler(this.btnNave_Click);
            // 
            // btnDane
            // 
            this.btnDane.Location = new System.Drawing.Point(22, 301);
            this.btnDane.Margin = new System.Windows.Forms.Padding(4);
            this.btnDane.Name = "btnDane";
            this.btnDane.Size = new System.Drawing.Size(212, 28);
            this.btnDane.TabIndex = 15;
            this.btnDane.Text = "Vizualizare/Actualizare Dane";
            this.btnDane.UseVisualStyleBackColor = true;
            this.btnDane.Click += new System.EventHandler(this.btnDane_Click);
            // 
            // btnIntrari
            // 
            this.btnIntrari.Location = new System.Drawing.Point(22, 193);
            this.btnIntrari.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntrari.Name = "btnIntrari";
            this.btnIntrari.Size = new System.Drawing.Size(251, 28);
            this.btnIntrari.TabIndex = 14;
            this.btnIntrari.Text = "Vizualizare/Actualizare intrari in port";
            this.btnIntrari.UseVisualStyleBackColor = true;
            this.btnIntrari.Click += new System.EventHandler(this.btnIntrari_Click);
            // 
            // btnSituatie
            // 
            this.btnSituatie.Location = new System.Drawing.Point(635, 193);
            this.btnSituatie.Margin = new System.Windows.Forms.Padding(4);
            this.btnSituatie.Name = "btnSituatie";
            this.btnSituatie.Size = new System.Drawing.Size(131, 28);
            this.btnSituatie.TabIndex = 13;
            this.btnSituatie.Text = "Situatia Generala";
            this.btnSituatie.UseVisualStyleBackColor = true;
            this.btnSituatie.Click += new System.EventHandler(this.btnSituatie_Click);
            // 
            // btnOpOut
            // 
            this.btnOpOut.Location = new System.Drawing.Point(22, 122);
            this.btnOpOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpOut.Name = "btnOpOut";
            this.btnOpOut.Size = new System.Drawing.Size(124, 28);
            this.btnOpOut.TabIndex = 12;
            this.btnOpOut.Text = "Operatori Iesire";
            this.btnOpOut.UseVisualStyleBackColor = true;
            this.btnOpOut.Click += new System.EventHandler(this.btnOpOut_Click);
            // 
            // btnOpIn
            // 
            this.btnOpIn.Location = new System.Drawing.Point(22, 158);
            this.btnOpIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpIn.Name = "btnOpIn";
            this.btnOpIn.Size = new System.Drawing.Size(124, 28);
            this.btnOpIn.TabIndex = 11;
            this.btnOpIn.Text = "Operatori Intrare";
            this.btnOpIn.UseVisualStyleBackColor = true;
            this.btnOpIn.Click += new System.EventHandler(this.btnOpIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Proiect realizat de Ionescu Gruia-Andrei si Gilea Stefan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aplicatie pentru gestiunea navelor intr-un port";
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnIesiri);
            this.Controls.Add(this.btnNave);
            this.Controls.Add(this.btnDane);
            this.Controls.Add(this.btnIntrari);
            this.Controls.Add(this.btnSituatie);
            this.Controls.Add(this.btnOpOut);
            this.Controls.Add(this.btnOpIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIesiri;
        private System.Windows.Forms.Button btnNave;
        private System.Windows.Forms.Button btnDane;
        private System.Windows.Forms.Button btnIntrari;
        private System.Windows.Forms.Button btnSituatie;
        private System.Windows.Forms.Button btnOpOut;
        private System.Windows.Forms.Button btnOpIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}