using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLibreria
{
    public class Usuario
    {
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Rut { get; set; }

        
        public Usuario()
        {
        }

       
        public string ATexto()
        {
            return $"{Nombre}|{Apellido}|{Edad}|{Telefono}|{Direccion}|{Rut}";
        }

        public static Usuario DesdeTexto(string linea)
        {
            string[] partes = linea.Split('|');
            return new Usuario
            {
                Nombre = (partes[0]),
                Apellido = partes[1],
                Edad = int.Parse(partes[2]),
                Telefono = int.Parse(partes[3]),
                Direccion = partes[4],
                Rut = partes[5]
            };
        }
    }
}
