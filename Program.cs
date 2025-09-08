// Projeto de Avaliação (Revisado) - Variante 3: Cálculo de média de três notas
// Este programa deve solicitar o nome do estudante e três notas, calcular e exibir a média.

using System;

class Program
{
    public static void Main(String[] args)
    {
        Console.Write(" Digite o nome do estudante:\n\t- ");
        String nome = Console.ReadLine();
        
        double soma = 0;
        for (int count = 1; count < 4; count++)
        {
            Console.Write(" Digite a {0}ª nota:\n\t- ", count);
            double nota = double.Parse(Console.ReadLine());

            soma = soma + nota;
        }

        double media = soma / 3;
        Console.WriteLine(" A média do estudante {0} é {1}", nome, media);

        // impedir fechamento automático do console
        Console.Write("\n Aperte Enter para finalizar o programa");
        Console.ReadLine();
    }
}