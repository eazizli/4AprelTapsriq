using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Aprel_tapsiriq
{
    internal class Universty
    {
        public int Id;
        public string Name;
        private List<Student> students = new List<Student>();
      
        public Universty(string name,int id) 
        {
            Name = name;
            Id = id;
        }
        public void AddStudent(Student student) 
        {
            students.Add(student);
        }
    }
}
