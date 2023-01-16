using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_1_2023_Upis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIme.Text != "" && txtECTS.Text != "")
                {
                    Student s = new Student();
                    s.Ime = txtIme.Text;
                    s.BrECTS = Convert.ToInt32(txtECTS.Text);
                    if (cbxPonavljac.Checked == true)
                        s.Ponavljac = true;
                    else
                        s.Ponavljac = false;

                    lblShowReturn.Text = $"Iznos školarine: {s.Skolarina():C}";
                }
                else
                    MessageBox.Show("Sva polja su obvezna!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Neispravan unos!");
            }
        }
    }
}
