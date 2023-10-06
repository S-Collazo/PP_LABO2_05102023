using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
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
                return this.nombreAlumno;
            }
            set
            {
                this.nombreAlumno = value;
            }
        }
        public List<string> Operaciones
        {
            get
            {
                return this.operaciones;
            }
        }
        public Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
            }
            set
            {
                this.primerOperando = value;
            }
        }
        public Numeracion SegundoOperando
        {
            get
            {
                return this.primerOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }
        public Numeracion Resultado
        {
            get
            {
                return this.resultado;
            }
        }
        public static ESistema Sistema
        {
            get
            {
                return sistema;
            }
            set
            {
                sistema = value;
            }
        }

        static Calculadora()
        {
            sistema = ESistema.Decimal;
        }
        public Calculadora()
        {
            operaciones = new List<string>();
        }
        public Calculadora(string NombreAlumno)
        {
            operaciones = new List<string>();
            this.NombreAlumno = NombreAlumno;
        }

        public void Calcular()
        {
            this.Calcular('+');
        }
        public void Calcular(char operador)
        {
            double valorResultado = 0;
            if (primerOperando == segundoOperando)
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
            this.operaciones.Add(valorResultado.ToString());
            this.resultado = MapeaResultado(valorResultado);
        }
        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema: {sistema}");
            sb.AppendLine($"Primer operando: {this.primerOperando.ValorNumerico}");
            sb.AppendLine($"Segundo operando: {this.segundoOperando.ValorNumerico}");
            sb.AppendLine($"Operador: {operador}");
        }
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }
        private Numeracion MapeaResultado(double valor)
        {
            Numeracion resultadoMapeado = new SistemaDecimal(valor.ToString());
            if (sistema == ESistema.Binario)
            {
                return resultadoMapeado.CambiarSistemaDeNumeracion(ESistema.Binario);
            }
            else
            {
                return resultadoMapeado;
            }
        }
    }
}
