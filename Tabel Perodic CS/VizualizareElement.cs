using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabel_Perodic_CS
{
    public partial class VizualizareElement : Form
    {
        private int nrAtomic;
        List<Element> lst;

        public VizualizareElement()
        {
            InitializeComponent();
        }

        public VizualizareElement(int nrAt)
        {
            InitializeComponent();
            nrAtomic = nrAt;
        }

        private void VizualizareElement_Load(object sender, EventArgs e)
        {
            lblDensitate.Text = "N/A";
            lblPunctFierbere.Text = "N/A";
            lblPunctTopire.Text = "N/A";

            lst = Element.ReturElementDB();
            lblNrAtomic.Text = nrAtomic.ToString();
            lblSimbol.Text = lst[nrAtomic - 1].Simbol.ToString();
            lbDenumire.Text = lst[nrAtomic - 1].Denumire.ToString();
            lblMAtomica.Text = lst[nrAtomic - 1].MasaMolara.ToString();
            lblDenumire1.Text = lst[nrAtomic - 1].Denumire.ToString();
            lblDenumire2.Text = lst[nrAtomic - 1].SerieChimica.ToString();
            if (lst[nrAtomic - 1].Densitate != -300)
                lblDensitate.Text = lst[nrAtomic - 1].Densitate.ToString() + " kg/m³";
            if (lst[nrAtomic - 1].PunctFierbere != -300)
                lblPunctFierbere.Text = lst[nrAtomic - 1].PunctFierbere.ToString() + " °C";
            if(lst[nrAtomic - 1].PunctTopire != -300)
                lblPunctTopire.Text = lst[nrAtomic - 1].PunctTopire.ToString() + " °C";

            switch (lst[nrAtomic - 1].SerieChimica)
            {
                case "Nemetale":
                    pnlElement.BackColor = Color.Black;
                    panel1.BackColor = Color.Black;
                break;

                case "Metale alcaline":
                    pnlElement.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.SkyBlue;
                break;

                case "Gaze nobile":
                    pnlElement.BackColor = Color.Crimson;
                    panel1.BackColor = Color.Crimson;
                break;

                case "Metale alcalino-pamantoase":
                    pnlElement.BackColor = Color.RoyalBlue;
                    panel1.BackColor = Color.RoyalBlue;
                break;

                case "Metale de tranzitie":
                    pnlElement.BackColor = Color.LimeGreen;
                    panel1.BackColor = Color.LimeGreen;
                break;

                case "Metale de post-tranzitie":
                    pnlElement.BackColor = Color.DarkGreen;
                    panel1.BackColor = Color.DarkGreen;
                break;

                case "Metaloizi":
                    pnlElement.BackColor = Color.DarkOrange;
                    panel1.BackColor = Color.DarkOrange;
                break;

                case "Halogeni":
                    pnlElement.BackColor = Color.HotPink;
                    panel1.BackColor = Color.HotPink;
                break;

                case "Lantanide":
                    pnlElement.BackColor = Color.Goldenrod;
                    panel1.BackColor = Color.Goldenrod;
                break;

                case "Actinide":
                    pnlElement.BackColor = Color.Olive;
                    panel1.BackColor = Color.Olive;
                break;

                default:
                break;
            }
        }

        private void WikiClick(object sender, EventArgs e)
        {
            WebPage frm = new WebPage(nrAtomic);
            frm.ShowDialog();
        }
    }
}
