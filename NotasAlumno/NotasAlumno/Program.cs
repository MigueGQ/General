﻿using NotasAlumno.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota nota = new Nota(9, 5, 7, 8, 3, 5);
            Console.WriteLine(nota.ToString());
            Console.ReadLine();
        }
    }
}
