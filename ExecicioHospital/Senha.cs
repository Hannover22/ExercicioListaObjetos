using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExecicioHospital
{
    internal class Senha
    {
        public char Prefixo { get; set; }
        public int Codigo;
        public Senha Proximo;

        public Senha(int numero)
        {
            this.Prefixo = 'A';
            this.Codigo = numero;
            this.Proximo = null;
        }
        public override string ToString()
        {
            return $"{Prefixo}{Codigo}";
        }
    }
}
