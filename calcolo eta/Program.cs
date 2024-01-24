using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcolo_eta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.DataNascita = new DateTime();
            p.DataNascita = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(p.Eta);
        }
    }
}
