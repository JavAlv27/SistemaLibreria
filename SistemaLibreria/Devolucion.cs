using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLibreria
{
    public class Devolucion
    {
        public string CodigoDevolucion { get; set; }
        public string RutUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string CodigoLibro { get; set; }
        public string NombreLibro { get; set; }
        public DateTime FechaPrestamoOriginal { get; set; } 
        public DateTime FechaDevolucionReal { get; set; } 

        public string ATexto()
        {
            return $"{CodigoDevolucion}|{RutUsuario}|{NombreUsuario}|{CodigoLibro}|{NombreLibro}|{FechaPrestamoOriginal.ToShortDateString()}|{FechaDevolucionReal.ToShortDateString()}";
        }

        public static Devolucion DesdeTexto(string linea)
        {
            string[] partes = linea.Split('|');
            if (partes.Length < 7) return null;

            return new Devolucion
            {
                CodigoDevolucion = partes[0],
                RutUsuario = partes[1],
                NombreUsuario = partes[2],
                CodigoLibro = partes[3],
                NombreLibro = partes[4],
                FechaPrestamoOriginal = DateTime.Parse(partes[5]),
                FechaDevolucionReal = DateTime.Parse(partes[6])
            };
        }
    }
}