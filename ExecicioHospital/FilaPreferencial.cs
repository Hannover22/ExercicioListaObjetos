using System;
using System.Collections.Generic;
using System.Text;

namespace ExecicioHospital
{
    internal class FilaPreferencial
    {
        public SenhaPreferencial Head;
        public SenhaPreferencial Tail;
        public int Contador;

        public FilaPreferencial()
        {
            Head = Tail = null;
            Contador = 0;
        }

        public bool FilaVazia()
        {
            if(Head == null)
            {
                return true;
            }
            return false;
        }

        public void ReceberPaciente(SenhaPreferencial aux)
        {
            if (FilaVazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
            Contador++;
        }

        public int GetContador()
        {
            return Contador;
        }
        public void AtenderPaciente()
        {
            if (!FilaVazia())
            {
                Head = Head.Proximo;
                Contador--;
            }
        }

        public void MostrarFila()
        {
            SenhaPreferencial s = Head;
            for(int i = 0; i < Contador; i++)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public string PacientePreferencialAtual()
        {
            SenhaPreferencial s = Head;
            return s.ToString();
        }
    }
}
