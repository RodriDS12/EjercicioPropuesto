using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataDatos.DataSource = Datos.Empleado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataDatos.DataSource = Datos.Empresa;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var MayoresCiudad = from empleado in Datos.Empleado
                                where empleado.Edad > 30 && empleado.Ciudad == "Bogota"
                                select empleado;


            dataDatos.DataSource = MayoresCiudad.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var OrdenarEdad = from empleado in Datos.Empleado
                                where empleado.Edad > 25 && empleado.Edad < 35
                                orderby empleado.Edad descending
                                select empleado;


            dataDatos.DataSource = OrdenarEdad.ToList();
        }


    }
}

