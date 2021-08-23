using NotasAlumnos3Carp.Entidades;
using NotasAlumnos3Carp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumnos3Carp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsNotas clsnotas = new ClsNotas();
            NClsNotas nclsnotas = new NClsNotas();

            clsnotas.Lab1 = 5.3;
            clsnotas.Parcial1 = 7.3;

            clsnotas.Lab2 = 10;
            clsnotas.Parcial2 = 5.9;

            clsnotas.Lab3 = 9.2;
            clsnotas.Parcial3 = 9.9;

            Console.WriteLine(nclsnotas.periodo1(clsnotas));
            Console.WriteLine(nclsnotas.periodo2(clsnotas));
            Console.WriteLine(nclsnotas.periodo3(clsnotas));
            Console.WriteLine(nclsnotas.ciclo1(clsnotas));

            Console.ReadLine();
        }
    }
}
