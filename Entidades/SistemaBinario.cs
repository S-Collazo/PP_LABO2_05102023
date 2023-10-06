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
            if (this.ValorNumerico > 0)
            {
                int valorBinario = (int)this.ValorNumerico;
                int valorADividir = valorBinario;
                string valorConvertido = "";
                while (valorADividir != 0)
                {
                    int n = valorADividir % 2;
                    valorADividir /= 2;
                    valorConvertido += n;
                }
                char[] valorConvertidoArray = new char[valorConvertido.Length];
                valorConvertido = string.Join(",", valorConvertidoArray);
                return new SistemaDecimal(valorConvertido);
            }
            else
            {
                return new SistemaDecimal(this.ValorNumerico.ToString());
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
