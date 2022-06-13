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
    public partial class CalculatorGradNesaturare : Form
    {
        public CalculatorGradNesaturare()
        {
            InitializeComponent();
        }

        private void picBoxCalculator_Click(object sender, EventArgs e)
        {
            int gradNE = 0, coefC = 0, coefH = 0, coefN = 0, coefX = 0;

            if (txtBoxC.Text != "")
                coefC = Convert.ToInt32(txtBoxC.Text);
            if (txtBoxH.Text != "")
                coefH = Convert.ToInt32(txtBoxH.Text);
            if (txtBoxN.Text != "")
                coefN = Convert.ToInt32(txtBoxN.Text);
            if (txtBoxX.Text != "")
                coefX = Convert.ToInt32(txtBoxX.Text);

            gradNE = (int)Math.Round(0.5 * (coefC * 2 + 2 - coefH + coefN - coefX));
            lblNE.Text = Convert.ToString(gradNE);
        }

        private void picBoxCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblNE.Text.ToString());
        }

        private void CalculatorGradNesaturare_Load(object sender, EventArgs e)
        {

        }

        private void CopyMouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picBoxCopy, "Copy");
        }

        private void picBoxCalculator_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picBoxCalculator, "Calculează");
        }
    }
}
