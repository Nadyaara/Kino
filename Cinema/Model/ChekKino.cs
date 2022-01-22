using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    class ChekKino
    {
        int _ID;
        User _Person;
        double _Itog;
        Seans _Kino;   //место
        Zal _mesto;
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

        public User person
        {
            get
            {
                return _Person;
            }
            set
            {
                _Person = value;
            }
        }


        public double summa
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
        public Seans kino
        {
            get
            {
                return _Kino;
            }
            set
            {
                _Kino = value;
            }
        }
        public Zal mesto
        {
            get
            {
                return _mesto;
            }
            set
            {
                _mesto = value;
            }
        }

        public ChekKino(int id, User person, double summa, Seans kino, Zal mesto)
        {
            _ID = id;
            _Person = person;
            _Itog = summa;
            _Kino = kino;
            _mesto = mesto;
        }
    }
}
