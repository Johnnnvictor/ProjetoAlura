// Screen SOUND - Projeto alura

using System.Runtime;
using System.Runtime.InteropServices;

string mensagemDeBoasVindas = "Bem vindos ao Screen Sound!";
//List<string> listaDasBandas = new List<string>();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine("𝕊𝕔𝕣𝕖𝕖𝕟 𝕊𝕠𝕦𝕟𝕕");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para listar as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite 0 para sair.");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
        break;
        case 2: ListarBandas();
        break;
        case 3: AvaliarBanda();
        break;
        case 4: ExibirMediaBandas();
        break;
        case 0: Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
        break;
        default: Console.WriteLine("Você digitou uma opção inválida.");
        break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas.");
    Console.Write("Informe o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi adicionada.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista das bandas registradas.");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}.");
    }
    Console.WriteLine("Aperte uma tecla qualquer para retornar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
    // verificar se a banda informada existe dentro da lista
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar bandas.");
    Console.Write("Informe o nome da Banda que você quer avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Informe a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada para a banda {nomeDaBanda}.");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();

    }
    else
    {
        Console.WriteLine("\nA banda informada não foi encontratada!");
        Console.WriteLine("Aperte uma tecla para retornar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }


}

void ExibirMediaBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média das avaliações das Bandas");
    Console.Write("Informe o nome da Banda que você quer verificar a média de avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaAvaliacao = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"A média da Banda {nomeDaBanda} é: {mediaAvaliacao}.");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine("\nA banda informada não foi encontratada!");
        Console.WriteLine("Aperte uma tecla para retornar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}
// Isso é apenas visual, para criar uma linha formada por asteriscos 
// com o mesmo tamanho do nome da função quando selecionada
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");
}

ExibirMenu();







