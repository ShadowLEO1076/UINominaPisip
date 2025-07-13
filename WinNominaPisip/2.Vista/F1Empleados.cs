using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace WinNominaPisip._2.Vista
{
    public partial class F1Empleados : Form
    {
        private IconButton currentButton;
        private Color _botonColor;

        public F1Empleados(Color botonColor)
        {
            _botonColor = botonColor; // guardamos el color del botón activo
            InitializeComponent();
            this.Load += F1Empleados_Load_1;

        }


        private void F1Empleados_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }




        private void LoadTheme()
        {
            // Fondo principal del formulario
            this.BackColor = ThemeColor.PrimaryColor;

            // Cambiar el color de fondo y texto de todos los IconButton
            foreach (Control control in this.Controls)
            {
                if (control is IconButton btn)
                {
                    btn.BackColor = ThemeColor.SecondaryColor; // color más oscuro
                    btn.ForeColor = Color.White;
                    btn.IconColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                }
            }

            // Cambiar color de texto de labels u otros controles
            foreach (Control control in this.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.ForeColor = Color.Black;
                }
            }

            // Si tienes paneles internos o contenedores, debes recorrer también sus controles
            AplicarTemaRecursivo(this.Controls);
        }
        private void AplicarTemaRecursivo(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is IconButton btn)
                {
                    btn.BackColor = ThemeColor.PrimaryColor;//.SecondaryColor;
                    btn.ForeColor = Color.White;
                    btn.IconColor = Color.White;
                    btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = Color.Black;
                }
                else if (control.HasChildren)
                {
                    AplicarTemaRecursivo(control.Controls);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
