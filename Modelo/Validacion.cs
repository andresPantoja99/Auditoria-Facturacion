using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_facturacion.Modelo
{
    public class Validacion
    {
        private const string Pattern = "^[\\p{L}\\p{M}\\p{Zs}]+$";
        //private const string Pattern = "^[a-zA-Z]+$"; "^[0-9$&+,':;=?@#|]+$"
        public Validacion()
        {

        }
        public bool caracteres(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("[$/&+!,':;=?@#|]");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool letras(TextBox campo)
        {
            Regex objNaturalPattern = new Regex(Pattern);
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool letrasEspacio(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("^([\\p{L}\\p{M}]+[\\p{Zs}]{0,1}[\\p{L}\\p{M}]*)+$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool correo(TextBox campo)
        {

            Regex objNaturalPattern = new Regex("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool numeros(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("^[0-9]*$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool letrasNumeros(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("^[\\p{L}\\p{M}\\d\\p{Zs}.-]+$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool numeros2(String campo)
        {
            Regex objNaturalPattern = new Regex("^[0-9]+$");
            return objNaturalPattern.IsMatch(campo);
        }
        public bool contrasenia(TextBox campo)
        {
            Regex objNaturalPattern = new Regex("^[\\p{L}\\p{M}\\d\\p{Zs}._!#$%&()=?*-]+$");
            return objNaturalPattern.IsMatch(campo.Text);
        }
        public bool VerificaCedula(string ced)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincia = 24;
            const int tercerDigito = 6;
            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincia) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) * Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }
        public bool RucPersonaNatural(string ruc)
        {
            long isNumeric;
            const int tamanoLongitudRuc = 13;
            const string establecimiento = "001";
            if (long.TryParse(ruc, out isNumeric) && ruc.Length.Equals(tamanoLongitudRuc))
            {
                var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0] + string.Empty, ruc[1] + string.Empty));
                var personaNatural = Convert.ToInt32(ruc[2] + string.Empty);
                if ((numeroProvincia >= 1 && numeroProvincia <= 24) && (personaNatural >= 0 && personaNatural < 6))
                {
                    return ruc.Substring(10, 3) == establecimiento && VerificaCedula(ruc.Substring(0, 10));
                }
                return false;
            }
            return false;
        }

    }
}
