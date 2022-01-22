using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    class Zal
    {
        int _ID;
        int _Place;
        string _ZalTip;
        string _Format;
        int[] _VIP;
        int[] _standart;

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
        public int Place
        {
            get
            {
                return _Place;
            }
            set
            {
                if (value >= 10)
                    _Place = value;
                else
                    _Place = value - 2 * value;

            }

        }
        public string ZalTip
        {
            get
            {
                return _ZalTip;
            }
            set
            {
                _ZalTip = value;
            }

        }
        public string Format
        {
            get
            {
                return _Format;
            }
            set
            {
                _Format = value;
            }

        }
        public int[] VIP
        {
            get
            {
                return _VIP;
            }
            set
            {
                _VIP = value;
            }
        }
        public int[] standart
        {
            get
            {
                return _standart;
            }
            set
            {
                _standart = value;
            }
        }

        public Zal(int id, int Place, string ZalTip, string Format, int[] VIP, int[] standart)
        {
            _ID = id;
            _Place = Place;
            _ZalTip = ZalTip;
            _Format = Format;
            _VIP = VIP;
            _standart = standart;
        }

    }
}
