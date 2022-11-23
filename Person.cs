using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_och_objekt
{
    internal class Person
    {
        public class Elev
        {
            public int age;
            public string name;
            public int iq;
            public string averageGrade;

            public Elev(int age, string name, int iq, string averageGrade)
            {
                this.age = age;
                this.name = name;
                this.iq = iq;
                this.averageGrade = averageGrade;
            }
        }

        public class Teacher
        {
            public int age;
            public string name;
            public int iq;
            public string subject;

            public Teacher(int age, string name, int iq, string subject)
            {
                this.age = age;
                this.name = name;
                this.iq = iq;
                this.subject = subject;
            }
        }
    }
}
