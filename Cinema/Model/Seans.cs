using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    class Seans
    {
        DateTime _time;
        Film _Kino;
        Zal _mesto;
        List<bool> _Zaneto;

        public DateTime time
        {
            get
            {
                return _time;
            }
            set
            {
                time = value;
            }
        }

        public Film kino
        {
            get
            {
                return _Kino;
            }
            set
            {
                kino = value;
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
                mesto = value;
            }
        }
        public List<bool> Zaneto
        {
            get
            {
                return _Zaneto;
            }
            set
            {
                Zaneto = value;
            }
        }
        public Seans(DateTime time, Film kino, Zal mesto, List<bool> Zaneto)
        {
            _time = time;
            _Kino = kino;
            _mesto = mesto;
            _Zaneto = Zaneto;
        }


    }
}
