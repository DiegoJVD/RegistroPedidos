namespace RegistroPedidos.BLL
{
    public class Utilidades{
        public static int ToInt(string value)
        {
            int return_ = 0;

            int.TryParse(value, out return_);

            return return_;
        }

        public static float ToFloat(string value)
        {
            float return_ = 0;

            float.TryParse(value, out return_);

            return return_;
        }

        public static decimal ToDecimal(string value)
        {
            decimal return_ = 0;

            decimal.TryParse(value, out return_);

            return return_;
        }
    }
}