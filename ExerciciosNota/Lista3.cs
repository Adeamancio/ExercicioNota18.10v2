using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosNota
{
    internal class Lista3
    {
        public void exercicio1()

        {
            int valor1, valor2, valor3, soma;

            Console.Write("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());


            soma = valor1 + valor2 + valor3;

            Console.WriteLine("A soma dos valores é: " + soma);

        }


        public void exercicio2()
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;


            Console.WriteLine("A média é: " + media);



        }

        public void exercicio3()
        {
            string nome;

            do
            {
                Console.Write("Digite um nome (digite 'João' para parar): ");
                nome = Console.ReadLine();
            } while (nome != "João");

            Console.WriteLine("Você digitou João. O programa será encerrado.");



        }


        public void exercicio4()

        {
            int inicio = 35;
            int fim = 98111;
            int contadorPares = 0;

            // Verificamos se o número inicial é par, se for, já contamos ele
            if (inicio % 2 == 0)
            {
                contadorPares++;
            }

            // Iteramos de número em número, incrementando o contador dos pares
            for (int i = inicio + 1; i <= fim; i += 2)
            {
                contadorPares++;
            }

            Console.WriteLine("A quantidade de números pares entre {0} e {1} é: {2}", inicio, fim, contadorPares);

        }


        public void exercicio5()
        {
            int inicio = 35;
            int fim = 98111;
            int contadorPares = 0;

            // Verificamos se o número inicial é par, se for, já contamos ele
            if (inicio % 2 == 0)
            {
                contadorPares++;
            }

            // Iteramos de número em número, incrementando o contador dos pares
            for (int i = inicio + 1; i <= fim; i += 2)
            {
                contadorPares++;
            }

            Console.WriteLine("A quantidade de números pares entre {0} e {1} é: {2}", inicio, fim, contadorPares);

        }

        public void exercicio6()
        {
            int numero, resultado;

            Console.Write("Digite um número para ver sua tabuada: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTabuada do " + numero);
            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }




        }





































    }
}
