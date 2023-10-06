using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                double valorDecimal = Double.Parse(this.Valor);
                return valorDecimal;
            }
        }

        public SistemaDecimal(string valor) : base(valor)
        {

        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return new SistemaDecimal(this.Valor.ToString());
            }
            else
            {
                return DecimalABinario();
            }
        }

        ///<summary>
        ///Convierte el valor actual de la instancia en un número binario y lo utiliza para crrar el objeto SistemaBinario.
        ///</summary>
        private SistemaBinario DecimalABinario()
        {
            if (this.ValorNumerico > 0)
            {
                int valorDecimal = (int)this.ValorNumerico;
                int valorADividir = valorDecimal;
                string valorConvertido = "";
                while (valorADividir != 0)
                {
                    int n = valorADividir % 2;
                    valorADividir /= 2;
                    valorConvertido += n;
                }
                char[] valorConvertidoArray = new char[valorConvertido.Length];
                int i = 0;
                foreach (char c in valorConvertido)
                {
                    valorConvertidoArray[i] += c;
                    i++;
                }
                Array.Reverse(valorConvertidoArray);
                valorConvertido = string.Join("", valorConvertidoArray);
                return new SistemaBinario(valorConvertido);
            }
            else
            {
                return new SistemaBinario(msgError);
            }
        }
        protected new bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool EsSistemaDecimalValido(string valor)
        {
            if (Double.TryParse(valor, out double doubleValido))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }
}
