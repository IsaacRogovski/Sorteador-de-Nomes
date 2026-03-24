class SistemaSorteio
{
    public List<string> nomes = new List<string>();
    public Random random = new Random();

    public void cadastrarNome()
    {
        bool isNomeInserido = false;
        while (!isNomeInserido)
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada: Cadastrar nome");
            Console.WriteLine("Digite o nome a ser cadastrado:");
            string? nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nome))
            {
                Console.Clear();
                nomes.Add(nome);
                Console.WriteLine($"{nome} foi adicionado ao sistema");
                Console.WriteLine("Deseja cadastrar outro nome? (S/N):");
                string? simOuNao = Console.ReadLine();

                if (simOuNao?.ToLower() == "s")
                {
                    Console.Clear();
                }
                else
                {
                    isNomeInserido = true;
                    Console.Clear();
                    Console.WriteLine("Voltando ao Inicio..");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Insira um valor valido!");
                Thread.Sleep(1000);
            }
        }
    }

    public void listarNomes()
    {
        Console.Clear();
        Console.WriteLine("Opção selecionada: Listar nomes inseridos: \n");
        int i = 1;
        foreach (string nome in nomes)
        {
            Console.WriteLine($"{i} - {nome}");
            i++;
        }
        Console.WriteLine("\nPressione enter para voltar ao Inicio:");
        Console.Read();
    }

    public void sortearNome()
    {
        Console.Clear();
        if (nomes.Count != 0)
        {
            bool sorteioRodando = false;
            while (!sorteioRodando)
            {
                Console.Clear();
                Console.WriteLine("Opção selecionada: Sortear Nomes \n");
                int i = random.Next(0, nomes.Count);
                Console.WriteLine($"Nome sorteado: {nomes[i]}\n");
                Console.WriteLine("Deseja sortear outro nome? (S/N):");
                string? simOuNao = Console.ReadLine();

                if (simOuNao != null && simOuNao.Length == 1 && simOuNao.ToLower() == "s")
                {

                    Console.WriteLine("Deseja retirar o nome sorteado? (S/N):");
                    simOuNao = Console.ReadLine();

                    if (simOuNao != null && simOuNao.Length == 1 && simOuNao.ToLower() == "s")
                    {
                        if (nomes.Count <= 2)
                        {
                            Console.WriteLine("A quantidade de nomes adicionados é o limite para o funcionamento do sorteio.");
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            nomes.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    sorteioRodando = true;
                    Console.Clear();
                    Console.WriteLine("Voltando ao Inicio..");
                    Thread.Sleep(1000);
                }
            }
        }
        else
        {
            Console.WriteLine("Insira ao menos 2 nomes antes de sortear!");
            Thread.Sleep(1500);
        }
    }

    public void sair()
    {
        Console.Clear();
        Console.WriteLine("\nSAINDO\n");
    }

}