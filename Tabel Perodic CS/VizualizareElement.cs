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
            lbNrAtomic.Text = nrAtomic.ToString();
            lbSimbol.Text = lst[nrAtomic - 1].Simbol.ToString();
            lbNume.Text = lst[nrAtomic - 1].Denumire.ToString();
            lbMatomica.Text = lst[nrAtomic - 1].MasaMolara.ToString();
            label1.Text = lst[nrAtomic - 1].Denumire.ToString();
            label2.Text = lst[nrAtomic - 1].SerieChimica.ToString();
            if (lst[nrAtomic - 1].Densitate != -300)
                lblDensitate.Text = lst[nrAtomic - 1].Densitate.ToString() + " kg/m³";
            if (lst[nrAtomic - 1].PunctFierbere != -300)
                lblPunctFierbere.Text = lst[nrAtomic - 1].PunctFierbere.ToString() + " °C";
            if(lst[nrAtomic - 1].PunctTopire != -300)
                lblPunctTopire.Text = lst[nrAtomic - 1].PunctTopire.ToString() + " °C";
            if (lst[nrAtomic - 1].SerieChimica == "Nemetale")
            {
                pnlElement.BackColor = Color.Black;
                panel1.BackColor = Color.Black;
            }
            else
                if (lst[nrAtomic - 1].SerieChimica == "Metale alcaline")
                {
                    pnlElement.BackColor = Color.SkyBlue;
                    panel1.BackColor = Color.SkyBlue;
                }
                else
                    if (lst[nrAtomic - 1].SerieChimica == "Gaze nobile")
                    {
                        pnlElement.BackColor = Color.Crimson;
                        panel1.BackColor = Color.Crimson;
                    }
                    else
                        if (lst[nrAtomic - 1].SerieChimica == "Metale alcalino-pamantoase")
                        {
                            pnlElement.BackColor = Color.RoyalBlue;
                            panel1.BackColor = Color.RoyalBlue;
                        }
                        else 
                            if (lst[nrAtomic - 1].SerieChimica == "Metale de tranzitie")
                            {
                                pnlElement.BackColor = Color.LimeGreen;
                                panel1.BackColor = Color.LimeGreen;
                            }
                            else
                                if (lst[nrAtomic - 1].SerieChimica == "Metale de post-tranzitie")
                                {
                                    pnlElement.BackColor = Color.DarkGreen;
                                    panel1.BackColor = Color.DarkGreen;
                                }
                                else
                                    if (lst[nrAtomic - 1].SerieChimica == "Metaloizi")
                                    {
                                        pnlElement.BackColor = Color.DarkOrange;
                                        panel1.BackColor = Color.DarkOrange;
                                    }
                                    else
                                        if (lst[nrAtomic - 1].SerieChimica == "Halogeni")
                                        {
                                            pnlElement.BackColor = Color.HotPink;
                                            panel1.BackColor = Color.HotPink;
                                        }
                                        else
                                            if (lst[nrAtomic - 1].SerieChimica == "Lantanide")
                                            {
                                                pnlElement.BackColor = Color.Goldenrod;
                                                panel1.BackColor = Color.Goldenrod;
                                            }
                                            else
                                                if (lst[nrAtomic - 1].SerieChimica == "Actinide")
                                                {
                                                    pnlElement.BackColor = Color.Olive;
                                                    panel1.BackColor = Color.Olive;
                                                }
        }

        private void WikiClick(object sender, EventArgs e)
        {
            WebForm frm2 = new WebForm(nrAtomic);
            frm2.ShowDialog();
        }
    }
}
