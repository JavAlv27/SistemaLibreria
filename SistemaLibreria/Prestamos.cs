using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLibreria
{
    public class Prestamos
    {
        public string CodigoPrestamo { get; set; }
        public string RutUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string CodigoLibro { get; set; }
        public string NombreLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public Prestamos()
        { 
        }

        public string ATexto()
        {
            return $"{CodigoPrestamo}|{RutUsuario}|{NombreUsuario}|{CodigoLibro}|{NombreLibro}|{FechaPrestamo.ToShortDateString()}|{FechaDevolucion.ToShortDateString()}";
        }

        public static Prestamos DesdeTexto(string linea)
        {
            string[] partes = linea.Split('|');
            if (partes.Length < 7) return null;

            return new Prestamos
            {
                CodigoPrestamo = partes[0],
                RutUsuario = partes[1],
                NombreUsuario = partes[2],
                CodigoLibro = partes[3],
                NombreLibro = partes[4],
                FechaPrestamo = DateTime.Parse(partes[5]),
                FechaDevolucion = DateTime.Parse(partes[6])
            };
        }
    }
}
