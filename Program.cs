Console.WriteLine("bem vindo a calculadora basica em .NET, faremos operacoes bsicas com dois numeros dentro do console!");

bool end = false;

while (end == false)
{
    Console.WriteLine("digite a operacao desejada");
    Console.WriteLine("1 - soma, 2- subtracao, 3- divisao e 4- multiplicacao");
    int operation = Convert.ToInt32(Console.ReadLine());
    if (operation != 1 & operation != 2 & operation !=3 & operation != 4)
    {
        Console.WriteLine("selecione uma operacao valida");
    }
    else
    {
        end = true;
    }
    Console.WriteLine("digite o primeiro valor");

    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("digite o segundo valor");

    double num2 = Convert.ToDouble(Console.ReadLine());
    Nullable <double> result = null;

    switch (operation)
    {
        case 1:
            result = num1 + num2;
            Console.WriteLine("o resultado da soma e de: " + result);
        break;
        case 2:
            result = num1 - num2;
            Console.WriteLine("o resultado da subtracao e de: " + result);
        break;       
        case 3:
            result = num1 / num2;
            Console.WriteLine("o resultado da divisao e de: " + result);
        break;       
        case 4:
            result = num1 * num2;
            Console.WriteLine("o resultado da multiplicacao e de: " + result);
        break;
    }
    Console.WriteLine("deseja realizar outra operacao?");
    Console.WriteLine("1 - sim e 2 - nao");
    int keep = Convert.ToInt32(Console.ReadLine());

    if(keep == 1)
    {
        end = false;
    }
}