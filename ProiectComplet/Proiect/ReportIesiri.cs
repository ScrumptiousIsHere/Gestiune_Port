using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class ReportIesiri : Form
    {
        public ReportIesiri()
        {
            InitializeComponent();
        }

        private void ReportIesiri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Iesiri1' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,
            dateTimePicker1.Value.Day);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            this.Iesiri1TableAdapter.Fill(this.DataSet1.Iesiri1, d1, d2);

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("TITLU", "Iesirile din port din perioada " + d1.ToShortDateString() +
                                                                     " - " + d2.ToShortDateString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
