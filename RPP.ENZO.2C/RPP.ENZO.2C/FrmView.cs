using LibreriaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPP.ENZO._2C
{
    public partial class FrmView : Form
    {
        private Fabrica fabrica;

        public FrmView()
        {
            InitializeComponent();
            this.fabrica = new Fabrica(10); // Capacidad 10
            InicializarFabrica();
            Refrescar();
        }

        private void Refrescar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = fabrica.Vehiculos;
            comboBox1.DataSource = null;
            comboBox1.DataSource = fabrica.Vehiculos;
            comboBox1.DisplayMember = "Info";
        }

        private Vehiculo CrearVehiculo()
        {

            Vehiculo vehiculoSeleccionado = (Vehiculo)comboBox1.SelectedItem;


            Vehiculo nuevoVehiculo = null;

            if (vehiculoSeleccionado is Moto)
            {

                nuevoVehiculo = new Moto(vehiculoSeleccionado.Propulsion);
            }

            return nuevoVehiculo;
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = CrearVehiculo();
            fabrica += nuevoVehiculo;
            foreach (var item in fabrica.Vehiculos)
            {
                //this.listBox1.Items.Add(item.getInfo);
            }
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = (Vehiculo)listBox1.SelectedItem;
            fabrica -= vehiculoSeleccionado;

            Refrescar();
        }

        private void InicializarFabrica()
        {
            //comboBox1.Items.Add(new Moto(EPropulsion.electrica));
            //comboBox1.Items.Add(new Camioneta(EPropulsion.hibrida, true));
            //comboBox1.Items.Add(new Automovil());

            comboBox1.Items.Add("Auto");
            comboBox1.Items.Add("Moto");
            comboBox1.Items.Add("Camioneta");
        }
    }
}
