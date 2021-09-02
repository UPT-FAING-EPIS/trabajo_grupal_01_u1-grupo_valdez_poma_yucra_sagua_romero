using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron_Estruct_Deco_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCosto.Enabled = false;
        }

        public void LimpiarRadioButtomAgregados()
        {
            rbtAzucar.Checked = false;
            rbtCanela.Checked = false;
            rbtCrema.Checked = false;
            rbtEdulcorante.Checked = false;
            rbtLeche.Checked = false;
        }
        public void LimpiarRadioButtomBebidas()
        {
            rbtDescafeinado.Checked = false;
            rbtExpresso.Checked = false;
            rbtSolo.Checked = false;
            rbtTe.Checked = false;
        }
        public void LimpiarTextBox()
        {          
            txtCosto.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();

            try
            {
                if (rbtSolo.Checked == true)
                {
                    clsBebidaComponent cafe = new clsBebCafeSolo();

                    if (rbtAzucar.Checked == true)
                    {   
                        cafe = new clsDecoAzucar(cafe);
                    }
                    else if (rbtCanela.Checked == true)
                    {
                        cafe = new clsDecoCanela(cafe);
                    }
                    else if (rbtCrema.Checked == true)
                    {
                        cafe = new clsDecoCrema(cafe);
                    }
                    else if (rbtEdulcorante.Checked == true)
                    {
                        cafe = new clsDecoEdulcorante(cafe);
                    }
                    else if (rbtLeche.Checked == true)
                    {
                        cafe = new clsDecoLeche(cafe);
                    }
                    
                    txtCosto.Text = Convert.ToString(cafe.Costo);
                }
                else if (rbtExpresso.Checked == true)
                {
                    clsBebidaComponent cafe = new clsBebCafeExpresso();

                    if (rbtAzucar.Checked == true)
                    {
                        cafe = new clsDecoAzucar(cafe);
                    }
                    else if (rbtCanela.Checked == true)
                    {
                        cafe = new clsDecoCanela(cafe);
                    }
                    else if (rbtCrema.Checked == true)
                    {
                        cafe = new clsDecoCrema(cafe);
                    }
                    else if (rbtEdulcorante.Checked == true)
                    {
                        cafe = new clsDecoEdulcorante(cafe);
                    }
                    else if (rbtLeche.Checked == true)
                    {
                        cafe = new clsDecoLeche(cafe);
                    }

                    txtCosto.Text = Convert.ToString(cafe.Costo);
                }
                else if (rbtDescafeinado.Checked == true)
                {
                    clsBebidaComponent cafe = new clsBebCafeDescafeinado();

                    if (rbtAzucar.Checked == true)
                    {
                        cafe = new clsDecoAzucar(cafe);
                    }
                    else if (rbtCanela.Checked == true)
                    {
                        cafe = new clsDecoCanela(cafe);
                    }
                    else if (rbtCrema.Checked == true)
                    {
                        cafe = new clsDecoCrema(cafe);
                    }
                    else if (rbtEdulcorante.Checked == true)
                    {
                        cafe = new clsDecoEdulcorante(cafe);
                    }
                    else if (rbtLeche.Checked == true)
                    {
                        cafe = new clsDecoLeche(cafe);
                    }

                    txtCosto.Text = Convert.ToString(cafe.Costo);
                }
                else if (rbtTe.Checked == true)
                {
                    clsBebidaComponent cafe = new clsBebTeTradicional();

                    if (rbtAzucar.Checked == true)
                    {
                        cafe = new clsDecoAzucar(cafe);
                    }
                    else if (rbtCanela.Checked == true)
                    {
                        cafe = new clsDecoCanela(cafe);
                    }
                    else if (rbtCrema.Checked == true)
                    {
                        cafe = new clsDecoCrema(cafe);
                    }
                    else if (rbtEdulcorante.Checked == true)
                    {
                        cafe = new clsDecoEdulcorante(cafe);
                    }
                    else if (rbtLeche.Checked == true)
                    {
                        cafe = new clsDecoLeche(cafe);
                    }

                    txtCosto.Text = Convert.ToString(cafe.Costo);
                }
                else
                {
                    MessageBox.Show("Selecciona Una Bebida");
                }
     
            }
            catch
            {
                MessageBox.Show("Selecciona las opciones");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRadioButtomBebidas();
            LimpiarRadioButtomAgregados();
            LimpiarTextBox();
        }
    }
}
