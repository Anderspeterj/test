using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Pizza
    {
        #region Instance fields
        private string _type;
        private string _tilbehør1;
        private string _tilbehør2;
        private int _pris;
        #endregion

        #region Constructor
        public Pizza(string Type, string Tilbehør1, string Tilbehør2, int Pris)
        {
            _type = Type;
            _tilbehør1 = Tilbehør1;
            _tilbehør2 = Tilbehør2;
            _pris = Pris; 
        }
        #endregion

        #region Properties

        public string Type
        {
            get { return _type; }
        }

        public string Tilbehør1
        {
            get { return _tilbehør1; }
        }

        public string Tilbehør2
        {
            get { return _tilbehør2; }
        }

        public int Pris
        {
            get { return _pris; }
        }

        #endregion

        #region Methods




        #endregion





    }
}
