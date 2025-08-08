using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Eats
{
    public abstract class Member
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public Member(string name, string id)
        {
            Name = name;
            ID = id;
        }
    }

    public class Student : Member
    {
        public Student(string name, string id) : base(name, id) { }
    }

    public class Lecturer : Member
    {
        public Lecturer(string name, string id) : base(name, id) { }
    }
}

