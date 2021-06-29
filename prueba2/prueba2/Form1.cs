using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //usamos sql client para importar los metodos que usaremos para conectar a la base de datos


namespace prueba2
{
    public partial class Form1 : Form
    {
        static string conexionstring = "server= .; database= Prueba2 ; integrated security= true"; //crearemos una variable estatica de tipo string  y le asignamos como valor los parametros para conectar en el servidor local(.) ; en la base de datos Prueba2 ; contiene los requisitos de seguridad del sistema
        SqlConnection conexion = new SqlConnection(conexionstring);


        DateTime fecha = DateTime.Today.AddDays(90);     //las variables de tipo DataTime nos serviran mas adelante para asignar las fechas , el Add toma como referencia el .Today para sumarle los dias a la fecha actual

        public Form1()
        {
            InitializeComponent();
        }

        public void consulta()
        {
            string query = "Select * from Personas";                                /*              
            SqlCommand comando = new SqlCommand(query, conexion);                                           
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("conexion a la base de datos:" + conexion.Database + "Exitosa");
            }
            catch (Exception error)
            {
                MessageBox.Show("error de conexion");


            }


            btnbuscar.Enabled = false;
          
            
        }


        private void ValidarCampoBusqueda()
        {

            var vr = !string.IsNullOrEmpty(txtbuscar.Text);/* &&
            !string.IsNullOrEmpty(txtDUI.Text);*/
            btnbuscar.Enabled = vr;
        
        }

        private void ValidarCampoRegistro()
        {



        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            if ((txtDUI.Text.Trim() == "") || (txtnombre.Text.Trim() == "") || (txtdomicilio.Text.Trim() == "") || (txtedad.Text.Trim() == "") || (cmbenfermedadescronicas.Text.Trim() == "") || (cmbgruposprioridad.Text.Trim() == ""))
            {
                MessageBox.Show("No puede quedar campos vacios");
            }
            else {

                DateTime fecha = DateTime.Today.AddDays(30);
                
                txtfecha.Text = fecha.ToShortDateString();


                DateTime fechaDos = DateTime.Today.AddDays(90);

                txtfechaDos.Text = fechaDos.ToShortDateString();


                string cadena = "Insert into personas ([DUI] , [Nombre] , [Direccion] , [EnfermedadCronica] , [GrupoDePrioridad],[Edad],[TurnoVacuna],[TurnoVacuna2]) " +
                "values ('" + txtDUI.Text + "','" + txtnombre.Text + "','" + txtdomicilio.Text + "','" + cmbenfermedadescronicas.Text + "','" + cmbgruposprioridad.Text + "','" + txtedad.Text + "','"+txtfecha.Text.Trim()+"','"+txtfechaDos.Text.Trim()+"')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                MessageBox.Show("la persona:" + txtnombre.Text + "se ha agregado correctamente");


                txtDUI.Text = "";
                txtdomicilio.Text = "";
                txtnombre.Text = "";
                cmbgruposprioridad.Text = "";
                cmbenfermedadescronicas.Text = "";
                txtedad.Text = "";

                consulta();
                                
            }
            
            
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoBusqueda();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtdomicilio.Text = "";
            txtDUI.Text = "";
            txtedad.Text = "";
            txtnombre.Text = "";
            cmbenfermedadescronicas.Text = "";
            cmbgruposprioridad.Text = "";

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                string query = "Select * from Personas";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;


            }
            else
            {
                string query = "Select * from Personas where DUI = '" + txtbuscar.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) ||  (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
            MessageBox.Show("Solo Numeros","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            e.Handled = true;
                return;
            
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) ||  (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
            MessageBox.Show("Solo Numeros","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            e.Handled = true;
                return;
            
            }
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtDUI_Validated(object sender, EventArgs e)
        {
            if (txtDUI.Text.Trim() == "")
            {
                eperror.SetError(txtDUI, "Introduce un DUI");
                txtDUI.Focus();
            }
            else 
            {
                eperror.Clear();
            }
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim() == "")
            {
                eperror.SetError(txtnombre, "Introduce un Nombre");
                txtnombre.Focus();
            }
            else
            {
                eperror.Clear();
            }
        }

        private void txtedad_Validated(object sender, EventArgs e)
        {
            if (txtedad.Text.Trim() == "")
            {
                eperror.SetError(txtDUI, "Introduce una edad");
                txtedad.Focus();
            }
            else
            {
                eperror.Clear();
            }

        }

        private void txtdomicilio_Validated(object sender, EventArgs e)
        {
            if (txtdomicilio.Text.Trim() == "")
            {
                eperror.SetError(txtedad, "Introduce un Domicilio");
                txtdomicilio.Focus();
            }
            else
            {
                eperror.Clear();
            }

        }

        private void cmbenfermedadescronicas_Validated(object sender, EventArgs e)
        {
            if (cmbenfermedadescronicas.Text.Trim() == "")
            {
                eperror.SetError(cmbenfermedadescronicas, "Introduce un dato");
                cmbenfermedadescronicas.Focus();
            }
            else
            {
                eperror.Clear();
            }
        }

        private void cmbgruposprioridad_Validated(object sender, EventArgs e)
        {
            if (cmbgruposprioridad.Text.Trim() == "")
            {
                eperror.SetError(cmbgruposprioridad, "Introduce un grupo de prioridad");
                cmbgruposprioridad.Focus();
            }
            else
            {
                eperror.Clear();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }




    }
}
