using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class Persona
    {
        string name;
        int age;
        string profession;

        public Persona(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }

        public string presentarse()
        {
            return "Hola, soy " + this.name + ", tengo " + this.age + " años, y soy " + this.profession + '.';
        }
    }
}
