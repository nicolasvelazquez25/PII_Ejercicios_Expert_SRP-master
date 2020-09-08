namespace Library
{
    public class InfoDoctor
    {

        private string Nombre_doctor {get; set;}
    
        private string Especialidad_doctor {get; set;}

        public InfoDoctor(string nombre_doctor, string especialidad_doctor)
        {
            this.Nombre_doctor = nombre_doctor;
            this.Especialidad_doctor = especialidad_doctor;

        }
    }
}