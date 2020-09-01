using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)// En este caso esta funcion esta bien aplicada ya que ella misma se resuelve su precio sin ser demasiado compleja, Aunque el mismo deberia calcularse su propio precio, ya que el posee toda la informacion necesaria.
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}
