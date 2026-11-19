using System;
using System.Collections.Generic;
using System.Text;

namespace ExecicioHospital
{
    internal class FilaNormal
    {
        public Senha Head;
        public Senha Tail;
        public int Contador;

        public FilaNormal()
        {
            Head = Tail = null;
            Contador = 0;
        }

        public bool FilaVazia()
        {
            if (Head == null)
            {
                return true;
            }
            return false;
        }

        public void ReceberPacienteNormal(Senha aux)
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
            Senha s = Head;
            for (int i = 0; i < Contador; i++)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public string PacienteAtual()
        {
            Senha s = Head;
            return s.ToString();
        }
    }
}
