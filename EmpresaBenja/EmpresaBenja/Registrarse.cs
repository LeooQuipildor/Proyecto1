using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaBenja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelAdmin.Visible = false;
            panelEmpleado.Visible = false;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {       
            if(cmbRol.SelectedItem.ToString() == "Empleado")
            {
                panelEmpleado.Visible = true;
                panelAdmin.Visible = false;
            }
            else
            {
                panelAdmin.Visible = true;
                panelEmpleado.Visible = false;
            }
        }
    }
}
