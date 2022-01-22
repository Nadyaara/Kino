using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    public class Korzina
    {
        Dictionary<Dop, int> _Essen;
        int _ID;
        User _Users;
        double _Itog;

        public Korzina(int ID, User Users, Dictionary<Dop, int> Essen, double Itog)
        {
            _ID = ID;
            _Users = Users;
            _Essen = Essen;
            _Itog = Itog;
        }

        public double Itog
        {
            get
            {
                return _Itog;

            }
            set
            {
                _Itog = value;
            }
        }

        public int ID
        {
           get
           {
                return _ID;
           }
            set
            {
                _ID = value;
            }
        }

        public Dictionary<Dop, int> Essen
        {
            get
            {
                return _Essen;
            }
            set
            {
                _Essen = value; 
            }
        }

        public User Users
        {
            get
            {
                return _Users;
            }
            set
            {
                _Users = value;
            }
        }

    }
}
