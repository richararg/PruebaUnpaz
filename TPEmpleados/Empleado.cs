using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEmpleados
{
    internal class Empleado
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private int dni;
        private int edad;
        private int antiguedad;
        private string telefono;
        private double salario;
        private Puesto puesto;
        private Empleado? supervisor;
        private Empleado? secretario;
        private string? despacho;
        private Auto? auto;

        public Empleado(string nombre, string apellido, string direccion, int dni, int edad, int antiguedad, string telefono, double salario, Puesto puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dni = dni;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.telefono = telefono;
            this.salario = salario;
            this.puesto = puesto;
        }

        public Empleado(string nombre, string apellido, string direccion, int dni, int edad, int antiguedad, string telefono, double salario, Puesto puesto, Empleado supervisor) : this(nombre, apellido, direccion, dni, edad, antiguedad, telefono, salario, puesto)
        {
            this.supervisor = supervisor;
        }

        public Empleado(string nombre, string apellido, string direccion, int dni, int edad, int antiguedad, string telefono, double salario, Puesto puesto, Empleado? secretario, string? despacho, Auto? auto) : this(nombre, apellido, direccion, dni, edad, antiguedad, telefono, salario, puesto)
        {
            this.despacho = despacho;
            this.auto = auto;
            this.secretario = secretario;
        }

        public double getsalario()
        {
            return this.salario;
        }
        public string presentarse()
        {
            if (this.puesto.getpuesto() == "Empleado")
            {
                return this.nombre + " " + this.apellido + " Supervisor: " + this.supervisor.presentarse();
            }
            else
            {
                return this.nombre + " " + this.apellido;
            }
        }

        public void cambiosupervisor(Empleado s)
        {
            this.supervisor = s;
        }

        public void incrementarsalario()
        {
            double sueldo = this.salario * this.puesto.getaumento();
            this.salario = sueldo;
        }

        public void cambioauto(Auto a) //agregar control de supervisor?
        {
            this.auto = a;
        }


        public void cambiasecretario(Empleado s)
        {
            this.secretario = s;
        }
    }
}

