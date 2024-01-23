using System.Data;



string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
// List<string> listaDasBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;

        case 2: MostrarBandasRegistradas();
            break;

        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case -1: Console.WriteLine("Programa encerrado com sucesso. Até mais.");
            break;

        default: Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    
    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //    Console.WriteLine($"Banda {i + 1}: {listaDasBandas[i]}");
    // }
    

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao (string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}





/*  AQUIII */



/*
Console.Write("Digite o primeiro número: ");
int primeiroNumero = int.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
int segundoNumero = int.Parse(Console.ReadLine()!);

void Operacoes()
{
    Console.WriteLine($"A soma entre {primeiroNumero} e {segundoNumero} é {primeiroNumero + segundoNumero}");
    Console.WriteLine($"A subtração entre {primeiroNumero} e {segundoNumero} é {primeiroNumero - segundoNumero}");
    Console.WriteLine($"A multiplicação entre {primeiroNumero} e {segundoNumero} é {primeiroNumero * segundoNumero}");
    Console.WriteLine($"A divisão entre {primeiroNumero} e {segundoNumero} é {primeiroNumero / segundoNumero}");
}

Operacoes();


List<int> listaDeNumeros = new List<int>();
listaDeNumeros.Add(1);
listaDeNumeros.Add(10);
listaDeNumeros.Add(100);
listaDeNumeros.Add(1000);
listaDeNumeros.Add(10000);
int soma = 0;

void SomarNumerosDaLista ()
{
    for (int i = 0; i < listaDeNumeros.Count; i++)
    {
        soma = soma + listaDeNumeros[i];
    }
    Console.WriteLine(soma);
}
SomarNumerosDaLista();
*/





















/*
Console.Write("Digite a nota do aluno: ");
int notaMedia = int.Parse(Console.ReadLine()!);

if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação.");
}
else
{
    Console.WriteLine("Aluno em recuperação.");
}















string curso = "Curso de C#";
string nome = "Mateus";
string sobrenome = "Ramgund";
Console.WriteLine($"O aluno do curso " + curso + " se chama " + nome + " " + sobrenome);
*/