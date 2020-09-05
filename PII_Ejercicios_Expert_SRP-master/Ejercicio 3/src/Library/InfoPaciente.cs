namespace Library
{
    public class InfoPaciente
    {
        private string Nombre_paciente {get; set;}
    
        private string Telefono_paciente {get; set;}
        
        private string Edad_paciente {get; set;}

        public InfoPaciente(string nombre_paciente, string telefono_paciente, string edad_paciente)
        {
            this.Nombre_paciente = nombre_paciente;
            this.Telefono_paciente = telefono_paciente;
            this.Edad_paciente = edad_paciente;
        }
    }
}