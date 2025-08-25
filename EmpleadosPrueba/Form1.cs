using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EmpleadosPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        void InsertarEmpleado()
        {

            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');";
            OdbcCommand Consulta = new OdbcCommand(cadena, cn.conexion());
            Consulta.ExecuteNonQuery();

        }




        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

            // Abrir el formulario Consulta
            var frm = new Consulta();
            frm.Show();

            // Opcional: ocultar Form1
            this.Hide();

        }
    }
}
