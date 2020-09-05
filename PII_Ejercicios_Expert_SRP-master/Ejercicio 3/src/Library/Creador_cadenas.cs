using System;
using System.Text;

namespace Library
{
    public class Creador_cadenas
    {
        StringBuilder cadena = new StringBuilder("Scheduling appointment...\n");
        public void Creador_invalido(string error)
        {
            StringBuilder error_sb = new StringBuilder(error);
            cadena.Append($"Unable to schedule appointment, {error_sb} is required\n");
        }

        public void Creador_valido()
        {
            cadena.Append("Appoinment Scheduled");
        }

        public string Cadena {get;}

        public Creador_cadenas()
        {
            this.Cadena = cadena.ToString();
        }
    }
}