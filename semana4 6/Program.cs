//Console.WriteLine("NUMEROS PARES");
//int x = 2;
//while (x <= 10)
//{
//    Console.WriteLine(x);
//    x += 2;

//}



//Console.WriteLine("Suma de numeros naturales");
//int re = 0;
//for (int x= 1; x <=10; x++) 
//{
//   re +=x;
//}

//Console.WriteLine($"La suma es :" + re);


//Console.WriteLine("HASTA ENCONTRAR EL NEGATIVO Y SU SUMA/n");
//int suma = 0; int numero;
//do
//{
//    Console.Write("Ingrese un número: "); numero = Convert.ToInt32(Console.ReadLine());
//    if (numero >= 0)
//    {
//        suma += numero;
//    }
//} while (numero >= 0);
//Console.WriteLine($"La suma de los números ingresados es: {suma}");


Console.WriteLine("El primer numero entero positivo divisible entre 7 y 11/n"); int n = 1;
while (true)
{
    if (n % 7 == 0 && n % 11 == 0)
    {
        Console.WriteLine($"El primer número entero positivo divisible entre 7 y 11 es: {n}"); break;
    }
    n++;
}