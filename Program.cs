// See https://aka.ms/new-console-template for more information



namespace Calculator
{
    class Program 
    {
        public static void Main(string[] args)
        { 
          Menu();
        }
        
        public static void Menu()
        {
          Console.Clear();
          Console.WriteLine("Olá, o que deseja fazer ? ");
          Console.WriteLine("---------------------------");
          Console.WriteLine("[1] Somar -> +");
          Console.WriteLine("[2] Subtrair -> -");
          Console.WriteLine("[3] Multiplicar -> x");
          Console.WriteLine("[4] Dividir -> / ");
          Console.WriteLine("[5] Sair");
          Console.WriteLine("---------------------------");

          Console.WriteLine("Selecione uma opção: ");
          short res = short.Parse(Console.ReadLine());
          switch (res)
          {
              case 1:
                Soma();
                break;
              case 2:
                Subtracao();
                break;
              case 3:
                Multiplicacao();
                break;
              case 4:
                Divisao();
                break;
              case 5:
                Console.WriteLine("Saindo do programa, obrigado por utilizar!!");
                System.Environment.Exit(0);
                break;
              default:
                Console.WriteLine("Digite a operção correta: ");
                Menu();
                break;
          }


        }
        public static void Soma()
        {
          float valor1;
          float valor2;
          Console.Clear();
          Console.Write("Digite o primeiro valor: ");
          valor1 = float.Parse(Console.ReadLine());

          Console.Write("Digite O segundo numero: ");

          valor2 = float.Parse(Console.ReadLine());

          float resultado = valor1 + valor2;
          Console.WriteLine($"O resultado da soma é : {resultado}");
          Console.WriteLine("Digite qualquer tecla para continuar"); 
          Console.ReadKey(); 
          Menu();
        }

        public static void Subtracao()
        {
          Console.Clear();
          float valor1;
          float valor2;
          float resultado;

          Console.Write("Digite o primeiro valor: ");
          valor1 = float.Parse(Console.ReadLine());
          
          Console.Write("Digite o segundo valor: ");
          valor2 = float.Parse(Console.ReadLine());
          
          resultado = valor1 - valor2;


          Console.WriteLine($"O resultado da subtração é : {resultado}");
          Console.WriteLine("Digite qualquer tecla para continuar");
          Console.ReadKey();
          Menu();
        }

        public static void Divisao()
        {
          Console.Clear();

          float valor1;
          float valor2;
          float resultado;

          Console.Write("Digite o primeiro valor: ");
          valor1 = float.Parse(Console.ReadLine());
          

          Console.Write("Digite o segundo valor: ");
          valor2 = float.Parse(Console.ReadLine());
          
          resultado = valor1/valor2;


          Console.WriteLine($"O resultado da divisão é:{resultado}");
          Console.WriteLine("Digite qualquer tecla para continuar");

          Console.ReadKey();

          Menu();

        }

        public static void Multiplicacao()
        {
          Console.Clear();
          float valor1;
          float valor2;
          float resultado;

          Console.Write("Digite o primeiro valor: ");
          valor1 = float.Parse(Console.ReadLine());


          Console.Write("Digite o segundo valor: ");
          valor2 = float.Parse(Console.ReadLine());


          resultado = valor1 * valor2;


          Console.WriteLine($"O resultado da multiplicação é: {resultado}");

          Console.WriteLine("Digite qualquer tecla para continuar");
          Console.ReadKey();

          Menu();
        }
        
    }
}



