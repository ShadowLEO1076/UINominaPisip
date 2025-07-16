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
    public partial class F7Puestos : Form
    {
        //dgvLicencias
        private IconButton currentButton;
        private Color _botonColor;
        private readonly APINomina _nomminaAPI;
        private String ApiUrl;
        public F7Puestos(Color botonColor)
        {
            _botonColor = botonColor; // guardamos el color del botón activo
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"]; // Obtiene la URL de la API desde el archivo de configuración
            _nomminaAPI = new APINomina(ApiUrl); // Inicializa la instancia de APINomina con la URL de la API
            this.Load += F7Puestos_Load; // Asocia el evento de carga del formulario

        }
        public async Task CargarPuestos()
        {
            try
            {
                // Aquí puedes llamar al método de la API para obtener los empleados
                var puestos = await _nomminaAPI.GetAsync<List<Puestos>>("PuestosControlador/ListarEmpleadosPuestos/");
                dgvPuestos.DataSource = puestos;
                dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los puestos: {ex.Message}");
            }
        }
        private void F7Puestos_Load(object sender, EventArgs e)
        {
            LoadTheme();
            CargarPuestos(); // Llama al método para cargar los empleados al iniciar el formulario
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
                    flowLayoutPanel1.BackColor = ThemeColor.PrimaryColor; /// panel de botones algo nuevo mucho ojooooo
                    panel1.BackColor = ThemeColor.SecondaryColor;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = Color.White;
                }
                else if (control.HasChildren)
                {
                    AplicarTemaRecursivo(control.Controls);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botón de Reportes clickeado");
        }

        
    }
}
