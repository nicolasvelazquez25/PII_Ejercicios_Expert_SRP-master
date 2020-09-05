using System;

namespace Library
{
    public class AppointmentService
    {
        
        public void CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            Boolean isValid = true;
            if (Verificador.Verificar(name) != true)//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                isValid = false;
                string nombre_string = "Name";
                Creador_cadenas.Creador_invalido(nombre_string);
            }

            if (Verificador.Verificar(id) != true)//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                isValid = false;
                string id_string = "Id";
                Creador_cadenas.Creador_invalido(id_string);      
            }

            if (Verificador.Verificar(phoneNumber) != true)//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                isValid = false;
                string numero_string = "Phone number";
                Creador_cadenas.Creador_invalido(numero_string);
                
            }

            if (Verificador.Verificar(appoinmentPlace) != true)//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                isValid = false;
                string lugar_string = "Appoinment Place";
                Creador_cadenas.Creador_invalido(lugar_string);
                
            }

            if (Verificador.Verificar(doctorName) != true)//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                isValid = false;
                string doctor_string = "Doctor´s Name";
                Creador_cadenas.Creador_invalido(doctor_string);
                
            }

            if (isValid)//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                Creador_cadenas.Creador_valido();
            }

            Printer.Imprimir(Creador_cadenas.Cadena)

        }

    }
}
/*

es necesario crear otros metodos para verificar cada uno de los datos ingresados de manera que sea posible simplificar este codigo, de este modo, si existe un error, 
este sera mas facil de identificar y solucionar (con su clase propia)

tambien es necesario crear un metodo que sea capaz de crear la cadena a devolver, haciendo mas facil la identifiacion de problemas en el producto final

*/
