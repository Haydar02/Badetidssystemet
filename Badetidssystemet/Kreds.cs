using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
   public class Kreds
    {

        private string _id;
        private string _navn;
        private string _adresse;
        private int _antalDeltagere;

        public Kreds(string id, string navn,string adresse,int antaldeltagere)
            
        {
            _id = id;
            _navn = navn;
            _adresse = adresse;
            _antalDeltagere = antaldeltagere;

        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }

        }

        public int AntalDeltagere
        {
            get { return _antalDeltagere; }
            set {
                if (value < 0) {

                    throw new ArgumentException ("Antal Deltagere skal være strørre end 0");
                   

                }

                else
                {
                    _antalDeltagere = value; 


                }
            }
        }
            
            
            
        


        public override string ToString() {
            return $"\n Kredsens ID : {ID} \n Kredsens navn : {Navn} \n Kredsens adresse  : {Adresse} \n Antallet af deltager  : {AntalDeltagere} ";
        }
    }
}
