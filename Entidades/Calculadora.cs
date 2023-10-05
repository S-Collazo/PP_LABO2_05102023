using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;

        public string NombreAlumno
        {
            get
            {

            }
            set
            {

            }
        }
        public List<string> Operaciones
        {
            get
            {

            }
        }
        public Numeracion PrimerOperando
        {
            get
            {

            }
            set
            {

            }
        }
        public Numeracion SegundoOperando
        {
            get
            {

            }
            set
            {

            }
        }
        public Numeracion Resultado
        {
            get
            {

            }
        }
        public static ESistema Sistema
        {
            get
            {

            }
            set
            {

            }
        }

        private Calculadora()
        {
            sistema = ESistema.Decimal;
        }
        public Calculadora()
        {
            sistema = ESistema.Decimal;
            operaciones = new List<string>();
        }
        public Calculadora(string NombreAlumno)
        {

        }

        public void Calcular()
        {
            this.Calcular('+');
        }
        public void Calcular(char operador)
        {
            double valorResultado;
            if(primerOperando == segundoOperando)
            {
                switch (operador)
                {
                    case '-':
                        valorResultado = primerOperando.ValorNumerico - segundoOperando.ValorNumerico;
                        break;
                    case '*':
                        valorResultado = primerOperando.ValorNumerico * segundoOperando.ValorNumerico;
                        break;
                    case '/':
                        valorResultado = primerOperando.ValorNumerico / segundoOperando.ValorNumerico;
                        break;
                    default:
                        valorResultado = (double)primerOperando + (double)segundoOperando;
                        break;
                }
            }
            else
            {
                valorResultado = Double.MinValue;
            }
        }
        public void ActualizaHistorialDeOperaciones(char operador)
        {

        }
        public void EliminarHistorialDeOperaciones (char operador)
        {

        }
        private Numeracion MapeaResultado(double valor)
        {
            switch (sistema)
            {
                case ESistema.Binario:
                    return new SistemaBinario(valor.ToString());
                case ESistema.Decimal:
                    return new SistemaDecimal(valor.ToString());
                default:
                    return new SistemaDecimal("");
            }
        }
    }
}
