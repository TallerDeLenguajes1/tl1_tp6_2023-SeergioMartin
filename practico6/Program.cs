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

// EJERCICIO 2
