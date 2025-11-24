using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLibreria
{
    public class Libros
    {
      
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public string Editorial { get; set; }
        public string Codigo { get; set; }
        public int Stock { get; set; }

       
        public Libros()
        {
        }

       
       
        public string ATexto()
        {
            return $"{Codigo}|{Titulo}|{Autor}|{Stock}|{Categoria}|{Editorial}";
        }

       
        public static Libros DesdeTexto(string linea)
        {
            string[] partes = linea.Split('|');
            return new Libros
            {
                Codigo = (partes[0]),
                Titulo = partes[1],
                Autor = partes[2],
                Stock = int.Parse(partes[3]),
                Categoria = partes[4],
                Editorial = partes[5]
            };
        }
    }
}
