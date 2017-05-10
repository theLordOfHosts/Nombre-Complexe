using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre_Complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Surcharge des operateurs
            var a = new NombreComplexe(1, 2);
            var b = new NombreComplexe(3, 5);

            var c = a + b;
            c = b - a;
            c = a * b;
            c = 5 / (a / b);
            c = b / a;

            var state = a == b;
            state = a.Equals(b);
            state = a != b;
            state = a > b;
            state = a >= b;
            state = a < b;
            state = a <= b;

            #endregion

            #region Type anonyme
            var person = new { Name = "Lambi", LastName = "Marrion" };
            //var person2 = new { "Lambi", "Marrion" };
            //var person2 = new { a , LastName = "Marrion" };

            //person.Name = "Unknown";
            //person.Age = 12;

            string name = person.Name;
            #endregion

            var admin = new Role(1, "Admin");
            int id = admin;
            var superviseur = (Role)2;
        }
    }
}
