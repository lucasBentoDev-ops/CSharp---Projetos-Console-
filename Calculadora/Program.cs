internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    
     static void Menu()
    {
        Console.Clear();
        string titulo = @"█▓▒▒░░░ Calculadora ░░░▒▒▓█";
        string Menssagem = "\n1 - Soma\t2 - Subtração\t3 - Divisão\t4 - Multiplicação\t0 - Sair";
        Console.WriteLine(titulo.PadLeft(Menssagem.Length));
        Console.WriteLine("Escolha uma das operação abaixo:\n" + Menssagem + "\n");
        
        string escolhaDoUsuario = Console.ReadLine()!;
        if(escolhaDoUsuario == string.Empty)
                 Menu();
         
         switch (escolhaDoUsuario)
        {
            case "1":
                Somar();
                break;
            case "2":
                Subtrair();
                break;
            case "3":
                Dividir();
                break;
            case "4":
                Multiplicar();
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                
                Menu(); 
                break;

        }   
      
    }

    static void Somar()
    {
        Console.Clear(); // limpa a tela
        Console.WriteLine("Digite o primeiro valor:");
        double numero1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo valor:");
        double numero2 = double.Parse(Console.ReadLine()!);
        double resultado = numero1 + numero2;
        Console.WriteLine($"A soma de {numero1} + {numero2} = " + resultado);
        Console.ReadKey();
        Menu();
    }

    static void Subtrair()
    {
        Console.Clear(); // limpa a tela
        Console.WriteLine("Digite o primeiro valor:");
        double numero1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo valor:");
        double numero2 = double.Parse(Console.ReadLine()!);
        double resultado = numero1 - numero2;
        Console.WriteLine($"A diferença de {numero1} - {numero2} = " + resultado);
        Console.ReadKey();
        Menu();
    }

    static void Dividir()
    {
        Console.Clear(); // limpa a tela
        Console.WriteLine("Digite o primeiro valor:");
        double numero1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo valor:");
        double numero2 = double.Parse(Console.ReadLine()!);
        double resultado = numero1 / numero2;
        Console.WriteLine($"A divisão de {numero1} / {numero2} = " + resultado);
        Console.ReadKey();
        Menu();

    }

    static void Multiplicar()
    {
        Console.Clear(); // limpa a tela
        Console.WriteLine("Digite o primeiro valor:");
        double numero1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo valor:");
        double numero2 = double.Parse(Console.ReadLine()!);
        double resultado = numero1 * numero2;
        Console.WriteLine($"A Multiplicação de {numero1} X {numero2} = " + resultado);
        Console.ReadKey();
        Menu();

    }
}

