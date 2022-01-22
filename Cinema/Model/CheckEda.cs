using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    public class CheckEda
    {
        int _ID;
        Dictionary<Dop, int> _Essen;
        double _Itog;
        double _price;

        public int id
        {
            get
            {
                return _ID;
            }
            set
            {
                if (value >= 1)
                    _ID = value;
                else
                    _ID = value - 2 * value;

            }
        }
        public Dictionary<Dop, int> food
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
        public CheckEda(int id, Dictionary<Dop, int> food, double Itog)
        {
            _ID = id;
            _Essen = food;
            _Itog = Itog;
            
        }
        public CheckEda()
        {

        }
    }
}
