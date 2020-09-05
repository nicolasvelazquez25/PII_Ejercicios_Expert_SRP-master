namespace Library
{
    public class Verificador
    {
        public static bool Verificar(string dato)
        {
            if (dato != null && dato != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}