using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tabel_Perodic_CS.ElementeDataSetTableAdapters;

namespace Tabel_Perodic_CS
{
    internal class Element
    {
        private int id;
        private string denumire, simbol, wikiLink, serieChimica;
        private float masaMolara, densitate, punctFierbere, punctTopire;

        public Element(int _id)
        {
            id = _id;
            ElementeTableAdapter tAdapt = new ElementeTableAdapter();
            DataTable table = tAdapt.GetData();
            DataView view = table.DefaultView;

            view.RowFilter = String.Format("Id = {0}", _id);
            denumire = Convert.ToString(view[0]["Denumire"]);
            simbol = Convert.ToString(view[0]["Symbol"]);
            masaMolara = Convert.ToSingle(view[0]["MasaMolec"]);
            wikiLink = Convert.ToString(view[0]["WikiLink"]);
            serieChimica = Convert.ToString(view[0]["SerieChimica"]);

            try
            {
                densitate = Convert.ToSingle(view[0]["Densitate"]);
            }
            catch
            {
                densitate = -300;
            }

            try
            {
                punctFierbere = Convert.ToSingle(view[0]["PunctFierbere"]);
            }
            catch
            {
                punctFierbere = -300;
            }

            try
            {
                punctTopire = Convert.ToSingle(view[0]["PunctTopire"]);
            }
            catch
            {
                punctTopire = -300;
            }
        }

        public Element(string _denumire, string _simbol, float _masaMolara, string _wikiLink, string _serieChimica, float _densitate, float _punctFierbere, float _punctTopire)
        {
            this.denumire = _denumire;
            this.simbol = _simbol;
            this.masaMolara = _masaMolara;
            this.wikiLink = _wikiLink;
            this.serieChimica = _serieChimica;
            this.densitate = _densitate;
            this.punctFierbere = _punctFierbere;
            this.punctTopire = _punctTopire;
        }

        public static List<Element> ReturElementDB()
        {
            List <Element> lst= new List<Element>();
            ElementeTableAdapter tAdapt = new ElementeTableAdapter();
            DataTable table = tAdapt.GetData();
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Element(Convert.ToInt32(dr["Id"])));
            }
            return lst;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public float MasaMolara
        {
            get { return masaMolara; }
            set { masaMolara = value; }
        }

        public string Simbol
        {
            get { return simbol; }
            set { simbol = value; }
        }

        public string WikiLink
        {
            get { return wikiLink; }
            set { wikiLink = value; }
        }

        public string SerieChimica
        {
            get { return serieChimica; }
            set { serieChimica = value; }
        }

        public float Densitate
        { 
            get { return densitate; } 
            set { densitate = value; }
        }

        public float PunctFierbere
        {
            get { return punctFierbere; }
            set { punctFierbere = value; }
        }

        public float PunctTopire
        {
            get { return punctTopire; }
            set { punctTopire = value; }
        }
    }
}
