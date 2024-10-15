using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosNota
{
    internal class Lista1
    {
        public void exercicio1()

        {
            Console.WriteLine("Hello World !!!");
            Console.ReadLine();
            Console.ReadKey();

        }


        public void exercicio2()
        {
            //Pedir o nome do usuário
            Console.WriteLine("Qual é o seu nome?    \n");
            string nome = Console.ReadLine();


            // Mostrar a mensagem de boas-vindas
            Console.WriteLine($"Olá {nome}, é um prazer te conhecer!  \n");

        }

        public void exercicio3()

        {
            string nomeFuncionario;
            double salario;
            string mesAtual = "Outubro";

            // Entrada de dados
            Console.WriteLine("Nome do funcionário: ");
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Salário:  R$ ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário {nomeFuncionario} tem um salário de R${salario:F2} em {mesAtual}.");



        }
       
        public void exercicio4()

        {
            //Declaração das variáveis
            int numero1, numero2, resultado;

            //Entrada de dados
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            numero2 = Convert.ToInt32(Console.ReadLine()); 

            // processamento
            resultado = numero1 + numero2;

            // saída

            Console.WriteLine("A soma entre " + numero1 + " e " + numero2 + " é igual a " + resultado + ".");  
                 
                
        }

        public void exercicio5()
        {
            //Declaração das variáveis
            int numero, antecessor, sucessor;

            // entrada dos dados
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());



            //Processador

            antecessor = numero - 1;
            sucessor = numero + 1;

            //Saída
            Console.WriteLine($"O antecessor de {numero} é {antecessor}");
            Console.WriteLine($"O sucessor de {numero} é {sucessor}");


        }

        public void exercicio6()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.WriteLine($"O antecessor de {numero} é {antecessor}");
            
            Console.WriteLine($"O sucessor de {numero} é {sucessor}");


        }





        public void exercicio7()
        {
            Console.WriteLine("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double doblo = numero * 2;
            double tercaParte = numero / 3;

            Console.WriteLine($"O dobro de {numero} é {doblo}");
            Console.WriteLine($" A terça parte de {numero} é {tercaParte}");

        }



        public void exercicio8()
        {
            Console.WriteLine("Digite uma distância em metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());

            // Conversões
            double km = metros / 1000;
            double hm = metros / 100;
            double dam = metros / 10;
            double dm = metros * 10;
            double cm = metros * 100;
            double mm = metros * 1000;

            // saída formatada

            Console.WriteLine($"A distância de {metros}m corresponde a:");
            Console.WriteLine($"{km:F5}Km");
            Console.WriteLine($"{hm:F4}Hm");
            Console.WriteLine($"{dam:F3}Dam");
            Console.WriteLine($"{dm:F1}dm");
            Console.WriteLine($"{cm:F1}cm");
            Console.WriteLine($"{mm:F1}mm");


        }

        public void exercicio9()
        {
            // Taxa de câmbio atual
            double taxaDeCambio = 5.58;

            //Solicita o valor em reais
            Console.WriteLine("Digite o valor em reais: R$ ");
            double valorEmReais = Convert.ToDouble(Console.ReadLine());

            //calcula o valor em dólares
            double valorEmDolares = valorEmReais / taxaDeCambio;

            // Exibe o resultado
            Console.WriteLine($"Você pode comprar US$ {valorEmDolares:F2}.");


        }


        public void exercicio10()
        {
           
                Console.WriteLine("Digite a largura da parede (em metros): ");
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a altura da parede (em metros): ");
                double altura = Convert.ToDouble(Console.ReadLine());

                // Calculando a área da parede
                double area = largura * altura;

                // Calculando a quantidade de tinta necessária (considerando que 1 litro pinta 2m²)
                double quantidadeTinta = area / 2;

                Console.WriteLine("A área a ser pintada é de " + area + " m².");
                Console.WriteLine("A quantidade de tinta necessária é de " + quantidadeTinta + " litros.");
           

        }
    
    }



}

















