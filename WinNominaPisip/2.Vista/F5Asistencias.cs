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
    public partial class F5Asistencias : Form
    {
        private IconButton currentButton;
        private Color _botonColor;
        private readonly APINomina _nomminaAPI;
        private String ApiUrl;
        public F5Asistencias(Color botonColor)
        {
            _botonColor = botonColor;
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"]; // Obtiene la URL de la API desde el archivo de configuración
            _nomminaAPI = new APINomina(ApiUrl); // Inicializa la instancia de APINomina con la URL de la API
            this.Load += F5Asistencias_Load; // Asocia el evento de carga del formulario

        }
        private void F5Asistencias_Load(object sender, EventArgs e)
        {
            //LoadTheme();
            CargarLicencias();

        }
        public async Task CargarLicencias()
        {
            try
            {
                // Aquí puedes llamar al método de la API para obtener los empleados
                var licencia = await _nomminaAPI.GetAsync<List<Licencias>>("LicenciaControlador/ListarLicencias/");
                dgvLicencias.DataSource = licencia;
                dgvLicencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los licencias: {ex.Message}");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botón de Reportes clickeado");
        }

       
    }
}
