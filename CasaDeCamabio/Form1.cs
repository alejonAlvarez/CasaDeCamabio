using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// fechea:23/02/2021
/// Autor:Alejandro Alvarez
/// Descripcion:Casa de cambio 
/// </summary>

namespace CasaDeCamabio
{
    public partial class wCasaDeCambio : Form
    {
        public wCasaDeCambio()
        {
            InitializeComponent();
            InicialFormulario();
        }

        // private void grpTipoDeMoneda_Enter(object sender, EventArgs e)

        private void InicialFormulario()


        {
            try
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtdireccion.Text = "";
                txtTelefono.Text = "";

                #region[llevar combo ciudad]
                cmbCiudad.Items.Clear();
                cmbCiudad.Items.Add("Medellin");
                cmbCiudad.Items.Add("Pereira");
                cmbCiudad.Items.Add("Cali");
                cmbCiudad.Items.Add("Cartagena");
                #endregion

                #region[llenar combo moneda origen]
                cmbMonedaOrigen.Items.Clear();
                cmbMonedaOrigen.Items.Add("Peso colombiano - COP");
                cmbMonedaOrigen.Items.Add("Dolar americano - USD");
                cmbMonedaOrigen.Items.Add("Franco suizo - CHF");
                #endregion

                #region[llenar combo moneda destino]
                cmbMonedaDestino.Items.Clear();
                cmbMonedaDestino.Items.Add("Peso colombiano - COP");
                cmbMonedaDestino.Items.Add("Dolar americano - USD");
                cmbMonedaDestino.Items.Add("Franco suizo - CHF");
                #endregion

                

                rdbEfectivo.Checked = true;

                
                }

            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

            }
        //:(
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre:       \t" + txtNombre.Text + "\r\n" + "Apellido:      \t" + txtApellido.Text + "\r\n" + "direccion:   \t" + txtdireccion.Text + "\r\n" + "telefono:   \t" + txtTelefono.Text + "\r\n" + "ciudad:    \t" + cmbCiudad.Text);
            MessageBox.Show("Moneda origen:   \t" + cmbMonedaOrigen.Text + "\r\n" + "Moneda destino:    \t" + cmbMonedaDestino.Text + "\r\n");
            MessageBox.Show("Resultado:");

            double a = Convert.ToDouble(txtCantidadValor.Text);
            double b = Convert.ToDouble(txtCanje.Text);
            double r = a * b;
            
            
           

        }
    }

                }
            


