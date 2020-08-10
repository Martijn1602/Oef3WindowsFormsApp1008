using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef3WindowsFormsApp1008
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> NamesList = new List<string>();

        private void lbLijst_SelectedIndexChanged(object sender, EventArgs e)


        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            

            NamesList.Add("Martijn");
            NamesList.Add("Noah");
            NamesList.Add("Petra");
            NamesList.Add("Mokka");
            NamesList.Add("Willem");
            NamesList.Add("Marianne");
            NamesList.Add("Arne");
            NamesList.Add("Stephanie");
            NamesList.Add("Vince");
            NamesList.Add("Bas");
            NamesList.Add("Jens");
            NamesList.Add("Kimberley");
            NamesList.Add("Kobe");
            NamesList.Add("Lise");
            NamesList.Add("Kato");

            foreach (var item in NamesList)
            {
                lbLijst.Items.Add(item);
            }
        }

        private void txtTekst_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKnop_Click(object sender, EventArgs e)
        {
            lbLijst.Items.Clear();

            foreach (var item in NamesList)
            {
                if (item.ToLower().Contains(txtTekst.Text.ToLower()))
                {
                    lbLijst.Items.Add(item);
                }
            }
        }
    }
}
