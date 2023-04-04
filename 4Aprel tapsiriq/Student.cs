using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Aprel_tapsiriq
{
    internal class Student
    {
        public string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length > 3)
                {
                    name = value;   
                }
            }
        }
        public string surname;
        public string Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                if (value.Length > 3)
                {
                    Surname = value;
                }
            }
        }




    }
}
