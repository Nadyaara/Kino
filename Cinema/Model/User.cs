using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    public class User
    {
        int _ID;
        string _name;
        string _Familie;
        long _namber;
        string _Pochta;
        string _login;
        string _password;

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
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }
        public string Familie
        {
            get
            {
                return _Familie;
            }
            set
            {
                _Familie = value;
            }

        }
        
       
        public long namber
        {
            get
            {
                return _namber;
            }
            set
            {
                if (value > 11)
                    throw new Exception("");
                else
                    _namber = value;
                if (value < 11)
                    throw new Exception("");
                else
                    _namber = value;
            }

        }
        public string Pochta
        {
            get
            {
                return _Pochta;
            }
            set
            {
                _Pochta = value;
            }

        }
        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }

        }
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }

        }
        public User(int id, string name, string Familie, string patronymicName, long namber, string Pochta, string login, string password)
        {
            _ID = id;
            _name = name;
            _Familie = Familie;
            _namber = namber;
            _Pochta = Pochta;
            _login = login;
            _password = password;
        }
    }
}
