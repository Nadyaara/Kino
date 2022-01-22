using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    class Film
    {
        int _ID;
        string _name;
        string _director;
        int _duration; // if <1 => 1
        double _reting; // if <0 || >10 => 0 || 10
        int _year; // if >2030 => 2030
        string _country;
        string _genre;
        public int ID {
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
        public string name {
            get
            {
                return _name + "(2021)";
            }
            set
            {
                _name = value;
            }

        }

        public string director {
            get
            {
                return _director;
            }
            set
            {
                _director = value;
            }

        }

        public int duration {
            get
            {
                return _duration;
            }
            set
            {
                if (value < 1)
                    _duration = 1;
                else
                    _duration = value;
            }

        }

        public double reting {
            get
            {
                return _reting;
            }
            set
            {
                if (value < 0)
                    _reting = 0;
                else
                    if (value > 10)
                    _reting = 10;
                else
                    _reting = value;
            }

        }

        public int year {
            get
            {
                return _year;
            }
            set
            {
                if (value > 2030)
                    _year = 2030;
                else
                    _year = value;
            }
        }

        public string country { 
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        
        }
        public string genre { 
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        } 

        public Film()
        {
            _reting = 5;
            Console.WriteLine("We have a new moviel");
        }
         public Film(int id, string name, int duration, int year, string genre)
        {
            _ID = id;
            _name = name;
            _duration = duration;
            _year = year;
            _genre = genre;
        }

        //User
        //Room
        //Addon
        //Ticket
        //Screening
        //Console.WriteLine(myFilm.Name);
        //myFilm.Name = "Avengers";
    }
}
