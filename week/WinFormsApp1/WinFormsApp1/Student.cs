using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Student
    {
        private string _ID;
        private string _name;
        private int _score;

        public string ShowMsg()
        {
            return $"{_ID}, {_name}, {_score}";
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Score
        {
            get { return _score; }
            set
            {
                if (value > 100) _score = 100;
                else if (value < 0) _score = 0;
                else _score = value;
            }
        }

    }
}
