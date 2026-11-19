using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExecicioHospital
{
    internal class SenhaPreferencial
    {
        public char Prefixo { get; set; }
        public int Numero;
        public SenhaPreferencial Proximo;

        public SenhaPreferencial(int n)
        {
            this.Prefixo = 'S';
            this.Numero = n;
            this.Proximo = null;
        }
        public override string ToString()
        {
            return $"{Prefixo}{Numero}";
        }
    }
}
