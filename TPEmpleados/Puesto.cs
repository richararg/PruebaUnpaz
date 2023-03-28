using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEmpleados
{
    internal class Puesto
    {
        private string puesto;
        private double aumento;

        public Puesto(string puesto, double aumento)
        {
            this.puesto = puesto;
            this.aumento = aumento;
        }

        public double getaumento() { return this.aumento; }
        public string getpuesto() {  return this.puesto; }  

    }
}
