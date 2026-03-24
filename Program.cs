SistemaSorteio sistema = new SistemaSorteio();

bool rodando = true;

while (rodando)
{
    Console.Clear();
    Console.WriteLine("=====Sorteio de Nomes=====");
    Console.WriteLine("\n--Opções--\n");
    Console.WriteLine("1 - Cadastrar Nome");
    Console.WriteLine("2 - Listar Nomes");
    Console.WriteLine("3 - Sortear Nomes");
    Console.WriteLine("0 - Sair\n");
    Console.WriteLine("Insira a opção que deseja:");

    if (!int.TryParse(Console.ReadLine(), out int opcao))
    {
        Console.Clear();
        Console.WriteLine("Insira um valor valido!\n\n");
        Thread.Sleep(1000);
    }
    else
    {
        switch (opcao)
        {
            case 1:
                sistema.cadastrarNome();
                break;
            case 2:
                sistema.listarNomes();
                break;
            case 3:
                sistema.sortearNome();
                break;
            case 0:
                sistema.sair();
                rodando = false;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                break;
        }
    }
}