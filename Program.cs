// See https://aka.ms/new-console-template for more information
double first, second, result;
char sign, agree = 'y';
double memory = 0;
while (agree != 'n')
{
    Console.WriteLine("Введите первое число");
first = Convert.ToSingle(Console.ReadLine());
while (first >= 1000000000)
{
    Console.WriteLine("Введите меньше 1.000.000.000");
    first = Convert.ToSingle(Console.ReadLine());
}

first = Math.Round(first, 1);

Console.WriteLine("Введите второе число");
second = Convert.ToSingle(Console.ReadLine());
while (second >= 1000000000)
{
    Console.WriteLine("Введите число меньше 1.000.000.000");
    second = Convert.ToSingle(Console.ReadLine());
}

second = Math.Round(second, 1);

Console.WriteLine("Введите операцию");
sign = Convert.ToChar(Console.ReadLine());
    switch (sign)
    {
        case '+':
            result = first + second;
            Console.WriteLine("Сумма ваших чисел: " + result);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = result;
            break;

        case '-':
            result = first - second;
            Console.WriteLine("Разность ваших чисел: " + result);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = result;
            break;

        case '*':
            result = first * second;
            Console.WriteLine("Произведение ваших чисел: " + result);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = result;
            break;

        case '/':
            if (second == 0)
            {
                Console.WriteLine("Делить на 0 нельзя!");
                Console.WriteLine("Вы хотите продолжить? [y/n]");
                agree = Convert.ToChar(Console.ReadLine());
                break;
            }
            result = first / second;
            Console.WriteLine("Частное ваших чисел: " + result);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = result;
            break;

        case '%':
            if (second == 0)
            {
                Console.WriteLine("Остаток от деления на 0 равен самому числу" + first);
                Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            }
            result = first % second;
            Console.WriteLine("Остаток от деления ваших чисел равен " + result);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = result;
            break;

        case 'x':
            if (first == 0)
            {
                Console.WriteLine("Делить на ноль нельзя!");
                Console.WriteLine("Вы хотите продолжить? [y/n]");
                agree = Convert.ToChar(Console.ReadLine());
            }
            result = 1 / first;
            Console.WriteLine("1/" + first + " равно: " + result);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = result;
            break;

        case '^':
            result = first * first;
            Console.WriteLine(first + "^2 равно: " + result);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = result;
            break;

        case 's':
            double res = Math.Sqrt(first);
            Console.WriteLine("Результат: " + res);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            memory = res;
            break;

        case 'M':
            Console.WriteLine("Введите число: ");
            float third = Convert.ToSingle(Console.ReadLine());
            memory += third;
            Console.WriteLine("Результат M+: " + memory);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            break;

        case 'm':
            Console.WriteLine("Введите число: ");
            third = Convert.ToSingle(Console.ReadLine());
            memory -= third;
            Console.WriteLine("Результат M-: " + memory);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            break;

        case 'r':
            Console.WriteLine(memory);
            Console.WriteLine("Вы хотите продолжить? [y/n]");
            agree = Convert.ToChar(Console.ReadLine());
            break;
    }
}

