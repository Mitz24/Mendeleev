using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Media;

namespace Tabel_Perodic_CS
{
    public partial class TabelPeriodic : Form
    {

        List<Element> lst;
        Random rnd = new Random();
        //SoundPlayer player = new SoundPlayer(@"C:\Users\Mihai\Desktop\info\TabelPerodicCS\Tabel Perodic CS\Sound Effects\Super Mario Coin Sound Effect.wav");
        private SoundPlayer player;

        public TabelPeriodic()
        {
            InitializeComponent();
            player = new SoundPlayer(Properties.Resources.Super_Mario_Coin_Sound_Effect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst = Element.ReturElementDB();
            Cef.Initialize(new CefSettings());
            LoadSuggestions();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlElement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pnlElement.BackColor = btn.BackColor;
            lbSimbol.Text = btn.Text;
            lbNrAtomic.Text = (string)btn.Tag;
            lbNume.Text = lst[Convert.ToInt32(btn.Tag) - 1].Denumire;
            lbMatomica.Text = lst[Convert.ToInt32(btn.Tag) - 1].MasaMolara.ToString();
        }

        private void BtnClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            VizualizareElement frm = new VizualizareElement(Convert.ToInt32(btn.Tag));
            frm.ShowDialog();
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            CalculatorGradNesaturare frm3 = new CalculatorGradNesaturare();
            frm3.ShowDialog();
        }

        private void BtnQClick(object sender, EventArgs e)
        {
            player.Play();
            VizualizareElement frm = new VizualizareElement(rnd.Next(118) + 1);
            frm.ShowDialog();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            CalculatorMasaMolara frm4 = new CalculatorMasaMolara();
            frm4.ShowDialog();
        }

        private void LoadSuggestions()
        {
            var sursa = new AutoCompleteStringCollection();

            foreach (Element entry in lst)
                sursa.Add(entry.Denumire);

            txtSearch.AutoCompleteCustomSource = sursa;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FindElement(txtSearch.Text);
        }

        private void FindElement(string nume)
        {
            if (!String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                int nrAt = 0;

                for (int i = 0; i < 118; i++)
                {
                    if (lst[i].Denumire.ToLower().Equals(nume.ToLower()))
                        nrAt = lst[i].Id;
                }

                if(nrAt > 0)
                {
                    VizualizareElement frm = new VizualizareElement(nrAt);
                    frm.ShowDialog();
                }
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindElement(txtSearch.Text);
        }
    }
}
