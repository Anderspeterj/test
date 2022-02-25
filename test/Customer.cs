using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Customer
    {

        private int _kundeId;
        private string _fullNavn;
        private string _address;
        private double _email;
        private int _mobilNummer;


        public Customer(int KundeId, string FullNavn, string Address, double Email, int MobilNummer)
        {

            _kundeId = KundeId;
            _fullNavn = FullNavn;
            _address = Address;
            _email = Email;
            _mobilNummer = MobilNummer; 


        }



        public int KundeId
        {
            get { return _kundeId;  }
        }

        public string FullNavn
        {
            get { return _fullNavn; }
        }

        public string Address
        {
            get { return _address; }
        }

        public double Email
        {
            get { return _email; }
        }

        public int MobilNummer
        {
            get { return _mobilNummer; }
        }





    }
}
