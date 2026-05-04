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

            if (!okDist || !okDias)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en Distancia y Días.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            bool cumpleDistancia = distancia >= 100;
            bool cumpleDias = dias >= 7;

            if (cumpleDistancia && cumpleDias)
            {
                string msg = $"Se aplica descuento del 50%.\n\nValores ingresados:\n- Distancia: {distancia} km\n- Días de estancia: {dias}\n\nCondiciones cumplidas, gracias por comprar con Torres Ferrocarril.";
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

                string msg = "No se aplica el descuento del 50%.\n\n";
                msg += $"Valores ingresados:\n- Distancia: {distancia} km\n- Días de estancia: {dias}\n\n";

                if (cumplidas.Count > 0)
                {
                    msg += "Condiciones cumplidas:\n- " + string.Join("\n- ", cumplidas) + "\n\n";
                }

                msg += "Condiciones faltantes:\n- " + string.Join("\n- ", faltantes);

                MessageBox.Show(msg, "Sin descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
