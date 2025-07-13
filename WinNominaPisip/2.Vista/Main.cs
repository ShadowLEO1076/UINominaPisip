using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; // Asegúrate de tener esta referencia

namespace WinNominaPisip._2.Vista
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            random = new Random();
        }

        private IconButton currentButton;
        private Random random;
        private int tempIndex;
        private Form? activeForm;

        // DLL para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        // Elegir un color aleatorio del tema
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        // Activar botón clickeado
        private void ActivateButton(object btnSender)
        {
            if (btnSender is IconButton clickedButton)
            {
                if (currentButton != clickedButton)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = clickedButton;
                    Color darkColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    currentButton.BackColor = darkColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular);

                    panelMenu.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelLogo2.BackColor = ThemeColor.SecondaryColor;
                    panelLogo2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.2);
                }
            }
        }
        // Desactivar todos los botones del menú
        private void DisableButton()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is IconButton btn)
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelEscritorio.Controls.Add(childForm);
            this.panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }



        // Eventos de click



        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F1Empleados(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Empleados";
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F2Contratos(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Contratos";

        }




        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F5Asistencias(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Asistencias ";
        }


        private void btnNomina_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F3Nominas(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Nomina";

        }





        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F8Reportes(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Reportes";

        }
        private void btnPercepciones_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F4Percepciones(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Percepciones";

        }





        private void bntPuestos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F7Puestos(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Puestos";

        }

        private void btnVacaciones_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new _2.Vista.F6Vacaciones(currentButton.BackColor), sender);
            labelTitulo.Text = "Gestion Vacaciones";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // la funcion es para cerrar los formularios hijos y volver al formulario principal
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }


        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            // Cambia el estado de maximización del formulario
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            // Minimiza el formulario
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
