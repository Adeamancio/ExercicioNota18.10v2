using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosNota
{
    internal class Lista4
    {
        public void exercicio1() 
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());


            // Verifica se o número é par (divisível por 2)
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }



        }


        public void exercicio2() 
        {

            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else if (idade >= 18 && idade <= 64)
            {
                Console.WriteLine("Você é um adulto.");
            }
            else if (idade >= 65)
            {
                Console.WriteLine("Você é um idoso.");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }



        }

        public void exercicio3()
        {
            double nota;

            Console.Write("Digite a nota do aluno (0 a 10): ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 4 && nota < 6)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }


        }

        public void exercicio4()
        {
            double peso, altura, imc;

            Console.Write("Digite seu peso em kg: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());

            // Cálculo do IMC
            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Sobrepeso.");

            }
            else

            {
                Console.WriteLine("Obesidade.");
            }



        }

        public void exercicio5()
        {
            int numero1, numero2;

            Console.Write("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número é maior.");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("O segundo número é maior.");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }



        }


        public void exercicio6()
        {
            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade>= 18 && idade <= 70)
            {
                Console.WriteLine("Voto obrigatório.");
            }
            else if ((idade >= 16 && idade <= 17) || idade > 70)
            {
                Console.WriteLine("Voto facultativo.");
            }
            else
            {
                Console.WriteLine("Não pode votar.");
            }


        }

        public void exercicio7()
        {
            double valorCompra, valorDesconto, valorFinal;

            Console.Write("Digite o valor da compra: R$ ");
            valorCompra = double.Parse(Console.ReadLine());

            // Verifica se o valor da compra é maior que R$100
            if (valorCompra > 100)
            {
                // Calcula o desconto de 10%
                valorDesconto = valorCompra * 0.1;
                valorFinal = valorCompra - valorDesconto;

                Console.WriteLine("Você tem direito a um desconto de R$ " + valorDesconto.ToString("F2"));
                Console.WriteLine("O valor final da compra é R$ " + valorFinal.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Não há desconto para este valor.");
            }


        }


        public void exercicio8()
        {

            double temperatura;

            Console.Write("Digite a temperatura em graus Celsius: ");
            temperatura = double.Parse(Console.ReadLine());

            if (temperatura < 15)
            {
                Console.WriteLine("Está frio.");
            }
            else if (temperatura >= 15 && temperatura <= 25)
            {
                Console.WriteLine("Está agradável.");
            }
            else
            {
                Console.WriteLine("Está quente.");
            }


        }

        public void exercicio9()

        {
            double nota1, nota2, nota3, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());


            // Cálculo da média
            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média é: " + media.ToString("F2"));

            if (media > 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }



        }


        public void exercicio10()
        {
            int ano;

            Console.Write("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine("O ano {0} é bissexto.", ano);
            }
            else
            {
                Console.WriteLine("O ano {0} não é bissexto.", ano);

            }


        }


















    }
}
