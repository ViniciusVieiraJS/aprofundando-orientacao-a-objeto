public class Calculadora
{
    public double Calcular(double numero1, double numero2, char operacao)
    {
        Calculadora minhaCalculadora = new Calculadora();
        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = minhaCalculadora.Somar(numero1, numero2);
                break;
            case '-':
                resultado = Subtrair(numero1, numero2);
                break;
            case '*':
                resultado = Multiplicar(numero1, numero2);
                break;
            case '/':
                resultado = Dividir(numero1, numero2);
                break;
            case '^':
                resultado = Potencia(numero1, numero2);
                break;
            case 'r':
                resultado = RaizQuadrada(numero1);
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        return resultado;
    }

    private double Somar(double a, double b)
    {
        Calculadora minhaCalculadora = new Calculadora();
        return a + b;
    }

    private static double Subtrair(double a, double b)
    {
        return a - b;
    }

    private static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    private static double Dividir(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return 0;
        }
    }

    private static double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    private static double RaizQuadrada(double a)
    {
        return Math.Sqrt(a);
    }


}
