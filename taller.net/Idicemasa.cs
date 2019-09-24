using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.net
{
    public partial class Idicemasa : Form


    {
        Masacorporal masacorporal = new Masacorporal();
        public Idicemasa()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            masacorporal.setNumero1(double.Parse(txtnumero1.Text));
            masacorporal.setNumero2(double.Parse(txtnumero2.Text));
            lblmasa.Text = masacorporal.resultado().ToString();
            lblmasa.Visible = true;
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtnumero2.Focus();

            if (masacorporal.resultado() < 18.5)
            {
                MessageBox.Show("bajo peso");
            }
            else
            {
                if (masacorporal.resultado() < 24.9)
                {
                    MessageBox.Show("pesonormal");
                }
                else
                {
                    if (masacorporal.resultado() < 29.9)
                    {
                        MessageBox.Show("sobre peso");
                    }
                    else
                    {
                        if (masacorporal.resultado() < 34.9)
                        {
                            MessageBox.Show("obesidad");
                        }
                        else
                        {
                            if (masacorporal.resultado() < 39.9)
                            {
                                MessageBox.Show("obsidad tipo 2");

                            }
                            else
                            {
                                if (masacorporal.resultado() >= 40)
                                {
                                    MessageBox.Show("obesidad tipo 3");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}