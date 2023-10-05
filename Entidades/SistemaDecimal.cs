using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class SistemaDecimal : Numeracion
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
                return new SistemaBinario(this.Valor.ToString());
            }
        }
        private SistemaBinario DecimalABinario()
        {
            if (this.ValorNumerico > 0)
            {
                int valorBinario = (int)this.ValorNumerico;
                int valorADividir = valorBinario;
                char[] valorConvertido = new char;
                while (valorADividir != 0)
                {
                    int n = valorADividir % 2;
                    valorADividir /= 2;
                    valorConvertido = new char[n];
                }
                Array.Reverse(valorConvertido);
                return new SistemaBinario(valorConvertido.ToString());
            }
            else
            {
                return new SistemaBinario(this.ValorNumerico.ToString());
            }
        }
        protected bool EsNumeracionValida(string valor)
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
            if (Double.TryParse(valor, out double doubleValido){
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
