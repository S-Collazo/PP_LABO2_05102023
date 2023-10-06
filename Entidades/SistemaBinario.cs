using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                double valorDecimal = Double.Parse(this.Valor);
                return valorDecimal;
            }
        }

        public SistemaBinario(string valor) : base(valor)
        {

        }

        private SistemaDecimal BinarioADecimal()
        {
            if (this.valor != msgError)
            {
                char[] valorBinarioArray = this.ValorNumerico.ToString().ToCharArray();
                Array.Reverse(valorBinarioArray);
                double valorConvertido = 0;
                double n = 0;
                foreach(char c in valorBinarioArray)
                {
                    double digito = (double)c;
                    valorConvertido += c * Math.Pow(2, n);
                    n++;
                }
                return new SistemaDecimal(valorConvertido.ToString());
            }
            else
            {
                return new SistemaDecimal(Double.MinValue.ToString());
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return BinarioADecimal();
            }
            else
            {
                return new SistemaBinario(this.Valor.ToString());
            }
        }
        protected bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && EsSistemaBinarioValido(valor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char c in valor)
            {
                if (c != 0 || c != 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}
