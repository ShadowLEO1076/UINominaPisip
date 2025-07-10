using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinNominaPisip._2.Vista
{
    public partial class F4Percepciones : Form
    {
        private Color _botonColor;
        public F4Percepciones(Color botonColor)
        {
            BackColor = botonColor;
            InitializeComponent();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botón de Reportes clickeado");
        }
    }
}
