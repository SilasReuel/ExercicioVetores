using System;

/*início exercício 1*/
static void MaiorSalario()
{
    
    double [] salarios = new double[10];
    double maior = 0;
    string value;

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"INFORME {i + 1}º SALÁRIO: ");
        salarios[i] = Double.Parse(Console.ReadLine());

        if (salarios[i] <= 0)
        {
            Console.WriteLine("O valor deve ser maior que 0(ZERO)");
            i--;
        }
    }
    Console.WriteLine("==================================");

    for (int i = 0; i < 10; i++)
    {
        if (maior <= salarios[i])
        {
            maior = salarios[i];
        }
    }
    Console.WriteLine($"MAIOR SALÁRIO: {maior}");
    Console.WriteLine("");
}
/*fim exercício 1*/

/*início exercício 2*/
static void ListaSalarios()
{
    double [] salarios = new double[5];
    double [] salarioAtualizado = new double[5];
    for(int i = 0;i < 5; i++)
    {
        Console.WriteLine($"Informe o {i+1}° salário");
        Console.Write("-->>");
        salarios[i]= Double.Parse(Console.ReadLine());
        if (salarios[i] <= 0)
        {
            Console.WriteLine("O valor deve ser maior que 0(ZERO)");
            i--;
        }else if (salarios[i] < 1000 && salarios[i] > 0)
        {
            salarioAtualizado[i] = salarios[i] += salarios[i] * 0.10;
        }
        else
        {
            salarioAtualizado[i] = salarios[i];
        }
    }
    Console.WriteLine("<<<<<<<<<<<<<ATUALIZAÇÃO>>>>>>>>>>>>>");
    for (int i = 0; i<5 ; i++)
    {
        Console.WriteLine($"{i + 1}° salário atualizado: {salarioAtualizado[i]}");
    }
}
/*fim exercício 2*/

/*início exercício 3*/
static void NValores()
{
    int n = 0;
    do
    {
        Console.WriteLine("Quantos valores serão coletados?");
        Console.Write("-->>");
        n = int.Parse(Console.ReadLine());
        if(n < 1)
        {
            Console.WriteLine("Deve ser maior que 0 (ZERO)");
        }
    } while (n<1);
    
    double media = 0;
    double[] valores = new double[n];

    for(int i = 0; i<n ; i++)
    {
        Console.WriteLine($"Digite o {i+1} valor:");
        Console.Write("-->>");
        valores[i] = Double.Parse(Console.ReadLine());
    }
    for(int i = 0; i<n; i++)
    {
        media += valores[i];
    }
    Console.WriteLine($"A média dos valores é: {media/n}");
}
/*fim exercício 3*/

/*início exercício 4*/
static void NotaAlunos()
{
    int qtd = 0;

    do
    {
        Console.WriteLine("Quantidade de alunos");
        Console.Write("-->>");
        qtd = int.Parse(Console.ReadLine());
    } while (qtd<1);

    double[] g1 = new double[qtd];
    double[] g2 = new double[qtd];
    double[] media = new double[qtd];

    for(int i = 0; i<qtd; i++)
    {
        Console.WriteLine($"Digite a 1° nota do {i+1}° aluno:");
        Console.Write("-->>");
        g1[i] = Double.Parse(Console.ReadLine());
        if (g1[i]<0 || g1[i]>10)
        {
            Console.WriteLine("O valor deve ser no Mínimo 0 (ZERO) e no MÁXIMO 10 (DEZ)");
            i--;
        }
    }

    for (int i = 0; i < qtd; i++) { 
    
        Console.WriteLine($"Digite a 2° nota do {i+1}° aluno:");
        Console.Write("-->>");
        g2[i] = Double.Parse(Console.ReadLine());
        if (g1[i] < 0 || g1[i] > 10)
        {
            Console.WriteLine("O valor deve ser no Mínimo 0 (ZERO) e no MÁXIMO 10 (DEZ)");
            i--;
        }
    }

    for( int i = 0; i < qtd; i++)
    {
        media[i] = (g1[i] + g2[i]) / 2;
    }
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<NOTAS>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for (int i=0; i<qtd; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"1° nota do {i + 1}° aluno:");
        Console.WriteLine(g1[i]);
        Console.WriteLine();
        Console.WriteLine($"2° nota do {i + 1}° aluno:");
        Console.WriteLine(g2[i]);
        Console.WriteLine();
        Console.WriteLine($"Média do {i + 1}° aluno:");
        Console.WriteLine(media[i]);
        Console.WriteLine();
    }
}
/*fim exercício 4*/

/*início exercício 5*/
static void ValoresInteiros()
{
    int[] vet1 = new int[5];
    int[] vet2 = new int[5];

    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<COLETA 1>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for ( int i = 0; i<5; i++)
    {
        Console.WriteLine($"Digite o {i+1}° valor inteiro para o 1° vetor");
        Console.Write("-->>");
        vet1[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<COLETA 2>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Digite o {i + 1}° valor inteiro para o 2° vetor");
        Console.Write("-->>");
        vet2[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<SOMA>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for ( int i = 0;i < 5; i++)
    {
        Console.WriteLine($"Soma dos valores na {i + 1}° posição: ");
        Console.WriteLine(vet1[i] + vet2[i]);
        Console.WriteLine();
    }
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<DIFERENÇA>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Diferença dos valores na {i + 1}° posição: ");
        Console.WriteLine(vet1[i] - vet2[i]);
        Console.WriteLine();
    }
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<PRODUTO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Produto dos valores na {i + 1}° posição: ");
        Console.WriteLine(vet1[i] * vet2[i]);
        Console.WriteLine();
    }
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<DIVISÃO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    for (int i = 0; i < 5; i++)
    {
        double divisao = (double)vet1[i] / (double)vet2[i];
        Console.WriteLine($"Divisão dos valores na {i + 1}° posição: ");
        Console.WriteLine(divisao);
        Console.WriteLine();
    }
}

/*fim exercício 5*/

/*início menu*/
int opcao;

do
{
    Console.WriteLine("<<<<<<<<<<<<<MENU>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("Escolha uma das opções:");
    Console.WriteLine("(1) --> Maior salário");
    Console.WriteLine("(2) --> Lista de salários");
    Console.WriteLine("(3) --> Coletar n valores");
    Console.WriteLine("(4) --> Calcular nota dos alunos");
    Console.WriteLine("(5) --> Coletar valores inteiros");
    Console.WriteLine("(0) --> Sair");
    Console.Write(" -->>");
    opcao = int.Parse(Console.ReadLine()); 
    
    if(opcao < 0 || opcao > 5)
    {
        Console.WriteLine("Escolha uma opção válida!!!");
    }else if (opcao == 1)
    {
        MaiorSalario();
    } else if (opcao == 2)
    {
        ListaSalarios();
    }else if (opcao == 3)
    {
        NValores();
    }
    else if (opcao == 4)
    {
        NotaAlunos();
    }
    else if (opcao == 5)
    {
        ValoresInteiros();
    }
} while (opcao != 0);
/*fim menu*/