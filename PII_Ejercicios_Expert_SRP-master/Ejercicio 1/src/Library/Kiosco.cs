using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos.Convertir(dinero, moneda);
            return pesos >= a.PrecioTotal;
        }
    }
}