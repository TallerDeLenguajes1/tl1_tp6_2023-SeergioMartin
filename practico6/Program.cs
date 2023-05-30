// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
int a; 
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

// EJERCICIO 1
/*
int num = 0;
int digito;
int invertido = 0;
bool resultado = false;
while (!resultado){
    System.Console.WriteLine("Ingrese un numero:");
    string? numero = Console.ReadLine();
    resultado = int.TryParse(numero, out num);
    if (!resultado){
        System.Console.WriteLine("Numero ingresado no valido!");
    }
}
if (num > 0)
{
    while(num != 0)
    {
       digito = num % 10;
       num = num / 10;
       invertido = invertido * 10 + digito;
    }
    System.Console.WriteLine("Numero Invertido: " + invertido);
}
*/

// EJERCICIO 2 y 3
/*
string? cadena;
double valorAbsoluto, cuadrado, raizCuadrada, seno, coseno, parteEntera, maximo, minimo;
int opcion = 0, otra = 0;
float num1, num2, resultado = 0;
bool valido = false;
do
{
    if (otra != 1)
    {
        System.Console.WriteLine("**********MENU**********");
        System.Console.WriteLine("1. Sumar");
        System.Console.WriteLine("2. Restar");
        System.Console.WriteLine("3. Multiplicar");
        System.Console.WriteLine("4. Dividir");
        System.Console.WriteLine("5. Operaciones Avanzadas");
        System.Console.WriteLine("6. Salir");
        System.Console.WriteLine("************************");
        System.Console.WriteLine("--Seleccione una opcion:");
        cadena = Console.ReadLine();
        int.TryParse(cadena, out opcion);
    }
    switch (opcion)
    {
        case 1:
            num1 = Numeros();
            num2 = Numeros();
            resultado = num1 + num2;
            break;
        case 2:
            num1 = Numeros();
            num2 = Numeros();
            resultado = num1 - num2;
            break;
        case 3:
            num1 = Numeros();
            num2 = Numeros();
            resultado = num1 * num2;
            break;
        case 4: 
            num1 = Numeros();
            num2 = Numeros();
            if (num2 != 0)
            {
                resultado = num1 / num2;
            }else
            {
                System.Console.WriteLine("No se puede dividir un numero en 0!");
            }
            break;
        case 5:
            num1 = Numeros();
                valorAbsoluto = Math.Abs(num1);
                cuadrado = Math.Pow(num1, 2);
                raizCuadrada = Math.Sqrt(num1);
                seno = Math.Sin(num1);
                coseno = Math.Cos(num1);
                parteEntera = Math.Truncate(num1);
                System.Console.WriteLine("Valor Absoluto: "+valorAbsoluto+"\nCuadrado: "+cuadrado+"\nRaiz Cuadrada: "+raizCuadrada+"\nSeno: "+seno+"\nCoseno: "+coseno+"\nParte Entera: "+parteEntera);
            System.Console.WriteLine("Calcular Maximo y Minimo:");
            num1 = Numeros();
            num2 = Numeros();
                maximo = Math.Max(num1,num2);
                minimo = Math.Min(num1,num2);
                System.Console.WriteLine("Maximo: "+maximo+"\nMinimo: "+minimo);
            break;
        case 6:
            break;
    }
    if (opcion >=1 && opcion <=4){
        System.Console.WriteLine("El Resultado es: " + resultado);
        Console.WriteLine("¿Desea realizar otro calculo?\n1. Si\n2. No");
        System.Console.WriteLine("--Seleccione una opcion:");
        cadena = Console.ReadLine();
        int.TryParse(cadena, out otra);
    }
} while (opcion != 6);

float Numeros(){
    float num = 0;
    while (!valido)
    {
        Console.WriteLine("Ingrese un numero:");
        cadena = Console.ReadLine();
        valido = float.TryParse(cadena, out num);
        if (!valido)
        {
            Console.WriteLine("Numero ingresado no valido!");
        }
    }
    valido = false;
    return num;
}*/

// EJERCICIO 4
