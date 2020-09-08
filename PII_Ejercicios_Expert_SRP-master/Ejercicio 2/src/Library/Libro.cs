using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
        /*
        
        Podemos ver que esta clase cumple la funcion de recibir la info. de los libros y almacenarlos.
        El problema es que la funcion de almacenamiento puede ser hecha por otra clase Almacenador ya que no necesita de los datos de la misma.
        Por lo tanto es posible derivar la funcion AlmacenarLibro a itra clase.

        El problema radica en que esta funcion no utiliza sus datos (Título, Autor y Código) para hacer la funcion de almacenaje,
        sumado al hecho de que los parametros SectorBliblioteca y EstanteBliblioteca son dados por el usuario, la existencia de otra clase solo haría que el código sea, mas complejo,
        más confuso a la hora de leerlo, y también menos eficiente ya que no sirve de nada separar una clase en 5 si al final esto no te trae un beneficio real. Por lo tanto, 
        considero que no es necesaria la modificación de este código.

        */

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
