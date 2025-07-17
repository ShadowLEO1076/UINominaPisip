using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Nomina.API.Controllers;
using NominaPISIB.Infraestructura.AccesoDatos;


namespace WinNominaPisip._2.Vista
{
    public partial class F1Empleados : Form
    {
        private IconButton currentButton;
        private Color _botonColor;
        private readonly APINomina _nomminaAPI;
        private String ApiUrl;
        

        public F1Empleados(Color botonColor)
        {
            _botonColor = botonColor; // guardamos el color del botón activo
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"]; // Obtiene la URL de la API desde el archivo de configuración
            _nomminaAPI = new APINomina(ApiUrl); // Inicializa la instancia de APINomina con la URL de la API
            this.Load += F1Empleados_Load_1; // Asocia el evento de carga del formulario

        }
        
        // EVENTEO PARA CARGAR O LISTAR LOS DATOS DEL EMPLEADO
        public async Task CargarEmpleados()
        {
            try
            {
                // Aquí puedes llamar al método de la API para obtener los empleados
                var empleados = await _nomminaAPI.GetAsync<List<Empleados>>("EmpleadosControlador/GetAllAsync");
                dgvEmpleados.DataSource = empleados;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados: {ex.Message}");
            }
        }
        private async Task F1Empleados_Load(object sender, EventArgs e)
        {
            LoadTheme();
            CargarEmpleados(); // Llama al método para cargar los empleados al iniciar el formulario
            // Aquí puedes llamar a un método para cargar los datos de los empleados
            // Por ejemplo: CargarEmpleados();
        }


        private void F1Empleados_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            CargarEmpleados();
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
                    //flowLayoutPanel4.BackColor = ThemeColor.PrimaryColor; /// panel de botones algo nuevo mucho ojooooo
                    panel1.BackColor = ThemeColor.SecondaryColor;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = Color.Black;
                    label10.ForeColor = Color.White;
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

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
                    }
    }
}
