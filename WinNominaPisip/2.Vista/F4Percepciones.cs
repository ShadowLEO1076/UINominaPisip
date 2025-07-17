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
using System.Windows.Forms.DataVisualization.Charting;

namespace WinNominaPisip._2.Vista
{
    public partial class F4Percepciones : Form
    {
        //dgvLicencias
        private IconButton currentButton;
        private Color _botonColor;
        private readonly APINomina _nomminaAPI;
        private String ApiUrl;
        public F4Percepciones(Color botonColor)
        {
            _botonColor = botonColor; // guardamos el color del botón activo
            InitializeComponent();
            ApiUrl = ConfigurationManager.AppSettings["APIBaseUrl"]; // Obtiene la URL de la API desde el archivo de configuración
            _nomminaAPI = new APINomina(ApiUrl); // Inicializa la instancia de APINomina con la URL de la API
            this.Load += F4Percepciones_Load; // Asocia el evento de carga del formulario

        }

        private void F4Percepciones_Load(object? sender, EventArgs e)
        {
            LoadTheme();
            CargarEmpleadosEnComboBox();
            CargarMesesEnComboBox();
            //CargarBonificaciones();
        }
        private void CargarMesesEnComboBox()
        {
            var meses = Enumerable.Range(1, 12)
                                  .Select(m => m.ToString("D2")) // Formato "01", "02", ..., "12"
                                  .ToList();

            cbxMes.DataSource = meses;
        }

        /*public async Task CargarBonificaciones()
        {
            try
            {
                // Aquí puedes llamar al método de la API para obtener las percepciones
                var bonificaciones = await _nomminaAPI.GetAsync<List<Bonificaciones>>("BonificacionesControlador/ListarEmpleadosBonificaciones/");
                dgvBonificaciones.DataSource = bonificaciones;
                dgvBonificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las percepciones: {ex.Message}");
            }
        }*/
        public async Task CargarEmpleadosEnComboBox()
        {
            try
            {
                var empleados = await _nomminaAPI.GetAsync<List<Empleados>>("EmpleadosControlador/GetAllAsync");

                // Creamos una lista con solo los nombres y apellidos
                var listaNombres = empleados
                    .Select(e => new
                    {
                        NombreCompleto = $"{e.EmpleadoNombres} {e.EmpleadoApellidos}",
                        Valor = e.EmpleadoCedula // Puedes cambiarlo por otro valor único si lo prefieres
                    })
                    .ToList();

                cbxEmpleadosL.DataSource = listaNombres;
                cbxEmpleadosL.DisplayMember = "NombreCompleto"; // Lo que se muestra
                cbxEmpleadosL.ValueMember = "Valor";            // Lo que se guarda internamente

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados en el combo: {ex.Message}");
            }
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
                    btn.BackColor = ThemeColor.PrimaryColor;//SecondaryColor;
                    btn.ForeColor = Color.White;
                    btn.IconColor = Color.White;
                    btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                    panel1.BackColor = ThemeColor.SecondaryColor; // Cambia el color del panel principal
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void cbxEmpleadosL_SelectedIndexChanged(object sender, EventArgs e)
        {

            // CargarEmpleadosEnComboBox();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombreCompleto = cbxEmpleadosL.Text.Trim();
                var partes = nombreCompleto.Split(' ');
                if (partes.Length < 2)
                {
                    MessageBox.Show("El nombre debe tener al menos nombre y apellido.");
                    return;
                }

                string name = partes[0];
                string lastname = string.Join(" ", partes.Skip(1));
                string year = txtAnio.Text.Trim();
                string? month = cbxMes.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastname) ||
                    string.IsNullOrWhiteSpace(month) || string.IsNullOrWhiteSpace(year))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                //string endpoint = $"BonificacionesControlador/ListarEmpleadosBonificaciones?name={Uri.EscapeDataString(name)}&lastname={Uri.EscapeDataString(lastname)}&year={year}&month={month}";

                var bonificaciones = await _nomminaAPI.GetAsync<List<Bonificaciones>>("ListarEmpleadosBonificaciones?name=Juan&lastname,year=&month");
                //var empleados = await _nomminaAPI.GetAsync<List<Empleados>>("EmpleadosControlador/GetAllAsync");

                dgvBonificaciones.DataSource = bonificaciones;
                dgvBonificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar bonificaciones: " + ex.Message);
            }
        }

    }
}
