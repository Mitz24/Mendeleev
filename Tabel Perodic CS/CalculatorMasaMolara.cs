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
    public partial class CalculatorMasaMolara: Form
    {
        List<Element> lst;
        private float masaMoleculara = 0;

        public CalculatorMasaMolara()
        {
            InitializeComponent();
        }

        private void CalculatorMasaMolara_Load(object sender, EventArgs e)
        {
            lst = Element.ReturElementDB();
        }

        private void picBoxCalculator_Click(object sender, EventArgs e)
        {
            StartComputation();
        }

        void StartComputation()
        {
            try
            {
                FormResultData();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Formula a fost scrisă incorect!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInput();

                return;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Element inexistent!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInput();

                return;
            }
        }

        float ComputeFormula(string input)
        {
            float total = 0;

            List<Tuple<string, int, float>> st = new List<Tuple<string, int, float>>();
            int depth = -1;

            string extFormula = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[')
                {
                    st.Add(new Tuple<string, int, float>("", 0, 0));
                    depth++;
                }
                else
                {
                    if (input[i] == ')' || input[i] == ']')
                    {
                        int j, coef;
                        string coefStr = String.Empty;

                        for (j = i + 1; j < input.Length; j++)
                        {
                            if (Char.IsDigit(input[j]))
                                coefStr += input[j];
                            else
                                break;
                        }

                        i = j - 1;

                        if (depth >= 0)
                        {
                            if (!int.TryParse(coefStr, out coef))
                                coef = 1;

                            st[depth] = new Tuple<string, int, float>(st[depth].Item1, coef, st[depth].Item3);

                        }

                        if (depth >= 1)
                            st[depth - 1] = new Tuple<string, int, float>(st[depth - 1].Item1, st[depth - 1].Item2, st[depth - 1].Item3 + CalculateSubFormula(st[depth].Item1, st[depth].Item2) + st[depth].Item3 * st[depth].Item2);
                        else
                            total += ((CalculateSubFormula(st[depth].Item1) + st[depth].Item3) * st[depth].Item2);

                        st.RemoveAt(depth--);
                    }
                    else
                    {
                        if (Char.IsLetterOrDigit(input[i]))
                        {
                            if (depth >= 0)
                                st[depth] = new Tuple<string, int, float>(st[depth].Item1 + input[i], st[depth].Item2, st[depth].Item3);
                            else
                                extFormula += input[i];
                        }
                    }

                }
            }

            total += CalculateSubFormula(extFormula);

            return total;
        }

        float CalculateSubFormula(string input, int dezCoef = 1)
        {
            string symbol, coefStr;
            symbol = coefStr = String.Empty;

            float total = 0;
            int coef;

            foreach (char ch in input)
            {
                if (Char.IsLetter(ch))
                {
                    if (Char.IsLower(ch))
                        symbol += ch;
                    else
                    {
                        if (!String.IsNullOrEmpty(symbol))
                        {
                            if (!int.TryParse(coefStr, out coef))
                                coef = 1;

                            total += (Resource.FindMolecularMass(symbol) * coef);

                            coefStr = String.Empty;
                        }

                        symbol = String.Empty + ch;
                    }
                }
                else
                {
                    if (Char.IsDigit(ch))
                        coefStr += ch;
                }
            }

            if (!String.IsNullOrEmpty(symbol))
            {
                if (!int.TryParse(coefStr, out coef))
                    coef = 1;

                total += (Resource.FindMolecularMass(symbol) * coef);
                coefStr = String.Empty;
            }

            return total;
        }

        void FormResultData()
        {
            masaMoleculara = ComputeFormula(txtFormula.Text);

            if (masaMoleculara == -1)
                throw new System.FormatException();

            if (masaMoleculara == 0)
                throw new System.NullReferenceException();

            lblMm.Text = masaMoleculara.ToString() + " g/mol";
        }

        private void ClearInput()
        {
            txtFormula.Text = "";
        }

        private void picBoxCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(masaMoleculara.ToString());
        }

        private void picBoxCalculator_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picBoxCalculator, "Calculează");
        }

        private void picBoxCopy_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picBoxCopy, "Copy");
        }
    }
}
