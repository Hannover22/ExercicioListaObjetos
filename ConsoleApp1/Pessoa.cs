using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDinamica.Fila
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa? Proximo;

        public Pessoa(string nome)
        {
            this.Nome = nome;
            Proximo = null;
        }
    }
}
