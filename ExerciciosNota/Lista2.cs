using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosNota
{
    internal class Lista2
    {
        public void exercicio1()
        {
            // Declaração da variável para armazenar o número
            int numero;

            // Solicita ao usuário que digite um número
            Console.WriteLine("Digite um número:");

            // Lê o número digitado pelo usuário e converte para inteiro
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Verifica se o número é maior que 20
                if (numero > 20)
                {
                    // Imprime o número se a condição for verdadeira
                    Console.WriteLine("O número " + numero + " é maior que 20.");
                }
            }
            else
            {
                // Mensagem de erro caso o usuário não digite um número válido
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");

            }


        }



        public void exercicio2()
        {
            // Declaração da variável para armazenar o número
            int numero;

            // Solicita ao usuário que digite um número
            Console.WriteLine("Digite um número:");

            // Lê o número digitado pelo usuário e converte para inteiro
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Verifica se o número é maior que 10
                if (numero > 10)
                {
                    Console.WriteLine("É MAIOR QUE 10!");
                }
                else
                {
                    Console.WriteLine("NÃO É MAIOR QUE 10!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }


        }

        public void exercicio3()
        {
            // Declaração das variáveis
            int A, B, C, soma;

            // Solicita ao usuário que digite os valores
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());


            // Calcula a soma de A e B
            soma = A + B;

            // Compara a soma com C e imprime o resultado
            if (soma < C)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B NÃO é menor que C.");







            }

        }


        public void exercicio4()
        {
            // Declaração das variáveis
            int numero1, numero2, soma;

            // Solicita os números ao usuário
            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());


            // Calcula a soma
            soma = numero1 + numero2;

            // Verifica se a soma é maior que 10 e imprime o resultado
            if (soma > 10)
            {
                Console.WriteLine("A soma é: " + soma);
            }


        }

        public void exercicio5()
        {
            string nome, sexo, estadoCivil;
            int tempoCasada = 0;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sexo (M/F): ");
            sexo = Console.ReadLine().ToUpper(); // Converte para maiúsculas para facilitar a comparação

            Console.Write("Digite seu estado civil (SOLTEIRA, CASADA, DIVORCIADA): ");
            estadoCivil = Console.ReadLine().ToUpper();

            if (sexo == "F" && estadoCivil == "CASADA")
            {
                Console.Write("Digite o tempo de casada (em anos): ");
                tempoCasada = int.Parse(Console.ReadLine());
                Console.WriteLine($"{nome} é casada há {tempoCasada} anos.");
            }
            else
            {
                Console.WriteLine($"Dados de {nome} registrados.");

            }



        }

        public void exercicio6()
        {

            int numero;

            Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número {0} é par.", numero);
                }
                else
                {
                    Console.WriteLine("O número {0} é ímpar.", numero);
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }



        }


        public void exercicio7()
        {
            int A, B, C;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());


            if (A == B)
            {
                // Se A e B são iguais, soma-se os valores
                C = A + B;
                Console.WriteLine("A soma de A e B é: " + C);
            }
            else
            {
                // Se A e B são diferentes, multiplica-se os valores
                C = A * B;
                Console.WriteLine("A multiplicação de A por B é: " + C);
            }



        }


        public void exercicio8()
        {

            int numero, resultado;

            Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero > 0)
                {
                    // Número positivo: calcula o dobro
                    resultado = numero * 2;
                    Console.WriteLine("O dobro de {0} é: {1}", numero, resultado);
                }
                else if (numero < 0)
                {
                    // Número negativo: calcula o triplo
                    resultado = numero * 3;
                    Console.WriteLine("O triplo de {0} é: {1}", numero, resultado);
                }
                else
                {
                    // Número zero
                    Console.WriteLine("O número é zero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }




        }

        public void exercicio9()
        {
            int num1, num2, num3, aux;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            // Ordenação utilizando o método de troca
            if (num1 < num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }

            if (num1 < num3)
            {
                aux = num1;
                num1 = num3;
                num3 = aux;
            }

            if (num2 < num3)
            {
                aux = num2;
                num2 = num3;
                num3 = aux;
            }

            Console.WriteLine("Os números em ordem decrescente são: ");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

        }


        public void exercicio10()
        {

            int num1, num2, num3, aux;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            // Ordenação utilizando o método de troca
            if (num1 > num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }

            if (num1 > num3)
            {
                aux = num1;
                num1 = num3;
                num3 = aux;
            }

            if (num2 > num3)
            {
                aux = num2;
                num2 = num3;
                num3 = aux;
            }

            Console.WriteLine("Os números em ordem crescente são: ");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }



        public void exercicio11()
        {
            int horaInicio, horaFim, duracao;

            Console.Write("Digite a hora de início do jogo: ");
            horaInicio = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora de fim do jogo: ");
            horaFim = int.Parse(Console.ReadLine());

            // Calcula a duração, considerando a possibilidade de passar da meia-noite
            duracao = horaFim - horaInicio;
            if (duracao < 0)
            {
                duracao += 24; // Adiciona 24 horas se o jogo passou da meia-noite
            }

            Console.WriteLine("A duração do jogo foi de {0} horas.", duracao);

            // Verifica se a duração está dentro do limite, faltando tempo ou excedendo
            if (duracao == 24)
            {
                Console.WriteLine("O jogo durou exatamente 24 horas.");
            }
            else if (duracao < 24)
            {
                Console.WriteLine("Faltam {0} horas para completar 24 horas.", 24 - duracao);
            }
            else
            {
                Console.WriteLine("O jogo excedeu em {0} horas o limite de 24 horas.", duracao - 24);
            }



        }
    
























        

    }
}
