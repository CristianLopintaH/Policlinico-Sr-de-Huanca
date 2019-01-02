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
    public partial class fmEspecialidades : Form
    {
        private OleDbConnection ConexionBD;
        private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet Datos;
        private DataSet dsConsulta;        
        public fmEspecialidades(OleDbConnection ConexionBDAux)
        {
            InitializeComponent();
            //inicializar componentes de acceso a la base de datos
            ConexionBD = ConexionBDAux;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }
        private void InicializarRegistro()
        {
            //----inicializar atributos
            tbCodEspecialidad.Text = "";
            tbNombreEsp.Text = "";
            tbCost.Text = "";
            tbCodEspecialidad.Focus();
        }

        private bool ExisteClave()
        {
            //----generar sentencia SELECT
            String TextoSQL = "Select * " +
                    " from taEspecialidad " +
                    " where IdEspecialidad = '" + tbCodEspecialidad.Text + "'";
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
            tbCodEspecialidad.Text = Datos.Tables[0].Rows[0]["IdEspecialidad"].ToString();
            tbNombreEsp.Text = Datos.Tables[0].Rows[0]["NombreEsp"].ToString();
            tbCost.Text = Datos.Tables[0].Rows[0]["Costo"].ToString();
        }

        private void InsertarRegistro()
        {
            //--Crear Sentencia Insert
            String TextoSQL = "INSERT INTO taEspecialidad " +
                " VALUES ('" + tbCodEspecialidad.Text + "'," +
                "'" + tbNombreEsp.Text + "'," +                
                "'" + tbCost.Text + "')";
            //--Crear Comando SQL
            ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
            //--Ejecutar Comando
            ComandoBD.ExecuteNonQuery();
        }
        
        private void ActualizarRegistro()
        {
            //--Crear Sentencia Insert
            String TextoSQL = "UPDATE taEspecialidad " +
                " set " +
                "IdEspecialidad = '" + tbCodEspecialidad.Text + "', " +
                "NombreEsp = '" + tbNombreEsp.Text + "' " +
                "CostoAtencion = '" + tbCost.Text + "' " +                
                "where IdEspecialidad = '" + tbCodEspecialidad.Text + "'";
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

        private void tbCodEspecialidad_Leave(object sender, EventArgs e)
        {
            if (!bSalir.Focused)
            {
                if (tbCodEspecialidad.Text.CompareTo("") == 0)
                    tbCodEspecialidad.Focus();
                else
                    if (ExisteClave())
                    RecuperarRegistro();
            }
        }

        private void buConsulta_Click(object sender, EventArgs e)
        {
            ConsultaEspecialidad ofmComCar = new ConsultaEspecialidad(ConexionBD);
            if (ofmComCar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbCodEspecialidad.Text = ofmComCar.RecuperarCodigo();
            tbCodEspecialidad.Focus();
        }
    }
}
