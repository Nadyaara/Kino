using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    public class Dop
    {
        int _ID;
        string _menu;
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
        public string menu
        {
            get
            {
                return _menu;
            }
            set
            {
                _menu = value;
            }
        }
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }


        public Dop(string menu, double preis)
        {

        }
    }

}
