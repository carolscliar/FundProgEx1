// Exercicio 5

//class Program
//{
//    static void Main()
//    {
//        int[] numeros = new int[5]; // Cria um array de tamanho 5
//        int soma = 0; // Inicializa a soma como 0

//        // Coletar 5 números do usuário
//        for (int i = 0; i < numeros.Length; i++) // Loop para coletar os números
//        {
//            Console.Write("Digite o número {0}: ", i + 1);
//            numeros[i] = int.Parse(Console.ReadLine()); // Armazena o número no array
//        }

//        // Inicializar o maior e o menor número
//        int maior = numeros[0]; // Inicializa o maior com o primeiro número
//        int menor = numeros[0]; // Inicializa o menor com o primeiro número

//        // Usar foreach para calcular a soma, e encontrar o maior e menor número
//        foreach (int numero in numeros)
//        {
//            soma += numero; // Adiciona o número atual à soma

//            if (numero > maior)
//            {
//                maior = numero; // Atualiza o maior se o número atual for maior
//            }

//            if (numero < menor)
//            {
//                menor = numero; // Atualiza o menor se o número atual for menor
//            }
//        }

//        // Exibir os resultados
//        Console.WriteLine("\nNúmeros inseridos: {0}", string.Join(", ", numeros));
//        Console.WriteLine("Soma: {0}", soma);
//        Console.WriteLine("Maior número: {0}", maior);
//        Console.WriteLine("Menor número: {0}", menor);
//    }
//}














//Exercicio 4

//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Digite o primeiro número: ");
//        double num1 = Convert.ToDouble(Console.ReadLine()); // Converte o input do usuário para double

//        Console.Write("Digite o segundo número: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());


//        Console.Write("Escolha a operação (+, -, *, /): "); // Solicita a operação ao usuário
//        char operacao = Console.ReadLine()[0];  // Pega o primeiro caractere da entrada


//        double resultado = 0;
//        bool operacaoValida = true;

//        switch (operacao)
//        {
//            case '+':
//                resultado = num1 + num2;
//                break;
//            case '-':
//                resultado = num1 - num2;
//                break;
//            case '*':
//                resultado = num1 * num2;
//                break;
//            case '/':
//                if (num2 != 0)
//                {
//                    resultado = num1 / num2;
//                }
//                else
//                {
//                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
//                    operacaoValida = false;
//                }
//                break;
//            default:
//                Console.WriteLine("Operação inválida.");
//                operacaoValida = false;
//                break;
//        }

//        // Passo 4: Exibir o resultado se a operação for válida
//        if (operacaoValida)
//        {
//            Console.WriteLine($"Resultado: {num1} {operacao} {num2} = {resultado}");
//        }
//    }
//}





// Exercício 3

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string senhaCorreta = "2001"; // Definindo a senha correta
//        string inputUser; // Variável para armazenar a senha digitada pelo usuário

//        do // Começo do loop para solicitar a senha ao usuário até que ele acerte
//        {
//            Console.Write("Digite a senha: ");
//            inputUser = Console.ReadLine(); // Lê e armazena a senha digitada pelo usuário

//            if (inputUser != senhaCorreta) // Se a senha digitada for diferente da senha correta
//            {
//                Console.WriteLine("Senha incorreta. Tente novamente.");
//            }

//        } while (inputUser != senhaCorreta); // Fica no loop enquanto a senha digitada for diferente da senha correta

//        Console.WriteLine("Senha correta! Bem-vindo.");
//    }
//}




// Exercício 2

//class Program
//{
//    static void Main(string[] args)
//    {
//        Random aleatorio = new Random(); // Gera um número aleatório
//        int numeroSecreto = aleatorio.Next(1, 11); // Número aleatório entre 1 e 10
//        int palpite; // Palpite do usuário
//        int chances = 0; // Número de tentativas

//        Console.WriteLine("Adivinhe o número secreto entre 1 e 10:"); 

//        do
//        {
//            Console.Write("Seu palpite: "); // Solicita o palpite do usuário
//            palpite = int.Parse(Console.ReadLine()); // Lê o palpite do usuário
//            chances++; // Incrementa por 1 o número de tentativas

//            if (palpite != numeroSecreto) // Se o palpite for diferente do número secreto
//            {
//                Console.WriteLine("Errado, tente novamente!"); // Informa que o palpite está errado
//            }

//        } while (palpite != numeroSecreto); // Fica no loop enquanto o palpite for diferente do número secreto

//        Console.WriteLine("Parabéns! Você acertou o número secreto."); // Informa que o usuário acertou o número secreto
//        Console.WriteLine($"Você tentou {chances} vezes."); // Informa quantas tentativas o usuário fez
//    }
//}




// Exercício 1
//class Program 
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Digite um número inteiro positivo: ");
//        int number = int.Parse(Console.ReadLine());

//        int sum = 0;
//        for (int i = 1; i <= number; i++)
//        {
//            Console.WriteLine(i);
//            sum += i;
//        }

//        Console.WriteLine("A soma de todos os números é: " + sum);
//    }
//}
