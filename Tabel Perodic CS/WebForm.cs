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

namespace Tabel_Perodic_CS
{
    public partial class WebForm : Form
    {
        List<Element> lst;
        private int nrAtomic;

        public WebForm()
        {
            InitializeComponent();
        }

        public WebForm(int nrAt)
        {
            InitializeComponent();
            nrAtomic = nrAt;
        }

        ChromiumWebBrowser browser;

        private void WebForm_Load(object sender, EventArgs e)
        {
            lst = Element.ReturElementDB();
            //Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(Convert.ToString(lst[nrAtomic - 1].WikiLink));
             this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
