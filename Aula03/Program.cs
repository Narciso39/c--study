namespace Aula02;

public class Program
{
    public static void Main()
    {
        int number1 = 10;

        Console.WriteLine("Valor inicial da variavel: " + number1);

        number1 = 20;

        Console.WriteLine("Valor alterado da variavel: " + number1);

        number1 = number1 + 5;

        Console.WriteLine("Valor da variavel após soma: " + number1);

        // constantes exemplos

        const int myAge = 23;

        Console.WriteLine("Minha idade é: " + myAge);
        // myAge = 24; // erro, não é possível alterar o valor de uma constante

        var variable = "Olá, mundo!"; //tipo definido e verificado em tempo de compilação.

        Console.WriteLine(variable);

        dynamic dynamicVariable = "Olá, mundo!"; //tipo definido em tempo de execução, pode ser alterado.

        Console.WriteLine(dynamicVariable);

        dynamicVariable = 123; // alterando o tipo da variável dinâmica

        Console.WriteLine(dynamicVariable);

        object value = "Felipe"; // Tipo mais generico, mas tem que converter para poder fazer manipulações específicas.

        Console.WriteLine(value); // passa e printa

        //  value.ToUpper(); erro, não é possível chamar o método ToUpper() diretamente em um objeto do tipo object

        string convertedValue = (string)value; // convertendo o objeto para string

        Console.WriteLine(convertedValue.ToUpper()); // agora é possível chamar o método ToUpper() após a conversão para string
    }
}