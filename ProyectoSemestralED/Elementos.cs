using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestralED
{
    class Elementos : Peliculas
    {        public Elementos(string titulo, int año, string genero, string temporadas, string productor, string sinopsis, string ranting)
        {
            this.Titulo = titulo;

            this.Año = año;

            this.Genero = genero;

            this.Temporadas = temporadas;

            this.Productor = productor;

            this.Sinopsis = sinopsis;

            this.Ranting = ranting;
        }
    }
    
}
