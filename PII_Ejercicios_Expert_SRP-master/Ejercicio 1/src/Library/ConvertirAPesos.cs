using System;

namespace Expert_SRP
{
    public class ConvertirAPesos
    {
        public static Double Convertir(Double dinero, String moneda)
        /* 

        Esta funcion esta bien aplicada ya que es solo accesible dentro de la clase kiosco, aunque podria aplicarse mediante otra clase,
        en la que se ingrese un parametro de dinero y la misma tenga su propia funcion de conversion, simplificando el codigo de kiosco.
        
        */
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}