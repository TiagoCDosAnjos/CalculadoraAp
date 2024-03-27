using ProjetoCalculadora;

string operacao, continuar;
double resultado = 0;
Console.WriteLine();
Calculadora calc = new Calculadora();
do
{
    try
    {
        Console.Clear();
        Console.WriteLine("Deseja fazer Qual operação? \n \n" +

            "Digite [1] para soma \n" +
            "Digite [2] para subtrair \n" +
            "Digite [3] para multiplicar \n" +
            "Digite [4] para Dividir \n");

        operacao = Console.ReadLine();

        Console.Write("Digite o primeiro numero: ");

        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());

        switch (operacao)
        {
            case "1":
                resultado = calc.Soma(num1, num2);
                break;
            case "2":
                resultado = calc.Subtrair(num1, num2);
                break;
            case "3":
                resultado = calc.Multiplicar(num1, num2);
                break;
            case "4":
                do
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("O número digitado não pode ser 0 !");
                        Console.Write("digite outro número: ");
                        num2 = double.Parse(Console.ReadLine());
                    }
                } while (num2 == 0);
                resultado = calc.Dividir(num1, num2);
                break;
            default:
                // código
                break;
        }
        //if (operacao == '1')
        //    resultado = calc.Soma(num1, num2);
        //else if (operacao == '2')
        //    resultado = calc.Subtrair(num1, num2);
        //else if (operacao == '3')
        //    resultado = calc.Multiplicar(num1, num2);
        //else if (operacao == '4')
        //    resultado = calc.Dividir(num1, num2);
        //else
        //    resultado = 0;

        Console.WriteLine("O resultado da operação é: " + resultado);
        Console.WriteLine();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Não é possivel dividir por 0! ");
    }
    catch (Exception e)
    {
        Console.WriteLine("Digite apenas números válidos!");
    }
    Console.Write("Deseja fazer outra operação digite 's' para Sim e 'n' para Não: ");
    continuar = Console.ReadLine();

} while (continuar == "s" || continuar == "S");





