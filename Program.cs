using System;

namespace ExercicioSENAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola, Bem-Vindo ao sistema de validacao de eleitor 2020 \n Para saber se voce podera votar nessas eleicoes, insira sua idade");
            int idade = 0;
            idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine($"Otimo, voce ja possui {idade} anos e portanto ja pode votar!");
            }else{
                Console.WriteLine($"Infelizmente voce so possui {idade} anos e portanto nao podera votar nessas eleicoes");
            }
        }
    }
}
