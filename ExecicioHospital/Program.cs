using ExecicioHospital;

Console.WriteLine("Hello, World!");

var FilaNormal = new FilaNormal();
var FilaPreferencial = new FilaPreferencial();

int preferenciais = 0;
int regulares = 0;

void Menu(int vezPreferencial, int vezRegular) {
    while (true)
    {
        Console.WriteLine("Digite uma opção:");
        Console.WriteLine("1 - Receber paciente | 2 - Atender paciente");
        int opcao = int.Parse(Console.ReadLine());
        if (opcao == 1)
        {
            Console.Write("1 - Paciente regular | 2 - Paciente preferencial: ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                regulares++;
                Senha senhaR = new(regulares);
                FilaNormal.ReceberPacienteNormal(senhaR);
            }
            else if (opcao == 2)
            {
                preferenciais++;
                SenhaPreferencial senhaP = new(preferenciais);
                FilaPreferencial.ReceberPaciente(senhaP);
            }
            else
            {
                Console.WriteLine("Opção inválida");
                continue;
            }
            Console.WriteLine("\n\n");
        }
        else if (opcao == 2)
        {
            if (vezPreferencial == 0 && vezRegular == 0)
            {
                vezPreferencial = 2;
                vezRegular = 1;
            }
            if(FilaNormal.FilaVazia() && FilaPreferencial.FilaVazia())
            {
                Console.WriteLine("Não há pacientes para serem atendidos.");
                continue;
            }
            if(vezPreferencial > 0 && !FilaPreferencial.FilaVazia())
            {
                Console.WriteLine($"Vez do paciente: {FilaPreferencial.PacientePreferencialAtual()}");
                FilaPreferencial.AtenderPaciente();
                vezPreferencial--;
            }
            else
            {
                Console.WriteLine($"Vez do paciente: {FilaNormal.PacienteAtual()}");
                FilaNormal.AtenderPaciente();
                vezRegular--;
            }
        }
    }
}

while (true)
{
    int vezPreferencial = 2;
    int vezRegular = 1;
    Menu(vezPreferencial, vezRegular);
}