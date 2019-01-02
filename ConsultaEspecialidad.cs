using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AppControlClinica
{
    public partial class ConsultaEspecialidad : Form
    {
        private OleDbConnection ConexionBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet dsConsulta;
        public ConsultaEspecialidad(OleDbConnection ConexionBDAux)
        {
            InitializeComponent();
            //inicializar componentes de acceso a la base de datos
            ConexionBD = ConexionBDAux;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }
        
        
        private void ProcesarConsulta()
        {
            string textoSQL = "Select * " + " from taEspecialidad ";
            DataAdapterBD.SelectCommand = new OleDbCommand(textoSQL, ConexionBD);
            dsConsulta.Clear();
            DataAdapterBD.Fill(dsConsulta);
            //enlazar al data grid
            dgvConsultaEsp.DataSource = dsConsulta;
            dgvConsultaEsp.DataMember = "Table";
        }
        public string RecuperarCodigo()
        {
            return dgvConsultaEsp.CurrentRow.Cells[0].Value.ToString();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvConsultaEsp_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ConsultaEspecialidad_Shown(object sender, EventArgs e)
        {
            ProcesarConsulta();
        }
    }
}
