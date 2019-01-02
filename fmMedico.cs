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
    public partial class fmMedico : Form
    {
        public fmMedico(OleDbConnection ConexionBDAux)
        {
            InitializeComponent();
            //inicializar componentes de acceso a la base de datos
            ConexionBD = ConexionBDAux;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }

        private OleDbConnection ConexionBD;
        private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet Datos;
        private DataSet dsConsulta;

        private void InicializarRegistro()
        {
            //----inicializar atributos
            tbCodigoMedico.Text = "";
            tbApePate.Text = "";
            tbApeMat.Text = "";
            tbNombres.Text = "";
            tbEspecialidad.Text = "";
            //----poner el foco
            tbCodigoMedico.Focus();
        }
        private bool ExisteClave()
        {
            //----generar sentencia SELECT
            String TextoSQL = "Select * " +
                    " from taMedico " +
                    " where IdMedico = '" + tbCodigoMedico.Text + "'";
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
            //--------Recuperar atributos
            tbCodigoMedico.Text = Datos.Tables[0].Rows[0]["IdMedico"].ToString();
            tbApePate.Text = Datos.Tables[0].Rows[0]["AP"].ToString();
            tbApeMat.Text = Datos.Tables[0].Rows[0]["AM"].ToString();
            tbNombres.Text = Datos.Tables[0].Rows[0]["Nombres"].ToString();
            tbEspecialidad.Text = Datos.Tables[0].Rows[0]["IdEspecialidad"].ToString();
        }
        private void InsertarRegistro()
        {
            //--Crear Sentencia Insert
            String TextoSQL = "INSERT INTO taMedico " +
                " VALUES ('" + tbCodigoMedico.Text + "'," +
                "'" + tbApePate.Text + "'," +
                "'" + tbApeMat.Text + "'," +
                "'" + tbNombres.Text + "'," +
                "'" + tbEspecialidad.Text + "')";
            //--Crear Comando SQL
            ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
            //--Ejecutar Comando
            ComandoBD.ExecuteNonQuery();
        }
        private void ActualizarRegistro()
        {
            //--Crear Sentencia Insert
            String TextoSQL = "UPDATE taMedico " +
                " set " +
                "IdMedico = '" + tbCodigoMedico.Text + "', " +
                "AP = '" + tbApePate.Text + "' " +
                "AM = '" + tbApeMat.Text + "' " +
                "Nombres = '" + tbNombres.Text + "' " +
                "IdEspecialidad = '" + tbEspecialidad.Text + "' " +
                "where IdMedico = '" + tbCodigoMedico.Text + "'";
            //--CRear comando SQl
            ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
            //Ejecutar Comando
            ComandoBD.ExecuteNonQuery();
        }
        private void ProcesarGrabar()
        {
            //Verficar si clave existe o no en la base de datos
            if (ExisteClave())
                ActualizarRegistro();
            else
                InsertarRegistro();
            //Inicializar Registro
            InicializarRegistro();
        }
        

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bGrabar_Click(object sender, EventArgs e)
        {
            ProcesarGrabar();
        }

        private void tbCodigoMedico_Leave(object sender, EventArgs e)
        {
            if (!bSalir.Focused)
            {
                if (tbCodigoMedico.Text.CompareTo("") == 0)
                    tbCodigoMedico.Focus();
                else
                    if (ExisteClave())
                    RecuperarRegistro();
            }
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            ConsultaEspecialidad ofmComCar = new ConsultaEspecialidad(ConexionBD);
            if (ofmComCar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbEspecialidad.Text = ofmComCar.RecuperarCodigo();
            tbEspecialidad.Focus();
        }
    }
}
