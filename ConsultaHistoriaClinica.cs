using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AppControlClinica
{
    public partial class ConsultaHistoriaClinica : Form
    {
        private OleDbConnection ConexionBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet dsConsulta;
        private DataSet Datos;
        public ConsultaHistoriaClinica(OleDbConnection ConexionBDAux)
        {
            InitializeComponent();
            ConexionBD = ConexionBDAux;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }
        private void RecuperarCodigoPaciente()
        {
            ConsultaPacientes oForma = new ConsultaPacientes(ConexionBD);
            if (oForma.ShowDialog() == DialogResult.OK)
                tbCodigoPaciente.Text = oForma.RecuperarCodigo();
        }
        private void ProcesarConsulta()
        {
            //Generar Select
            String TextoSQL = "Select P.NroRecibo, A.IdMedico, P.Especialidad, P.FechaPago, A.Diagnostico" +
                              " from  taAtencion A, taPagoAtencion P" +
                              " where (A.NroRecibo = P.NroRecibo)" + " and " +
                              "(P.IdPaciente = '" + tbCodigoPaciente.Text + "')";
            DataAdapterBD.SelectCommand = new OleDbCommand(TextoSQL, ConexionBD);
            dsConsulta.Clear();
            DataAdapterBD.Fill(dsConsulta);
            dgvFichaConsultas.DataSource = dsConsulta;
            dgvFichaConsultas.DataMember = "Table";
        }
        private bool ExisteClave()
        {
            //----generar sentencia SELECT
            String TextoSQL = "Select * " + " from taPaciente " + " where IdPaciente = '" +
                              tbCodigoPaciente.Text + "'";
            //--asigna al DataAdapter
            DataAdapterBD.SelectCommand = new OleDbCommand(TextoSQL, ConexionBD);
            //-----recupera los datos en el dataset
            Datos = new DataSet();
            DataAdapterBD.Fill(Datos);
            //----los datos se llenan en el dataset a aDatos
            return (Datos.Tables[0].Rows.Count > 0);
        }

        private void RecuperarRegistro()
        {
            //-----recuperar atributos
            tbCodigoPaciente.Text = Datos.Tables[0].Rows[0]["IdPaciente"].ToString();
            tbAP.Text = Datos.Tables[0].Rows[0]["AP"].ToString();
            tbAM.Text = Datos.Tables[0].Rows[0]["AM"].ToString();
            tbNombres.Text = Datos.Tables[0].Rows[0]["Nombres"].ToString();
            tbDireccion.Text = Datos.Tables[0].Rows[0]["Direccion"].ToString();
            tbDNI.Text = Datos.Tables[0].Rows[0]["DNI"].ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RecuperarRegistro();
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultaCodigo_Click(object sender, EventArgs e)
        {
            RecuperarCodigoPaciente();
            if (tbCodigoPaciente.Text == "")
                tbCodigoPaciente.Focus();
            else
                if (ExisteClave())
                RecuperarRegistro();
            ProcesarConsulta();
        }

        private void tbCodigoPaciente_Leave(object sender, EventArgs e)
        {
            if (!buSalir.Focused)
            {
                if (tbCodigoPaciente.Text.CompareTo("") == 0)
                    tbCodigoPaciente.Focus();
                else
                    if (ExisteClave())
                    RecuperarRegistro();
            }
        }
    }
}
