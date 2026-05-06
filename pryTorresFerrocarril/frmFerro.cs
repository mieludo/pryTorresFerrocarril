using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresFerrocarril
{
    public partial class frmFerro : Form
    {
        public frmFerro()
        {
            InitializeComponent();

            
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);
            this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmFerro_Load(object sender, EventArgs e)
        {

        }

        private void lblCondicionDescuento_Click(object sender, EventArgs e)
        {

        }

        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool okDist = int.TryParse(mtbDistancia.Text.Trim(), out int distancia);
            bool okDias = int.TryParse(mtbDias.Text.Trim(), out int dias);
            string destino = tbDestino.Text.Trim();

            
            if (!okDist || !okDias)
            {
                MessageBox.Show("Por favor, ingrese Distancia y Días.", "⚠️​ Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Ingrese el destino deseado", "Destino vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            decimal precioPorKm = 5.0m; 
            decimal precioBase = distancia * precioPorKm;

            bool cumpleDistancia = distancia >= 100;
            bool cumpleDias = dias >= 7;
            bool cumpleDestino = !string.IsNullOrEmpty(destino); 

            decimal descuento = 0m;
            if (cumpleDistancia && cumpleDias && cumpleDestino)
            {
                descuento = 0.5m; 
            }

            decimal precioFinal = precioBase * (1 - descuento);
            decimal descuentoPorcentaje = descuento * 100;

            string nl = Environment.NewLine;

            if (descuento > 0)
            {
                string msg = "Se aplica descuento del " + descuentoPorcentaje + "%." + nl + nl;
                msg += "Valores ingresados:" + nl;
                msg += "- Distancia: " + distancia + " km" + nl;
                msg += "- Días de estancia: " + dias + nl;
                msg += "- Destino: " + destino + nl + nl;

                msg += "Precio base: " + precioBase.ToString("N2") + nl;
                msg += "Descuento: " + descuentoPorcentaje + "%" + nl;
                msg += "Precio final: " + precioFinal.ToString("N2") + nl + nl;

                msg += "Condiciones cumplidas, gracias por comprar con Torres Ferrocarril.​😁​";

                MessageBox.Show(msg, "Descuento aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var cumplidas = new List<string>();
                var faltantes = new List<string>();

                if (cumpleDistancia) cumplidas.Add("Distancia >= 100 km");
                else faltantes.Add("Distancia >= 100 km");

                if (cumpleDias) cumplidas.Add("Días de estancia >= 7");
                else faltantes.Add("Días de estancia >= 7");

                if (cumpleDestino) cumplidas.Add("Destino ingresado");
                else faltantes.Add("Destino ingresado");

                string msg = "No se aplica el descuento del 50%." + nl + nl;
                msg += "Valores ingresados:" + nl;
                msg += "- Distancia: " + distancia + " km" + nl;
                msg += "- Días de estancia: " + dias + nl;
                msg += "- Destino: " + destino + nl + nl;

                msg += "Precio base: " + precioBase.ToString("N2") + nl;
                msg += "Precio final: " + precioFinal.ToString("N2") + nl + nl;


                MessageBox.Show(msg, "Sin descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            mtbDistancia.Clear();
            mtbDias.Clear();
            tbDestino.Clear();
            tbDestino.Focus();
        }
    }
}

