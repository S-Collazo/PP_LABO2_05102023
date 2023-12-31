﻿using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        public string Valor
        {
            get
            {
                return this.valor;
            }
        }
        internal abstract double ValorNumerico
        {
            get;
        }

        static Numeracion()
        {
            msgError = "Numero invalido";
        }
        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);
        protected bool EsNumeracionValida(string valor)
        {
            if (valor == null || valor.Any(char.IsWhiteSpace))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }

        public static explicit operator double(Numeracion numeracion)
        {
            double valorNumeracion = Double.Parse(numeracion.Valor);
            return valorNumeracion;
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 is not null && n2 is not null && n1.GetType() == n2.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
    }
}