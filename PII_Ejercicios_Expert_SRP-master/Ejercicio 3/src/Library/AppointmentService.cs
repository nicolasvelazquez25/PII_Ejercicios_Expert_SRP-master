using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)//Es posible crear una funcion que haga esta revision y de ser necesario devuelva un string.
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
/*

es necesario crear otros metodos para verificar cada uno de los datos ingresados de manera que sea posible simplificar este codigo, de este modo, si existe un error, 
este sera mas facil de identificar y solucionar (con su clase propia)

tambien es necesario crear un metodo que sea capaz de crear la cadena a devolver, haciendo mas facil la identifiacion de problemas en el producto final

*/
