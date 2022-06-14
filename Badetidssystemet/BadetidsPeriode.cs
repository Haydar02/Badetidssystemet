using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        Dictionary<string, Kreds> _kredser;
        private string _type;
        private DayOfWeek _ugeDag;
        private DateTime _startTidspunkt;
        private DateTime _slutTidspunkt;


        public BadetidsPeriode( string type, DayOfWeek UgeDag, DateTime stratTidspunkt, DateTime slutTidpunkt) 
        {
            if (_startTidspunkt < _slutTidspunkt)

                throw new ArgumentException("StartTidsPunkt må ikke være senere end SlutTidsPunkt");

            _type = type;
            _ugeDag = DayOfWeek.Sunday;
            _startTidspunkt = stratTidspunkt;
            _slutTidspunkt = slutTidpunkt;
            _kredser = new Dictionary<string, Kreds>();

        }
        public string Type
        {
            get { return _type; }
            set
            {
                // opgave 6:Type skal være mindst 4 tegn lang

                if (_type.Length < 4)
                {
                    throw new ArgumentException (" Typen skal være mindst 4 tegn");
                }
                else
                {
                    _type = value;
                }
            }
        }

        public DayOfWeek UgeDag
        {
            get { return _ugeDag; }
            set { _ugeDag = value; }
        }

        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; }
        }

        public DateTime SlutTidspunkt
        {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; }
        }

        public override string ToString()
        {
            string result = $" Type : {Type}, \n Dag : {UgeDag} , \n Start TidsPunkt : {StartTidspunkt.TimeOfDay}, \n Slut Tidspunkt : {SlutTidspunkt.TimeOfDay} \n";
            foreach (var k in _kredser)
            {
                result += k.Value.ToString() + "\n";
            }

            return result;
        }


        public void AdderKreds(Kreds kreds)
        {
            _kredser.Add(kreds.ID,kreds);
        }

        public void SletKredse(string id) 
         {
            _kredser.Remove(id);
        }
    }
}
