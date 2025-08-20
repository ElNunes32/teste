using System;
 
struct Paciente //é a classe que o vetor está ligado, eeses elemento ai tudo ta ligado dentro de cada casa do vetor
{
    public string Nome;
    public int Idade;
    public string Sexo;
    public string Cpf;

    public bool Febre;
    public bool Taquicardia;
    public bool Taquipneia;
    public bool PressaoAlta;
    public bool Historico;

    public string Classificacao;
    public string Diagnostico;

}




class Program
{
    static void Main(string[] args)
    {
        string opcao;
        const int maxpaciente = 10;
        Paciente[] meusPacientes = new Paciente[maxpaciente];
        int numeroPacientes = 0; // Contador de pacientes cadastrados
        

        do//isso aqui é a estrutura de repetição que vai manter tudo funcionando ate o cara escolher pra sair
        {
            // MENU INICIAL
            Console.Clear();
            Console.WriteLine("====PROGRAMA MÉDICO====");
            Console.WriteLine("\n");
            Console.WriteLine("1_Cadastrar Paciente;\n2_Ver Pacientes;\n3_Sair.");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                if (numeroPacientes >= maxpaciente)
                {
                    Console.WriteLine("Número Máximo de pacientes atingido!");
                    Console.WriteLine("Aperte ENTER para voltar ao menu.");
                    Console.ReadKey();
                }
                else
                {
                   
                    Console.Clear();
                    Console.WriteLine("====CADASTRAR PACIENTE====\n");
                    Console.WriteLine($"Digite as informações do {numeroPacientes + 1}° paciente");
                    Console.WriteLine("\n");
                    Console.Write("Nome: ");
                    meusPacientes[numeroPacientes].Nome = Console.ReadLine();

                    Console.WriteLine("\n");
                    Console.Write("Idade: ");
                    meusPacientes[numeroPacientes].Idade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.Write("Sexo: ");
                    meusPacientes[numeroPacientes].Sexo = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.Write("Cpf: ");
                    meusPacientes[numeroPacientes].Cpf = Console.ReadLine();
                    Console.WriteLine("====TRIAGEM MÉDICA====\n(responda com S/N)\n");
                    Console.Write("Paciente está com Febre? ");
                    meusPacientes[numeroPacientes].Febre = Console.ReadLine().ToUpper() == "S";
                    Console.Write("Está com taquicardia? ");
                    meusPacientes[numeroPacientes].Taquicardia = Console.ReadLine().ToUpper() == "S";
                    Console.Write("Está com taquipneia? ");
                    meusPacientes[numeroPacientes].Taquipneia = Console.ReadLine().ToUpper() == "S";
                    Console.Write("Está com pressão alta? ");
                    meusPacientes[numeroPacientes].PressaoAlta = Console.ReadLine().ToUpper() == "S";
                    Console.Write("Histórico familiar relevante? ");
                    meusPacientes[numeroPacientes].Historico = Console.ReadLine().ToUpper() == "S";
                    numeroPacientes++; // Incrementa o contador de pacientes
                    Console.WriteLine("\nPaciente Cadastrado com sucesso!!");
                    Console.WriteLine("Aperte ENTER para voltar ao menu.");
                    Console.ReadKey();
        
                }
            }

            if (opcao == "2")
            {
                Console.Clear();
                Console.WriteLine("====VER PACIENTES====");
                for (int i = 0; i < numeroPacientes; i++)// vai so mostrar os cara
                {
                    Console.WriteLine($"Paciente {i + 1}:");
                    Console.WriteLine($"Nome: {meusPacientes[i].Nome}");
                    Console.WriteLine($"Idade: {meusPacientes[i].Idade}");
                    Console.WriteLine($"Sexo: {meusPacientes[i].Sexo}");
                    Console.WriteLine($"Cpf: {meusPacientes[i].Cpf}");
                    //aqui vai falar oque o cara tem baseado no que ele respondeu antes
                    if (meusPacientes[i].Febre)
                        Console.WriteLine("Tem febre.");
                    else
                        Console.WriteLine("Não tem febre");
                    if (meusPacientes[i].Taquicardia)
                        Console.WriteLine("Tem taquicardia.");
                    else
                        Console.WriteLine("Não tem taquicardia");
                    if (meusPacientes[i].Taquipneia)
                        Console.WriteLine("Tem taquipneia.");
                    else
                        Console.WriteLine("Não tem taquipneia");
                    if (meusPacientes[i].PressaoAlta)
                        Console.WriteLine("Tem Pressão Alta.");
                    else
                        Console.WriteLine("Não tem Pressão Alta");
                    if (meusPacientes[i].Historico)
                        Console.WriteLine("Tem histórico.");
                    else
                        Console.WriteLine("Não tem histórico");

                    //AVALIAÇÃO MÉDICA

                    //aqui tem alguns dos possiveis diagnosticos e estados de emergencia
                    if (meusPacientes[i].Febre && meusPacientes[i].Taquipneia && meusPacientes[i].Taquicardia && meusPacientes[i].PressaoAlta && meusPacientes[i].Historico)
                        Console.WriteLine("Emergência\n morreu já!");
                    else if (meusPacientes[i].Febre && meusPacientes[i].Taquipneia && meusPacientes[i].Taquicardia && meusPacientes[i].Historico)
                        Console.WriteLine("Emergência!\n Infecção Sistêmica!");
                    else if (meusPacientes[i].Febre && meusPacientes[i].Taquicardia)
                        Console.WriteLine("Pouco Urgente!\n Infecção viral!");
                    else if (meusPacientes[i].Taquipneia && meusPacientes[i].Taquicardia && meusPacientes[i].PressaoAlta && meusPacientes[i].Historico)
                        Console.WriteLine("Muito Urgente!\n Insuficiência Cardíaca ou AVC iminente!");
                    else if (meusPacientes[i].Febre && meusPacientes[i].Taquipneia)
                        Console.WriteLine("Urgente!\n Infecção respiratória!");
                    else if (meusPacientes[i].PressaoAlta && meusPacientes[i].Historico)
                        Console.WriteLine("Urgente!\n Hipertensão arterial descompensada!");
                    else if (meusPacientes[i].Taquicardia && meusPacientes[i].PressaoAlta)
                        Console.WriteLine("Muito Urgente!\n Arritmia ou crise Hipertensiva!");
                    else if (meusPacientes[i].Historico)
                        Console.WriteLine("Não Urgente!\n Risco Genético, Necessidade de prevenção!");
                    else
                        Console.WriteLine("Não Urgente!\n Sem alterações clínicas");

                    Console.WriteLine("========================================================================================================================");


                    Console.WriteLine();
                }
                Console.WriteLine("Aperte ENTER para voltar ao menu.");
                Console.ReadKey();
            }

            if (opcao == "3") //pra encerrar o programa
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA FINALIZADO!");
                Console.ReadKey();
            }

        } while (opcao != "3"); //se o anjo quiser sair, ai fecha
    }
}