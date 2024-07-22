  // Minha primeira aplicação com C# 10/06/2024
 
 // Conhecimentos abordados:  Operadores aritiméticos, Caracteres de escape, 
 //interpolação,concatenação, conversão explícita, e tipos de dados.

 //Proposta da aplicação: Alocar na memória cinco notas de cada aluno (Sofia,Nicolas,Carlos,jorge).
 // calcular a média das notas e mostrar o resutado em um formato adequado. 


internal class Program

{       
         
    private static void Main(string[] args)
    {
        Console.Clear();
        // Recebe a soma das notas dos respectivos alunos.
        int sofiaSum = 0;
        int nicolasSum = 0;
        int carlosSum = 0;
        int jorgeSum = 0;
     
      // Conjunto de notas de cada aluno e a soma do conjuto..
        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;
        sofiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;
        nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;

        int carlos1 = 84;
        int carlos2 = 96;
        int carlos3 = 73;
        int carlos4 = 85;
        int carlos5 = 79;
        carlosSum = carlos1 + carlos2 + carlos3 + carlos4 + carlos5;

        int jorge1 = 90;
        int jorge2 = 92;
        int jorge3 = 98;
        int jorge4 = 100;
        int jorge5 = 97;
        jorgeSum = jorge1 + jorge2 + jorge3 + jorge4 + jorge5;
        
        // Realiza a média o cálculo da média dos alunos e mostra a resposta formatada. 
        Console.WriteLine(" Studant  \tGrade\n");
        Console.WriteLine($" Sofia  \t{(double)sofiaSum / 5}   \tA");
        Console.WriteLine($" Nicolas \t{(double)nicolasSum / 5}  \tB");
        Console.WriteLine($" Carlos \t{(double)carlosSum / 5}  \tB");
        Console.WriteLine($" jorge   \t{(double)jorgeSum / 5}  \tA");




   }

}     

       




