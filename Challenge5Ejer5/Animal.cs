using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5Ejer5
{
    public abstract class Animal
    {
        private string Nombre { get; set; }
        
        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public abstract void Comer();
    }
}
