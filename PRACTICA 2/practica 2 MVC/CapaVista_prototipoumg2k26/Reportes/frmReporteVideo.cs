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
using CapaControlador_prototipoumg2k26;

namespace CapaVista_prototipoumg2k26.Reportes
{
    public partial class frmReporteVideo : Form
    {
        private ModeloVideo video = new ModeloVideo();
        public frmReporteVideo()
        {
            InitializeComponent();
        }

        private void frmReporteVideo_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSourse = new ReportDataSource("DataSet1", video.GetAll());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_prototipoumg2k26.Reportes.ReporteVideo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSourse);

            this.reportViewer1.RefreshReport();
            

        }
    }
}
